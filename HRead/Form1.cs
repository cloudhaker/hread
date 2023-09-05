using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace HRead
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private string OCR(Bitmap b)
        {
            string res = "";

            using (var engine = new TesseractEngine(@"tessdata", "vie", EngineMode.Default))
            {
                var pixImage = Pix.LoadFromMemory(ImageToByte(b));
                using (var page = engine.Process(pixImage, PageSegMode.AutoOnly))
                    res = page.GetText();
            }
            return res;
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            txtRes.Text = OCR((Bitmap)picImage.Image);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra Ctrl và V đã được nhấn
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Kiểm tra xem dữ liệu trong Clipboard có là hình ảnh hay không
                if (Clipboard.ContainsImage())
                {
                    // Lấy hình ảnh từ Clipboard
                    Image image = Clipboard.GetImage();

                    // Gán hình ảnh vào PictureBox
                    picImage.Image = image;

                    // Thay đổi kích thước PictureBox để hiển thị hình ảnh đầy đủ
                    picImage.SizeMode = PictureBoxSizeMode.AutoSize;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn file ảnh
            openFileDialog.Filter = "File ảnh|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
            openFileDialog.Title = "Chọn file ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh được chọn
                string filePath = openFileDialog.FileName;

                // Gán đường dẫn vào TextBox
                txtPath.Text = filePath;

                // Gán hình ảnh từ file vào PictureBox
                picImage.Image = Image.FromFile(filePath);

                // Thay đổi kích thước PictureBox để hiển thị hình ảnh đầy đủ
                picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            // Kiểm tra có hình ảnh trong PictureBox hay không
            if (picImage.Image == null) return;

            // Tạo đối tượng BarcodeReader
            BarcodeReader reader = new BarcodeReader();

            // Đọc ảnh từ PictureBox
            Bitmap image = new Bitmap(picImage.Image);

            // Đọc mã QR từ ảnh
            Result result = reader.Decode(image);

            // Kiểm tra xem mã QR có thành công hay không
            if (result != null)
            {
                txtRes.Text = result.Text;
            }
        }

        private void btnMakeQr_Click(object sender, EventArgs e)
        {
            if(txtRes.Text == null) return;
            // Tạo đối tượng BarcodeWriter
            BarcodeWriter writer = new BarcodeWriter();

            // Cấu hình BarcodeWriter để tạo mã QR
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = picImage.Width, // Chiều rộng của mã QR
                Height = picImage.Height, // Chiều cao của mã QR
            };

            // Chuyển đổi văn bản thành ảnh mã QR
            Bitmap qrCodeImage = writer.Write(txtRes.Text);

            // Hiển thị ảnh mã QR trên PictureBox
            picImage.Image = qrCodeImage;
        }

        bool status = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private void btnWc_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                StartWc();
                btnWc.Text = "Webcam OFF";
            }
            else
            {
                StopWc();
                btnWc.Text = "Webcam ON";
            }

            status = !status;
        }

        private void StartWc()
        {

            // Tìm kiếm và lấy danh sách thiết bị webcam
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Kiểm tra xem có thiết bị webcam nào được tìm thấy hay không
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thiết bị webcam.");
                return;
            }

            // Khởi tạo đối tượng VideoCaptureDevice với thiết bị webcam đầu tiên
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // Thiết lập sự kiện NewFrame để nhận hình ảnh mới từ webcam
            videoSource.NewFrame += VideoSource_NewFrame;

            // Bắt đầu streaming hình ảnh từ webcam
            videoSource.Start();
        }

        private void StopWc()
        {
            // Dừng streaming hình ảnh từ webcam khi đóng form
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Lấy hình ảnh mới từ webcam
            var frame = (System.Drawing.Bitmap)eventArgs.Frame.Clone();

            // Hiển thị hình ảnh lên control PictureBox từ luồng chính
            picImage.Invoke((MethodInvoker)delegate
            {
                picImage.Image = frame;
            });
        }

        private void btnIco_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog để người dùng chọn vị trí lưu
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Icon File|*.ico";
            saveFileDialog.Title = "Chọn vị trí lưu tệp ICO";
            saveFileDialog.ShowDialog();

            string icoFilePath = saveFileDialog.FileName; // Lấy đường dẫn đã được chọn để lưu tệp ICO

            if (!string.IsNullOrEmpty(icoFilePath))
            {
                // Lấy hình ảnh từ PictureBox
                Bitmap bitmap = new Bitmap(picImage.Image, new Size(128, 128));

                // Tạo đối tượng Icon từ đối tượng Bitmap
                using (Icon icon = Icon.FromHandle(bitmap.GetHicon()))
                {
                    // Tạo một luồng để ghi tệp ICO
                    using (FileStream stream = new FileStream(icoFilePath, FileMode.OpenOrCreate))
                    {
                        // Lưu đối tượng Icon thành tệp ICO
                        icon.Save(stream);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đường dẫn tệp không hợp lệ.");
            }
        }

        private void btnMakeBar_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == null) return;
            // Tạo đối tượng BarcodeWriter
            BarcodeWriter writer = new BarcodeWriter();

            // Cấu hình BarcodeWriter để tạo mã QR
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = picImage.Width, // Chiều rộng của mã QR
                Height = picImage.Height, // Chiều cao của mã QR
            };

            // Chuyển đổi văn bản thành ảnh mã QR
            Bitmap qrCodeImage = writer.Write(txtRes.Text);

            // Hiển thị ảnh mã QR trên PictureBox
            picImage.Image = qrCodeImage;
        }
    }
}

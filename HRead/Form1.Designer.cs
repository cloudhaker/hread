namespace HRead
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnWc = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnQr = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnMakeQr = new System.Windows.Forms.Button();
            this.btnMakeBar = new System.Windows.Forms.Button();
            this.btnIco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWc
            // 
            this.btnWc.Location = new System.Drawing.Point(16, 435);
            this.btnWc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWc.Name = "btnWc";
            this.btnWc.Size = new System.Drawing.Size(136, 28);
            this.btnWc.TabIndex = 0;
            this.btnWc.Text = "Webcam On";
            this.btnWc.UseVisualStyleBackColor = true;
            this.btnWc.Click += new System.EventHandler(this.btnWc_Click);
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(483, 383);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(8, 23);
            this.txtRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(514, 374);
            this.txtRes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(491, 406);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 383);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRes);
            this.groupBox2.Location = new System.Drawing.Point(529, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(530, 406);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(400, 435);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(159, 438);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(241, 22);
            this.txtPath.TabIndex = 5;
            // 
            // btnQr
            // 
            this.btnQr.Location = new System.Drawing.Point(537, 435);
            this.btnQr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(115, 28);
            this.btnQr.TabIndex = 0;
            this.btnQr.Text = "QR/Barcode";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(660, 435);
            this.btnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(100, 28);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "ORC Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnMakeQr
            // 
            this.btnMakeQr.Location = new System.Drawing.Point(893, 435);
            this.btnMakeQr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeQr.Name = "btnMakeQr";
            this.btnMakeQr.Size = new System.Drawing.Size(100, 28);
            this.btnMakeQr.TabIndex = 0;
            this.btnMakeQr.Text = "Make QR";
            this.btnMakeQr.UseVisualStyleBackColor = true;
            this.btnMakeQr.Click += new System.EventHandler(this.btnMakeQr_Click);
            // 
            // btnMakeBar
            // 
            this.btnMakeBar.Location = new System.Drawing.Point(768, 435);
            this.btnMakeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeBar.Name = "btnMakeBar";
            this.btnMakeBar.Size = new System.Drawing.Size(117, 28);
            this.btnMakeBar.TabIndex = 0;
            this.btnMakeBar.Text = "Make Barcode";
            this.btnMakeBar.UseVisualStyleBackColor = true;
            this.btnMakeBar.Click += new System.EventHandler(this.btnMakeBar_Click);
            // 
            // btnIco
            // 
            this.btnIco.Location = new System.Drawing.Point(997, 435);
            this.btnIco.Margin = new System.Windows.Forms.Padding(4);
            this.btnIco.Name = "btnIco";
            this.btnIco.Size = new System.Drawing.Size(57, 28);
            this.btnIco.TabIndex = 0;
            this.btnIco.Text = "ICO";
            this.btnIco.UseVisualStyleBackColor = true;
            this.btnIco.Click += new System.EventHandler(this.btnIco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "© 2023 LeHoan. Developed this software for non-commercial purposes to benefit the" +
    " community. Bonus MoMo: 0911060601";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMakeBar);
            this.Controls.Add(this.btnIco);
            this.Controls.Add(this.btnMakeQr);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnWc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRead © LeHoan";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWc;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMakeQr;
        private System.Windows.Forms.Button btnMakeBar;
        private System.Windows.Forms.Button btnIco;
        private System.Windows.Forms.Label label1;
    }
}


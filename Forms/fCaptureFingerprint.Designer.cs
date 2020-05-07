namespace DemoFingerprintForm.Forms
{
    partial class fCaptureFingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCaptureFingerprint));
            this.ptbFingerprint = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCapture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFingerprint)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbFingerprint
            // 
            this.ptbFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbFingerprint.Location = new System.Drawing.Point(2, 0);
            this.ptbFingerprint.Name = "ptbFingerprint";
            this.ptbFingerprint.Size = new System.Drawing.Size(395, 532);
            this.ptbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFingerprint.TabIndex = 0;
            this.ptbFingerprint.TabStop = false;
            this.ptbFingerprint.Click += new System.EventHandler(this.ptbFingerprint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCapture);
            this.panel1.Controls.Add(this.ptbFingerprint);
            this.panel1.Location = new System.Drawing.Point(9, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 599);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "                Đóng";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            //this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(288, 551);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(109, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "                Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapture.BorderRadius = 0;
            this.btnCapture.ButtonText = "               Chụp";
            this.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapture.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Iconcolor = System.Drawing.Color.Transparent;
           //this.btnCapture.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCapture.Iconimage")));
            this.btnCapture.Iconimage_right = null;
            this.btnCapture.Iconimage_right_Selected = null;
            this.btnCapture.Iconimage_Selected = null;
            this.btnCapture.IconMarginLeft = 0;
            this.btnCapture.IconMarginRight = 0;
            this.btnCapture.IconRightVisible = true;
            this.btnCapture.IconRightZoom = 0D;
            this.btnCapture.IconVisible = true;
            this.btnCapture.IconZoom = 90D;
            this.btnCapture.IsTab = false;
            this.btnCapture.Location = new System.Drawing.Point(161, 551);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.btnCapture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCapture.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapture.selected = false;
            this.btnCapture.Size = new System.Drawing.Size(112, 41);
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "               Chụp";
            this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Textcolor = System.Drawing.Color.White;
            this.btnCapture.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(420, 57);
            this.pnlHeader.TabIndex = 42;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 24);
            this.bunifuCustomLabel1.TabIndex = 93;
            this.bunifuCustomLabel1.Text = "DGIS";
            // 
            // fCaptureFingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(420, 670);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCaptureFingerprint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Fingerprint";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFingerprint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFingerprint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCapture;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
    }
}
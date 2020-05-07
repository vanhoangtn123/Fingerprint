namespace DemoFingerprintForm
{
    partial class fMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txbFolderSaveFingerprint = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnflFingerprint = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_L = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnflFingerprint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txbFolderSaveFingerprint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 58);
            this.panel1.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(466, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 37);
            this.button1.TabIndex = 45;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbFolderSaveFingerprint
            // 
            this.txbFolderSaveFingerprint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFolderSaveFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFolderSaveFingerprint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbFolderSaveFingerprint.HintForeColor = System.Drawing.Color.Empty;
            this.txbFolderSaveFingerprint.HintText = "";
            this.txbFolderSaveFingerprint.isPassword = false;
            this.txbFolderSaveFingerprint.LineFocusedColor = System.Drawing.Color.DarkGray;
            this.txbFolderSaveFingerprint.LineIdleColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbFolderSaveFingerprint.LineMouseHoverColor = System.Drawing.Color.DarkGray;
            this.txbFolderSaveFingerprint.LineThickness = 1;
            this.txbFolderSaveFingerprint.Location = new System.Drawing.Point(10, 20);
            this.txbFolderSaveFingerprint.Margin = new System.Windows.Forms.Padding(4);
            this.txbFolderSaveFingerprint.Name = "txbFolderSaveFingerprint";
            this.txbFolderSaveFingerprint.Size = new System.Drawing.Size(442, 29);
            this.txbFolderSaveFingerprint.TabIndex = 52;
            this.txbFolderSaveFingerprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên file";
            // 
            // pnflFingerprint
            // 
            this.pnflFingerprint.AutoScroll = true;
            this.pnflFingerprint.BackColor = System.Drawing.Color.White;
            this.pnflFingerprint.Controls.Add(this.Panel_L);
            this.pnflFingerprint.Location = new System.Drawing.Point(12, 76);
            this.pnflFingerprint.Name = "pnflFingerprint";
            this.pnflFingerprint.Size = new System.Drawing.Size(864, 800);
            this.pnflFingerprint.TabIndex = 43;
            // 
            // Panel_L
            // 
            this.Panel_L.AutoScroll = true;
            this.Panel_L.BackColor = System.Drawing.Color.White;
            this.Panel_L.Location = new System.Drawing.Point(3, 3);
            this.Panel_L.Name = "Panel_L";
            this.Panel_L.Size = new System.Drawing.Size(425, 1000);
            this.Panel_L.TabIndex = 44;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(884, 837);
            this.Controls.Add(this.pnflFingerprint);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dermatoglyphics Information System (DGIS)";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnflFingerprint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbFolderSaveFingerprint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel pnflFingerprint;
        private System.Windows.Forms.FlowLayoutPanel Panel_L;
    }
}


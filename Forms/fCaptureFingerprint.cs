using Bunifu.Framework.UI;
using Futronic.Devices.FS26;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFingerprintForm.Forms
{
    public partial class fCaptureFingerprint : Form
    {
        public fCaptureFingerprint(BunifuImageButton picturebox)
        {
            InitializeComponent();
            this.PictureboxMain = picturebox;
            save = true;
            new Thread(() =>
            {
                fingerprint();

            }).Start();
        }



        private BunifuImageButton pictureboxMain;

        public BunifuImageButton PictureboxMain { get => pictureboxMain; set => pictureboxMain = value; }


        #region  Control Events
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlHeader.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Bitmap finger = null;
        private void btnCapture_Click(object sender, EventArgs e)
        {
            save = false;
            ptbFingerprint.Image = Resize(finger, 0.58F);
            this.PictureboxMain.Image = Resize(finger, 0.58F);
            this.Close();
        }

        #endregion
        private bool save = true;
        private void ptbFingerprint_Click(object sender, EventArgs e)
        {

        }
        DeviceAccessor accessor = new DeviceAccessor();
        private void fingerprint()
        {
            try
            {
                using (var device = accessor.AccessFingerprintDevice())
                {
                    device.SwitchLedState(false, false);

                    while (save)
                    {
                        finger = device.ReadFingerprint();
                        ptbFingerprint.Invoke((Action)(() => ptbFingerprint.Image = Resize(finger, 0.58F)));
                        Thread.Sleep(20);
                    }
                    device.SwitchLedState(false, false);
                }
            }
            catch { }
        }
        public Image Resize(Image img, float percentage)
        {
            int originalW = img.Width;
            int originalH = img.Height;
            int resizedW = (int)(originalW * percentage);
            int resizedH = (int)(originalH * percentage);
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            graphic.Dispose();
            return (Image)bmp;
        }
    }
}

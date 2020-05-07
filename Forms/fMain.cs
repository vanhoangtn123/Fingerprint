using Bunifu.Framework.UI;
using DemoFingerprintForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFingerprintForm
{
    public partial class fMain : Form
    {

        static List<BunifuImageButton> ImageButtonList = new List<BunifuImageButton>();

        public fMain()
        {
            InitializeComponent();
            LoadPictureLeft();
            LoadPictureRight();
        }

        #region Control Events

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    pnlHeader.Capture = false;

            //    const int WM_NCLBUTTONDOWN = 0x00A1;
            //    const int HTCAPTION = 2;
            //    Message msg =
            //        Message.Create(this.Handle, WM_NCLBUTTONDOWN,
            //            new IntPtr(HTCAPTION), IntPtr.Zero);
            //    this.DefWndProc(ref msg);
            //}
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Picturebox_Click(object sender, EventArgs e)
        {
            fCaptureFingerprint f = new fCaptureFingerprint(sender as BunifuImageButton);
            f.ShowDialog();
        }

        private void btnChooseFolderSave_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.RootFolder = Environment.SpecialFolder.Desktop;
                if (dialog.ShowDialog() == DialogResult.OK)
                    txbFolderSaveFingerprint.Text = dialog.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        

        #region Method

        void LoadPictureLeft()
        {            for (int i = 0; i < 5; i++)
            {
                Panel pnl = i == 4 ? new Panel() { Size = new System.Drawing.Size(400, 190) } : new Panel() { Size = new System.Drawing.Size(400, 190) };
                for (int j = 1; j <= 3; j++)
                {
                    BunifuImageButton picturebox = new BunifuImageButton()
                    {
                        Name = "L" + (i * 3 + j),
                        Size = new System.Drawing.Size(120, 165),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                        Zoom = 7,
                        Cursor = System.Windows.Forms.Cursors.Hand,
                        BackColor = System.Drawing.Color.Transparent,
                        Image = null,
                        Location = new System.Drawing.Point(120 * (j - 1) + 10 * j, 0)
                    };
                    picturebox.Click += Picturebox_Click;
                    pnl.Controls.Add(picturebox);
                    ImageButtonList.Add(picturebox);
                }

                Label lbl = new Label()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    //ForeColor = System.Drawing.SystemColors.ButtonHighlight,
                    BackColor = System.Drawing.Color.Transparent,
                    Text = "L" + (i + 1),
                    Location = new System.Drawing.Point(180, 170)
                };
                pnl.Controls.Add(lbl);
                Panel_L.Controls.Add(pnl);
            }
        }


        void LoadPictureRight()
        {
            for (int i = 0; i < 5; i++)
            {
                Panel pnl = i == 4 ? new Panel() { Size = new System.Drawing.Size(400, 190) } : new Panel() { Size = new System.Drawing.Size(400, 190) };
                //Panel pnl = new Panel() { Size = new System.Drawing.Size(800, 253) };
                for (int j = 1; j <= 3; j++)
                {
                    BunifuImageButton picturebox = new BunifuImageButton()
                    {
                        Name = "R" + (i * 3 + j),
                        Size = new System.Drawing.Size(120, 165),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                        BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                        Zoom = 7,
                        Cursor = System.Windows.Forms.Cursors.Hand,
                        BackColor = System.Drawing.Color.Transparent,
                        Image = null,
                        Location = new System.Drawing.Point(120 * (j - 1) + 10 * j, 0)
                    };
                    picturebox.Click += Picturebox_Click;
                    pnl.Controls.Add(picturebox);
                    ImageButtonList.Add(picturebox);
                }
                
                Label lbl = new Label()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    //ForeColor = System.Drawing.SystemColors.ButtonHighlight,
                    BackColor = System.Drawing.Color.Transparent,
                    Text = "R" + (i + 1),
                    Location = new System.Drawing.Point(180, 170)
                };
                pnl.Controls.Add(lbl);
                //Panel_R.Controls.Add(pnl);
            }
        }
        #endregion
        private void reset()
        {
            for (int i = 0; i < ImageButtonList.Count; i++)
            {
                ImageButtonList[i].Image = null;
            }
            txbFolderSaveFingerprint.Text = null;
            //BunifuImageButton picturebox = new BunifuImageButton()
            //{
            //    Name = "R" + (i + 1),
            //    Size = new System.Drawing.Size(150, 215),
            //    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            //    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            //    Zoom = 7,
            //    Cursor = System.Windows.Forms.Cursors.Hand,
            //    BackColor = System.Drawing.Color.Transparent,
            //    Image = null
            //};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbFolderSaveFingerprint.Text == "") { MessageBox.Show("Chưa nhập tên File!"); return; }

            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.SelectedPath + "\\" + txbFolderSaveFingerprint.Text + ".jpg")) { MessageBox.Show("Tên file đã tồn tại!"); return; }
                    #region l

                    int Widthl = this.Panel_L.Width;
                    int Heightl = this.Panel_L.Height;
                    Bitmap bmpl = new Bitmap(Widthl, Heightl);
                    this.Panel_L.DrawToBitmap(bmpl, new Rectangle(0, 0, Widthl, Widthl));

                    //#endregion
                    //#region R
                    //int Widthr = this.Panel_R.Width;
                    //int Heightr = this.Panel_R.Height;
                    //Bitmap bmpr = new Bitmap(Widthr, Heightr);

                    //this.Panel_R.DrawToBitmap(bmpr, new Rectangle(0, 0, Widthr, Heightr));
                    #endregion

                    // Bitmap bmp = MergeTwoImages(bmpl, bmpr);
                    //Bitmap bmp = bmpl;
                    //MessageBox.Show(bmp.Width.ToString());
                    //PdfDocument doc = new PdfDocument();
                    //doc.Info.Title = txbid.Text;
                    //PdfPage page = doc.AddPage();
                    //XGraphics gfx = XGraphics.FromPdfPage(page);
                    //XFont font = new XFont("", 20, XFontStyle.BoldItalic);
                    //gfx.DrawString(txbid.Text, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormat.Center);

                    //XPoint x=new XPoint()
                    //XImage image = bmp;
                    //gfx.DrawImage(bmp);

                    bmpl.Save(dialog.SelectedPath + "\\" + txbFolderSaveFingerprint.Text + ".jpg");
                    MessageBox.Show("Lưu thành công!");

                    reset();
                    //pnflFingerprint = new FlowLayoutPanel();
                    //LoadPictureLeft();
                    //LoadPictureRight();

                }
            }
        }
        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width + secondImage.Width+1;

            int outputImageHeight = firstImage.Height;

            Console.WriteLine(firstImage.Width);
            Console.WriteLine(firstImage.Height);
            Console.WriteLine(firstImage.Width);
            Console.WriteLine(firstImage.Height);


            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(0,0), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);

                graphics.DrawImage(secondImage, new Rectangle(new Point(firstImage.Width + 1, 0), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }
            
            return outputImage;
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}

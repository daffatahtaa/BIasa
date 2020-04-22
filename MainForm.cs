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

namespace Editor_Biasa
{
    public partial class MainForm : Form
    {

        private double ZOOMFACTOR = 1.25;
        private int MINMAX = 5;

        Bitmap newBit;

        FormCollection o = Application.OpenForms;

        public Image inputImage {
            get { return pbInput.Image;}
            set { pbInput.Image = value; }
        }

        public Image outputImage {
            get { return pbOutput.Image; }
            set { pbOutput.Image = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            this.bScroll.Minimum = -255;
            this.bScroll.Maximum = 255;
            this.bScroll.Value = 1;

            this.cScroll.Maximum = 10;
            this.bScroll.Value = 1;

            if (pbInput.Image == null) {
                optionsBtn.Enabled = false;
            }
            time.Visible = false;

            red.Visible = false;
            green.Visible = false;
            blue.Visible = false;

        }

        private void bBar_Scroll(object sender, EventArgs e)
        {
            brighText.Text = bScroll.Value.ToString();
            pbOutput.Image = adjustBrightness(newBit, bScroll.Value);
        }

        public static Bitmap adjustBrightness(Bitmap Image, int value)
        {
            Bitmap tempBit = Image;

            float v = value / 255.0f;
            Bitmap newBit = new Bitmap(tempBit.Width, tempBit.Height);
            Graphics newGraphics = Graphics.FromImage(newBit);
            float[][] f = {
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0, 0, 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {v, v, v, 1, 1}
            };
            ColorMatrix newMatrix = new ColorMatrix(f);
            ImageAttributes a = new ImageAttributes();
            a.SetColorMatrix(newMatrix);
            newGraphics.DrawImage(tempBit, new Rectangle(0, 0, tempBit.Width, tempBit.Height), 0, 0, tempBit.Width, tempBit.Height, GraphicsUnit.Pixel, a);
            return newBit;

        }

        private void cBar_Scroll(object sender, EventArgs e)
        {
            cText.Text = cScroll.Value.ToString();
            pbOutput.Image = adjustContrast(newBit, cScroll.Value);
        }

        public static Bitmap adjustContrast(Bitmap Image, int value)
        {
            float contrast = 0;


            contrast = 1 * ( value - 256 ) + 256;
            Bitmap tempBit = Image;

            Bitmap b = new Bitmap(tempBit.Width, tempBit.Height);

            Graphics g = Graphics.FromImage(b);
            ImageAttributes iA = new ImageAttributes();
            ColorMatrix cMatrix = new ColorMatrix(new float[][] {
                new float[] {contrast, 0f, 0f, 0f, 0f},
                new float[] {0f, contrast, 0f, 0f, 0f},
                new float[] {0f, 0f, contrast, 0f, 0f},
                new float[] {0f, 0f, 0f, 1f, 0f},
                new float[] {0.001f, 0.001f, 0.001f, 0f, 1f}
            });

            iA.SetColorMatrix(cMatrix);
            g.DrawImage(tempBit, new Rectangle(0, 0, tempBit.Width, tempBit.Height), 0, 0, tempBit.Width, tempBit.Height, GraphicsUnit.Pixel, iA);
            return b;
        }

        private void openImage_Click(object sender, EventArgs e)
        {

            pbInput.Image = null;
            pbOutput.Image = null;
            mouseY.Text = "";
            mouseX.Text = "";
            directory.Text = "";
            xText.Text = "";
            yText.Text = "";
            sizeText.Text = "";
            optionsBtn.Enabled = false;


            OpenFileDialog img = new OpenFileDialog();
            img.Title = "Open Image File...";
            img.Filter = "Image File (*.bmp, *.jpg, *.jpeg, *.png |*.bmp;*.jpg; *.jpeg;*.png";

            if (img.ShowDialog() == DialogResult.OK) {
                pbInput.Image = new Bitmap(img.FileName);
                pbOutput.Image = new Bitmap(img.FileName);
                newBit = new Bitmap(img.FileName);

                optionsBtn.Enabled = true;

                DirectoryInfo DI = new DirectoryInfo(img.FileName);
                directory.Text = DI.FullName;

                FileInfo size = new FileInfo(img.FileName);
                double kb = size.Length / 1024.0;

                if (kb <= 1023) {
                    sizeText.Text = String.Format("{0:0.00}", kb) + " Kilobyte";
                }

                else {
                    double mb = size.Length / ( 1024.0 * 1024.0 );
                    sizeText.Text = String.Format("{0:0.00}", mb) + " Megabyte";
                }

                var res = Image.FromFile(img.FileName);
                xText.Text = res.Width.ToString();
                yText.Text = res.Height.ToString();

                Init(); //buat zoom. Kalo mau coba zoom block Init(); nya, terus tekan Ctrl+K, Ctrl+U
                        //                                              kalo mau comment Ctrl+K, Ctrl+C
            }
        }



        private void pbInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbInput.Image == null) {
                mouseY.Text = "";
                mouseX.Text = "";

                red.Visible = false;
                green.Visible = false;
                blue.Visible = false;
            }

            else {
                Bitmap b = new Bitmap(pbInput.Image);
                int x = b.Width * e.X / pbInput.Width;
                int y = b.Height * e.Y / pbInput.Height;

                mouseX.Text = x.ToString();
                mouseY.Text = y.ToString();

                Color c = b.GetPixel(x, y);

                red.Visible = true;
                green.Visible = true;
                blue.Visible = true;

                red.Text = c.R.ToString();
                green.Text = c.G.ToString();
                blue.Text = c.B.ToString();

                backColor.BackColor = c;

                string h = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
                hex.Text = "#" + h;
            }



        }

        private void Init()
        {
            pbInput.Location = new Point(0, 0);
            pbOutput.Location = new Point(0, 0);

            panelInput.AutoScroll = true;
            panelOutput.AutoScroll = true;

            panelInput.MouseEnter += new EventHandler(pbInput_MouseEnter);
            panelOutput.MouseEnter += new EventHandler(pbOutput_MouseEnter);

            pbInput.MouseEnter += new EventHandler(pbInput_MouseEnter);
            pbOutput.MouseEnter += new EventHandler(pbOutput_MouseEnter);

            panelInput.MouseWheel += new MouseEventHandler(pbInput_MouseWheel);
            panelOutput.MouseWheel += new MouseEventHandler(pbOutput_MouseWheel);
        }

        private void ZoomOutInput()
        {
            if (( pbInput.Width < ( MINMAX * panelInput.Width ) ) &&
                ( pbInput.Height < ( MINMAX * panelInput.Height ) )) {
                pbInput.Width = Convert.ToInt32(pbInput.Width * ZOOMFACTOR);
                pbInput.Height = Convert.ToInt32(pbInput.Height * ZOOMFACTOR);
                pbInput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ZoomInInput()
        {
            if (( pbInput.Width > ( panelInput.Width / MINMAX ) ) &&
                ( pbInput.Height > ( panelInput.Height / MINMAX ) )) {
                pbInput.Width = Convert.ToInt32(pbInput.Width / ZOOMFACTOR);
                pbInput.Height = Convert.ToInt32(pbInput.Height / ZOOMFACTOR);
                pbInput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ZoomInOutput()
        {
            if (( pbOutput.Width > ( panelOutput.Width / MINMAX ) ) &&
                ( pbOutput.Height > ( panelOutput.Height / MINMAX ) )) {
                pbOutput.Width = Convert.ToInt32(pbOutput.Width / ZOOMFACTOR);
                pbOutput.Height = Convert.ToInt32(pbOutput.Height / ZOOMFACTOR);
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ZoomOutOutput()
        {
            if (( pbOutput.Width < ( MINMAX * panelOutput.Width ) ) &&
                ( pbOutput.Height < ( MINMAX * panelOutput.Height ) )) {
                pbOutput.Width = Convert.ToInt32(pbOutput.Width * ZOOMFACTOR);
                pbOutput.Height = Convert.ToInt32(pbOutput.Height * ZOOMFACTOR);
                pbOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void pbInput_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0) {
                ZoomInInput();
            }

            else {
                ZoomOutInput();
            }
        }

        private void pbOutput_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0) {
                ZoomInOutput();
            }

            else {
                ZoomOutOutput();
            }
        }

        private void pbInput_MouseEnter(object sender, EventArgs e)
        {
            if (pbInput.Focused == false) {
                mouseY.Text = "";
                mouseX.Text = "";

                red.Text = "";
                green.Text = "";
                blue.Text = "";

                backColor.BackColor = default(Color);

                hex.Text = "";

            }
        }


        private void pbOutput_MouseEnter(object sender, EventArgs e)
        {
            if (pbOutput.Focused == false) {
                mouseY.Text = "";
                mouseX.Text = "";

                red.Text = "";
                green.Text = "";
                blue.Text = "";

                backColor.BackColor = default(Color);

                hex.Text = "";
            }
        }

        private void options_Click(object sender, EventArgs e)
        {
            OptionsForm oF = new OptionsForm(pbInput.Image, pbOutput.Image);
            oF.FormClosed += (s, a) => optionsBtn.Enabled = true;
            optionsBtn.Enabled = false;
            oF.Show();
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            mouseY.Text = "";
            mouseX.Text = "";

            red.Text = "";
            green.Text = "";
            blue.Text = "";

            backColor.BackColor = default(Color);

            hex.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("dd-MMM-yyyy | hh:mm:ss tt");
            timer.Start();
            time.Visible = true;
        }

        private void grayscale_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pbInput.Image);

            int width = bmp.Width;
            int height = bmp.Height;

            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            pbOutput.Image = bmp;
        }
    }
}

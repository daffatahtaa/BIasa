using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Editor_Biasa;

namespace Editor_Biasa
{
    public partial class OptionsForm : Form
    {

        MainForm m = new MainForm();

        public OptionsForm(Image imageIn, Image imageOut)
        {
            InitializeComponent();

            m.inputImage = imageIn;
            m.outputImage = imageOut;
        }

        private void hist1_Click(object sender, EventArgs e)
        {
            Histogram h1 = new Histogram(m.inputImage);
            h1.FormClosed += (s, a) => hist1.Enabled = true;
            hist1.Enabled = false;
            h1.Show();
        }

        private void hist2_Click(object sender, EventArgs e)
        {
            Histogram h2 = new Histogram(m.outputImage);
            h2.FormClosed += (s, a) => hist2.Enabled = true;
            hist2.Enabled = false;
            h2.Show();
        }
    }
}

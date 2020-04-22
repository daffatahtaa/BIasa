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

namespace Editor_Biasa
{
    public partial class Histogram : Form
    {
        public Histogram(Image image)
        {
            InitializeComponent();

            Bitmap b = new Bitmap(image);

            String[] seriesArray = { "Red", "Green", "Blue" };
            int[] pointsArray = { 1, 2, 3 };


            int[] histogram_r = new int[256];
            int[] histogram_g = new int[256];
            int[] histogram_b = new int[256];

            float max = 0;
            for (int i = 0; i < b.Width; i++) {
                for (int j = 0; j < b.Height; j++) {
                    int redValue = b.GetPixel(i, j).R;
                    int greenValue = b.GetPixel(i, j).G;
                    int blueValue = b.GetPixel(i, j).B;
                    histogram_r[redValue]++;
                    histogram_g[greenValue]++;
                    histogram_b[blueValue]++;
                    if (max < histogram_r[redValue])
                        max = histogram_r[redValue];
                    if (max < histogram_g[greenValue])
                        max = histogram_g[greenValue];
                    if (max < histogram_b[blueValue])
                        max = histogram_b[blueValue];
                }
            }

            histChart.Titles.Add("RGB Histogram");

            for (int j = 0; j < seriesArray.Length; j++) {
                Series series = histChart.Series.Add(seriesArray[j]);
                for (int i = 0; i < histogram_r.Length; i++) {
                    if (j == 0) {
                        series.Points.Add(histogram_r[i]);
                    }
                    else if (j == 1) {
                        series.Points.Add(histogram_g[i]);
                    }
                    else {
                        series.Points.Add(histogram_b[i]);
                    }

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class ImageProcessing : Form
    {
        public ImageProcessing()
        {
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "resimler|*.bmp|All Files|*.*";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            In.ImageLocation = sfd.FileName;
        }

        private void GreyScaleFilter_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(In.Image);
            Bitmap grey = Grey(image);

            Out.Image = grey;
        }

        private void FilterRedComponent_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(In.Image);
            Bitmap red = Red(image);

            Out.Image = red;
        }

        private void FilterGreenComponent_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(In.Image);
            Bitmap green = Green(image);

            Out.Image = green;
        }

        private void FilterBlueComponent_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(In.Image);
            Bitmap blue = Blue(image);

            Out.Image = blue;
        }

        private void MovingAverageFilter_Click(object sender, EventArgs e)
        {
            Color takeColor;
            Bitmap InImage, OutImage;
            InImage = new Bitmap(In.Image);

            int width = InImage.Width;
            int height = InImage.Height;

            OutImage = new Bitmap(width, height);

            int templateSize = 3;
            int x, y, i, j, sumR, sumG, sumB, meanR, meanG, meanB;

            for (x = (templateSize - 1) / 2; x < width - (templateSize - 1) / 2; x++)
            {
                for (y = (templateSize - 1) / 2; y < height - (templateSize - 1) / 2; y++)
                {
                    sumR = 0;
                    sumG = 0;
                    sumB = 0;
                    for (i = -((templateSize - 1) / 2); i <= (templateSize - 1) / 2; i++)
                    {
                        for (j = -((templateSize - 1) / 2); j <= (templateSize - 1) / 2; j++)
                        {
                            takeColor = InImage.GetPixel(x + i, y + j);

                            sumR = sumR + takeColor.R;
                            sumG = sumG + takeColor.G;
                            sumB = sumB + takeColor.B;
                        }
                    }

                    meanR = sumR / (templateSize * templateSize);
                    meanG = sumG / (templateSize * templateSize);
                    meanB = sumB / (templateSize * templateSize);

                    OutImage.SetPixel(x, y, Color.FromArgb(meanR, meanG, meanB));

                }
            }

            Out.Image = OutImage;
        }

        private void MovingMedianFilter_Click(object sender, EventArgs e)
        {
            Color takeColor;
            Bitmap inImage, OutImage;

            inImage = new Bitmap(In.Image);

            int width = inImage.Width;
            int height = inImage.Height;

            OutImage = new Bitmap(width, height);

            int templateSize = 3;
            int quantity = templateSize * templateSize;

            int[] R = new int[quantity];
            int[] G = new int[quantity];
            int[] B = new int[quantity];
            int[] Grey = new int[quantity];


            int x, y, i, j;

            for (x = (templateSize - 1) / 2; x < width - (templateSize - 1) / 2; x++)
            {
                for (y = (templateSize - 1) / 2; y < height - (templateSize - 1) / 2; y++)
                {
                    int k = 0;
                    for (i = -((templateSize - 1) / 2); i <= (templateSize - 1) / 2; i++)
                    {
                        for (j = -((templateSize - 1) / 2); j <= (templateSize - 1) / 2; j++)
                        {
                            takeColor = inImage.GetPixel(x + i, y + j);
                            R[k] = takeColor.R;
                            G[k] = takeColor.G;
                            B[k] = takeColor.B;
                            Grey[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114);
                            k++;
                        }
                    }

                    int counter = 0;

                    for (i = 0; i < quantity; i++)
                    {
                        for (j = i + 1; j < quantity; j++)
                        {
                            if (Grey[j] < Grey[i])
                            {
                                counter = Grey[i];
                                Grey[i] = Grey[j];
                                Grey[j] = counter;
                                counter = R[i];
                                R[i] = R[j];
                                R[j] = counter;
                                counter = G[i];
                                G[i] = G[j];
                                G[j] = counter;
                                counter = B[i];
                                B[i] = B[j];
                                B[j] = counter;
                            }
                        }
                    }

                    OutImage.SetPixel(x, y, Color.FromArgb(R[(quantity - 1) / 2], G[(quantity - 1) / 2], B[(quantity - 1) / 2]));
                }
            }

            Out.Image = OutImage;
        }

        private Bitmap Grey(Bitmap gbmp)
        {
            for (int i = 0; i < gbmp.Height - 1; i++)
            {
                for (int j = 0; j < gbmp.Width - 1; j++)
                {
                    int value = (gbmp.GetPixel(j, i).R + gbmp.GetPixel(j, i).G + gbmp.GetPixel(j, i).B) / 3;
                    Color color;
                    color = Color.FromArgb(value, value, value);
                    gbmp.SetPixel(j, i, color);
                }
            }
            return gbmp;
        }

        private Bitmap Red(Bitmap rbmp)
        {
            for (int i = 0; i < rbmp.Height; i++)
            {
                for (int j = 0; j < rbmp.Width; j++)
                {
                    int a = rbmp.GetPixel(j, i).A;
                    int r = rbmp.GetPixel(j, i).R;
                    Color color;
                    color = Color.FromArgb(a, r, 0, 0);
                    rbmp.SetPixel(j, i, color);
                }

            }
            return rbmp;
        }

        private Bitmap Green(Bitmap gbmp)
        {
            for (int i = 0; i < gbmp.Height; i++)
            {
                for (int j = 0; j < gbmp.Width; j++)
                {
                    int a = gbmp.GetPixel(j, i).A;
                    int g = gbmp.GetPixel(j, i).G;
                    Color color;
                    color = Color.FromArgb(a, 0, g, 0);
                    gbmp.SetPixel(j, i, color);
                }

            }
            return gbmp;
        }

        private Bitmap Blue(Bitmap bbmp)
        {
            for (int i = 0; i < bbmp.Height; i++)
            {
                for (int j = 0; j < bbmp.Width; j++)
                {
                    int a = bbmp.GetPixel(j, i).A;
                    int b = bbmp.GetPixel(j, i).B;
                    Color color;
                    color = Color.FromArgb(a, 0, 0, b);
                    bbmp.SetPixel(j, i, color);
                }
            }
            return bbmp;
        }
    }
}

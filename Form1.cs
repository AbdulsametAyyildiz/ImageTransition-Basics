using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.Util;
using System.Windows.Forms;

namespace ImageTransition
{
    public partial class Form1 : Form
    {
        public Bitmap imgFrom;
        public Bitmap imgTo;
        public Bitmap imgMid;
        public int intervalCount;
        public int interval;
        public int vWipIndx;
        public int hWipIndx;

        public double[,,] Map_Mat = new double[3, 800, 534];

        public Form1()
        {
            InitializeComponent();
        }

        private void load1Btn_Click(object sender, EventArgs e)
        {
            imgFrom = new Bitmap("C:/Users/abdus/Documents/GitHub/ImageTransition/Images/seljuk.jpg");
            pictureBox1.Image = imgFrom;
        }

        private void load2Btn_Click(object sender, EventArgs e)
        {
            imgTo = new Bitmap("C:/Users/abdus/Documents/GitHub/ImageTransition/Images/ottoman.jpg");
            pictureBox2.Image = imgTo;
        }

        private void fadeBtn_Click(object sender, EventArgs e)
        {
            imgMid = new Bitmap(imgFrom);
            pictureBox3.Image = imgMid;
            interval = trackBar1.Value;
            intervalCount = interval;
            for(int x = 0; x < pictureBox1.Image.Width; x++)
                for(int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    int FromR, ToR;
                    int FromG, ToG;
                    int FromB, ToB;

                    FromR = imgFrom.GetPixel(x, y).R;
                    FromG = imgFrom.GetPixel(x, y).G;
                    FromB = imgFrom.GetPixel(x, y).B;

                    ToR = imgTo.GetPixel(x, y).R;
                    ToG = imgTo.GetPixel(x, y).G;
                    ToB = imgTo.GetPixel(x, y).B;

                    Map_Mat[0, x, y] = (ToR - FromR) / (double)intervalCount;
                    Map_Mat[1, x, y] = (ToG - FromG) / (double)intervalCount;
                    Map_Mat[2, x, y] = (ToB - FromB) / (double)intervalCount;
                }
            timer1.Enabled = true;
        }

        private void verticalBtn_Click(object sender, EventArgs e)
        {
            imgMid = new Bitmap(imgFrom);
            pictureBox3.Image = imgMid;
            interval = trackBar1.Value;
            intervalCount = interval;
            vWipIndx = 0;

            timer2.Enabled = true;
        }

        private void horizontalBtn_Click(object sender, EventArgs e)
        {
            imgMid = new Bitmap(imgFrom);
            pictureBox3.Image = imgMid;
            interval = trackBar1.Value;
            intervalCount = interval;
            hWipIndx = 0;

            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (intervalCount <= 0) timer1.Enabled = false;
            else
            {
                for (int x = 0; x < pictureBox1.Image.Width; x++)
                    for (int y = 0; y < pictureBox1.Image.Height; y++)
                    {
                        int MidR, FromR;
                        int MidG, FromG;
                        int MidB, FromB;

                        FromR = imgFrom.GetPixel(x, y).R;
                        FromG = imgFrom.GetPixel(x, y).G;
                        FromB = imgFrom.GetPixel(x, y).B;

                        MidR = (int)(FromR + (interval - intervalCount + 1) * Map_Mat[0, x, y]);
                        MidG = (int)(FromG + (interval - intervalCount + 1) * Map_Mat[1, x, y]);
                        MidB = (int)(FromB + (interval - intervalCount + 1) * Map_Mat[2, x, y]);



                        imgMid.SetPixel(x, y, Color.FromArgb(MidR, MidG, MidB));
                    }
                pictureBox3.Image = imgMid;
                intervalCount--;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (vWipIndx >= imgFrom.Width) timer2.Enabled = false;

            else
            {

                for (int i = 0; i < intervalCount; i++)
                {
                    if (vWipIndx < imgFrom.Width)
                    {
                        for (int j = 0; j < imgFrom.Height; j++)
                        {
                            int ToR;
                            int ToG;
                            int ToB;

                            ToR = imgTo.GetPixel(vWipIndx, j).R;
                            ToG = imgTo.GetPixel(vWipIndx, j).G;
                            ToB = imgTo.GetPixel(vWipIndx, j).B;

                            imgMid.SetPixel(vWipIndx, j, Color.FromArgb(ToR, ToG, ToB));
                        }
                        vWipIndx++;
                    }

                }
                pictureBox3.Image = imgMid;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (hWipIndx >= imgFrom.Height) timer3.Enabled = false;
            else
            {

                for (int i = 0; i < intervalCount; i++)
                {
                    if (hWipIndx < imgFrom.Height)
                    {
                        for (int j = 0; j < imgFrom.Width; j++)
                        {
                            int ToR;
                            int ToG;
                            int ToB;

                            ToR = imgTo.GetPixel(j, hWipIndx).R;
                            ToG = imgTo.GetPixel(j, hWipIndx).G;
                            ToB = imgTo.GetPixel(j, hWipIndx).B;

                            imgMid.SetPixel(j, hWipIndx, Color.FromArgb(ToR, ToG, ToB));
                        }
                        hWipIndx++;
                    }

                }
                pictureBox3.Image = imgMid;

            }
        }
    }
}

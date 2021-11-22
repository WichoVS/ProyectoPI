using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PruebaWFA
{
    public partial class Camara : Form
    {
        //FilterInfoCollection miDispositivos;
        //VideoCaptureDevice miCamara;

        double TotalFrame;
        double fps;
        int FrameNo;
        bool isReadingFrame;
        bool isVideoSelect = false;
        int vH = 0;
        int vW = 0;
        VideoCapture capture;
        List<Image> videoSave = new List<Image>();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public int[,] matrizSobel = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        public int[,] matrizBlur = { { 0, 2, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public int[,] matrizPrewitt = { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
        public int[,] matrizEmboss = { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
        public int[,] matrizScharr = { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };

        //Erosion = 1
        //Sobel = 2
        //Glitch = 3
        //Prewitt = 4
        //Emboss = 5
        int filter = 0;


        public Camara()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            Camara pantallaCamara = new Camara();
            pantallaCamara.ShowDialog();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnEditTab_MouseDown(object sender, MouseEventArgs e)
        {
            EdicionImagen wEdit = new EdicionImagen();
            this.Hide();
            wEdit.ShowDialog();
        }

        private void btnManual_MouseDown(object sender, MouseEventArgs e)
        {
            Manual wManual = new Manual();
            this.Hide();
            wManual.ShowDialog();
        }

        private void setHistogramas(int[] pRedC, int[] pGreenC, int[] pBlueC)
        {

            histogramaRedV.Values = pRedC;
            histogramaRedV.Color = Color.Red;
            histogramGreenV.Values = pGreenC;
            histogramGreenV.Color = Color.Green;
            histogramBlueV.Values = pBlueC;
            histogramBlueV.Color = Color.Blue;
        }


        private int[] getHistogramaRed(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.R]++;
                }
            }
            return array;
        }

        private int[] getHistogramaGreen(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.G]++;
                }
            }
            return array;
        }
        private int[] getHistogramaBlue(Bitmap pImagen)
        {
            int[] array = new int[256];
            Color rColor = new Color();
            for (int x = 0; x < pImagen.Width; x++)
            {
                for (int y = 0; y < pImagen.Height; y++)
                {
                    rColor = pImagen.GetPixel(x, y);
                    array[rColor.B]++;
                }
            }
            return array;

        }

        private void btnCargarVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files(*.mp4)|*.mp4";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                capture.QuerySmallFrame();


                Mat m = new Mat();
                capture.Read(m);
                VideoPlayer.Image = m.Bitmap;
                isVideoSelect = true;
                TotalFrame = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                Bitmap[] videoEditado = new Bitmap[(int)TotalFrame];
                fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (isVideoSelect)
            {
                isReadingFrame = true;
                ReadAllFrames();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un video Primero", "Selecciona un Video", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private async void ReadAllFrames()
        {
            Mat m = new Mat();
            while (isReadingFrame == true && FrameNo < TotalFrame - 1)
            {
                //FrameNo += Convert.ToInt16(numer)
                FrameNo++;
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, FrameNo);
                capture.Read(m);
                switch (filter)
                {
                    case 1:

                        VideoPlayer.Image = Algoritmos.grayScaleVideo(m.Bitmap);
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    case 2:

                        VideoPlayer.Image = Algoritmos.sepiaFilterVideo(m.Bitmap);
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    case 3:

                        VideoPlayer.Image = Algoritmos.negativeFilterVideo(m.Bitmap);
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    case 4:

                        VideoPlayer.Image = Algoritmos.applyFilterMatrix(m.Bitmap, matrizPrewitt);
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    case 5:

                        VideoPlayer.Image = Algoritmos.applyFilterMatrix(m.Bitmap, matrizEmboss);
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    case 0:

                        VideoPlayer.Image = m.Bitmap;
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                    default:
                        VideoPlayer.Image = m.Bitmap;
                        await Task.Delay(100 / Convert.ToInt16(fps));

                        break;
                }
                //VideoPlayer.Image;
                setHistogramas(getHistogramaRed((Bitmap)VideoPlayer.Image), getHistogramaGreen((Bitmap)VideoPlayer.Image), getHistogramaBlue((Bitmap)VideoPlayer.Image));
                videoSave.Add(VideoPlayer.Image);

            }
            if (FrameNo >= TotalFrame)
            {
                FrameNo = 0;
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            isReadingFrame = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnErosionVideo_Click(object sender, EventArgs e)
        {
            filter = 1;
        }

        private void btnSobelVideo_Click(object sender, EventArgs e)
        {
            filter = 2;
        }

        private void btnGlitchVideo_Click(object sender, EventArgs e)
        {
            filter = 3;
        }

        private void btnPrewittVideo_Click(object sender, EventArgs e)
        {
            filter = 4;
        }

        private void btnEmbossVideo_Click(object sender, EventArgs e)
        {
            filter = 5;
        }

        private void btnOriginalVideo_Click(object sender, EventArgs e)
        {
            filter = 0;
        }

        private void btnReiniciarVideo_Click(object sender, EventArgs e)
        {
            FrameNo = 0;
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 0);
            isReadingFrame = true;
            ReadAllFrames();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGuardarVideo_Click(object sender, EventArgs e)
        {
            //Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            //dlg.Filter = "MP4 (.mp4)|.mp4";

            //dlg.RestoreDirectory = false;
            //bool? success = dlg.ShowDialog();
            //if (success == true)
            //{

            //    VideoCapture writeCapture = capture;

            //    VideoWriter VideoW = new VideoWriter(dlg.FileName,
            //                   VideoWriter.Fourcc('P', 'I', 'M', '3'),
            //                    Convert.ToUInt16(fps),
            //                  new System.Drawing.Size(vW, vH),
            //                   true);

            //    foreach (var img in videoSave)
            //    {
            //        //m = img.Mat;


            //        //writeCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, frameNoVideoW);
            //        //m = img;  //writeCapture.QuerySmallFrame();
            //        if (m != null)
            //        {

            //            VideoW.Write(m);

            //        }


            //    }
            //}
        }
    }
}
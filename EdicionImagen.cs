using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Math;

namespace PruebaWFA
{
    public partial class EdicionImagen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        public EdicionImagen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCamaraTab_MouseDown(object sender, MouseEventArgs e)
        {
            Camara wCamara = new Camara();
            this.Hide();
            wCamara.ShowDialog();
        }

        private void btnManual_MouseDown(object sender, MouseEventArgs e)
        {
            Manual wManual = new Manual();
            this.Hide();
            wManual.ShowDialog();
        }

        private void btn_Salir_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_MouseDown(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp;)|*.jpg;*.jpeg;*.png;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                editorImagen.Image = new Bitmap(open.FileName);

                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void setHistogramas(int[] pRedC, int[] pGreenC, int[] pBlueC)
        {

            histogramaRed.Values = pRedC;
            histogramaRed.Color = Color.Red;
            histogramGreen.Values = pGreenC;
            histogramGreen.Color = Color.Green;
            histogramBlue.Values = pBlueC;
            histogramBlue.Color = Color.Blue;
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
    }
}

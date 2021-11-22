using System;

using System.Drawing;

using System.Windows.Forms;
using System.IO;
using ProyectoPDI;
using System.Drawing.Imaging;


namespace PruebaWFA
{
    public partial class EdicionImagen : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Bitmap ImgOriginal = null;
        public Bitmap ImgEditada = null;
        Mensaje wMensaje;



        public int[,] matrizSobel = { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };
        public int[,] matrizBlur = { { 0, 2, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public int[,] matrizPrewitt = { { 1, 1, 1 }, { 0, 0, 0 }, { -1, -1, -1 } };
        public int[,] matrizEmboss = { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
        public int[,] matrizScharr = { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };

        //0.2126*R + 0.7152*G + 0.0722*B

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        public EdicionImagen()
        {
            InitializeComponent();
            wMensaje = new Mensaje();
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
                ImgOriginal = new Bitmap(open.FileName);
                ImgEditada = ImgOriginal;
                editorImagen.Image = ImgOriginal;


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

        private void btnOriginal_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            if (ImgOriginal != null)
                editorImagen.Image = ImgOriginal;
        }

        private void btn_Editada_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null)
                editorImagen.Image = ImgEditada;
        }

        private void btnErosion_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null || ImgOriginal != null)
            {
                Bitmap ImgAEditar = (Bitmap)editorImagen.Image;
                Bitmap result = Algoritmos.applyErosion(ImgAEditar);

                editorImagen.Image = result;
                ImgEditada = result;
                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
                MessageBox.Show("Se ha Procesado la Imagen", "Imagen Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero es necesario elegir una imagen", "No hay Imagen para Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null || ImgOriginal != null)
            {
                Bitmap ImgAEditar = (Bitmap)editorImagen.Image;
                Bitmap result = Algoritmos.applyFilterMatrix(ImgAEditar, matrizSobel);

                editorImagen.Image = result;
                ImgEditada = result;
                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
                MessageBox.Show("Se ha Procesado la Imagen", "Imagen Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero es necesario elegir una imagen", "No hay Imagen para Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null || ImgOriginal != null)
            {
                Bitmap ImgAEditar = (Bitmap)editorImagen.Image;
                Bitmap result = Algoritmos.applyFilterMatrix(ImgAEditar, matrizPrewitt);

                editorImagen.Image = result;
                ImgEditada = result;
                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
                MessageBox.Show("Se ha Procesado la Imagen", "Imagen Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero es necesario elegir una imagen", "No hay Imagen para Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGlitch_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null || ImgOriginal != null)
            {
                Bitmap ImgAEditar = (Bitmap)editorImagen.Image;
                Bitmap result = Algoritmos.applyFilterMatrixColor(ImgAEditar, matrizScharr, 1);

                editorImagen.Image = result;
                ImgEditada = result;
                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
                MessageBox.Show("Se ha Procesado la Imagen", "Imagen Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero es necesario elegir una imagen", "No hay Imagen para Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            if (ImgEditada != null || ImgOriginal != null)
            {
                Bitmap ImgAEditar = (Bitmap)editorImagen.Image;
                Bitmap result = Algoritmos.applyFilterMatrix(ImgAEditar, matrizEmboss);

                editorImagen.Image = result;
                ImgEditada = result;
                setHistogramas(getHistogramaRed((Bitmap)editorImagen.Image), getHistogramaGreen((Bitmap)editorImagen.Image), getHistogramaBlue((Bitmap)editorImagen.Image));
                MessageBox.Show("Se ha Procesado la Imagen", "Imagen Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Primero es necesario elegir una imagen", "No hay Imagen para Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Boton para el Tab de Video
        private void btnCamaraTab_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editorImagen.Image != null)
            {
                string directory = Environment.CurrentDirectory;
                string path = Directory.GetParent(directory).Parent.Parent.Parent.FullName;
                path = path + "\\Assets\\";

                string NameFile = DateTime.UtcNow.Year.ToString() + DateTime.UtcNow.Month.ToString() + DateTime.UtcNow.Day.ToString() + DateTime.UtcNow.Millisecond.ToString();
                path = path + NameFile + ".jpg";

                Bitmap bm = (Bitmap)editorImagen.Image;
                bm.Save(path, ImageFormat.Jpeg);

                MessageBox.Show("Se ha Guardado la Imagen", "Imagen Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

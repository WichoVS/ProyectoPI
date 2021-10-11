using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace PruebaWFA
{
    public partial class Camara : Form
    {
        FilterInfoCollection miDispositivos;
        VideoCaptureDevice miCamara;

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

        public void CargaDispositivos()
        {
            miDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }
    }
}

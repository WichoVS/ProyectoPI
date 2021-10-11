
namespace PruebaWFA
{
    partial class EdicionImagen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnCamaraTab = new System.Windows.Forms.Button();
            this.btnEditTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.btnEmboss = new System.Windows.Forms.Button();
            this.btnPrewitt = new System.Windows.Forms.Button();
            this.btnGlitch = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnErosion = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramBlue = new AForge.Controls.Histogram();
            this.histogramGreen = new AForge.Controls.Histogram();
            this.histogramaRed = new AForge.Controls.Histogram();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.editorImagen = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.LeftMenu.SuspendLayout();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Header.Controls.Add(this.btnProcesar);
            this.Header.Controls.Add(this.btnManual);
            this.Header.Controls.Add(this.btnCamaraTab);
            this.Header.Controls.Add(this.btnEditTab);
            this.Header.Controls.Add(this.panel2);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1264, 70);
            this.Header.TabIndex = 0;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            this.btnProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcesar.Location = new System.Drawing.Point(1054, 17);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(168, 32);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManual.Location = new System.Drawing.Point(423, 16);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(168, 32);
            this.btnManual.TabIndex = 9;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnManual_MouseDown);
            // 
            // btnCamaraTab
            // 
            this.btnCamaraTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnCamaraTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCamaraTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamaraTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamaraTab.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCamaraTab.Location = new System.Drawing.Point(225, 16);
            this.btnCamaraTab.Name = "btnCamaraTab";
            this.btnCamaraTab.Size = new System.Drawing.Size(168, 32);
            this.btnCamaraTab.TabIndex = 8;
            this.btnCamaraTab.Text = "Camara";
            this.btnCamaraTab.UseVisualStyleBackColor = false;
            this.btnCamaraTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCamaraTab_MouseDown);
            // 
            // btnEditTab
            // 
            this.btnEditTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnEditTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTab.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTab.Location = new System.Drawing.Point(16, 16);
            this.btnEditTab.Name = "btnEditTab";
            this.btnEditTab.Size = new System.Drawing.Size(168, 32);
            this.btnEditTab.TabIndex = 6;
            this.btnEditTab.Text = "Edicion";
            this.btnEditTab.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 610);
            this.panel2.TabIndex = 1;
            // 
            // LeftMenu
            // 
            this.LeftMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.LeftMenu.Controls.Add(this.btnEmboss);
            this.LeftMenu.Controls.Add(this.btnPrewitt);
            this.LeftMenu.Controls.Add(this.btnGlitch);
            this.LeftMenu.Controls.Add(this.btnSobel);
            this.LeftMenu.Controls.Add(this.btnErosion);
            this.LeftMenu.Controls.Add(this.btn_Salir);
            this.LeftMenu.Controls.Add(this.btnAddImage);
            this.LeftMenu.Location = new System.Drawing.Point(0, 64);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(200, 624);
            this.LeftMenu.TabIndex = 2;
            // 
            // btnEmboss
            // 
            this.btnEmboss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnEmboss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmboss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmboss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmboss.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmboss.ForeColor = System.Drawing.Color.Black;
            this.btnEmboss.Location = new System.Drawing.Point(16, 320);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(168, 32);
            this.btnEmboss.TabIndex = 17;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.UseVisualStyleBackColor = false;
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnPrewitt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrewitt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrewitt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrewitt.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrewitt.ForeColor = System.Drawing.Color.Black;
            this.btnPrewitt.Location = new System.Drawing.Point(16, 272);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(168, 32);
            this.btnPrewitt.TabIndex = 16;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = false;
            // 
            // btnGlitch
            // 
            this.btnGlitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnGlitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGlitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlitch.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGlitch.ForeColor = System.Drawing.Color.Black;
            this.btnGlitch.Location = new System.Drawing.Point(16, 224);
            this.btnGlitch.Name = "btnGlitch";
            this.btnGlitch.Size = new System.Drawing.Size(168, 32);
            this.btnGlitch.TabIndex = 15;
            this.btnGlitch.Text = "Glitch";
            this.btnGlitch.UseVisualStyleBackColor = false;
            // 
            // btnSobel
            // 
            this.btnSobel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnSobel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSobel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobel.ForeColor = System.Drawing.Color.Black;
            this.btnSobel.Location = new System.Drawing.Point(16, 176);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(168, 32);
            this.btnSobel.TabIndex = 14;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = false;
            // 
            // btnErosion
            // 
            this.btnErosion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnErosion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnErosion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErosion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErosion.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnErosion.ForeColor = System.Drawing.Color.Black;
            this.btnErosion.Location = new System.Drawing.Point(16, 128);
            this.btnErosion.Name = "btnErosion";
            this.btnErosion.Size = new System.Drawing.Size(168, 32);
            this.btnErosion.TabIndex = 13;
            this.btnErosion.Text = "Erosion";
            this.btnErosion.UseVisualStyleBackColor = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(16, 560);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(168, 32);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Salir_MouseDown);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddImage.Location = new System.Drawing.Point(16, 56);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(168, 32);
            this.btnAddImage.TabIndex = 3;
            this.btnAddImage.Text = "Agregar Imagen";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddImage_MouseDown);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.Screen.Controls.Add(this.label1);
            this.Screen.Controls.Add(this.label3);
            this.Screen.Controls.Add(this.label2);
            this.Screen.Controls.Add(this.histogramBlue);
            this.Screen.Controls.Add(this.histogramGreen);
            this.Screen.Controls.Add(this.histogramaRed);
            this.Screen.Controls.Add(this.btnGuardar);
            this.Screen.Controls.Add(this.btnOriginal);
            this.Screen.Controls.Add(this.editorImagen);
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1264, 688);
            this.Screen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1048, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1040, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1032, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // histogramBlue
            // 
            this.histogramBlue.Location = new System.Drawing.Point(920, 456);
            this.histogramBlue.Name = "histogramBlue";
            this.histogramBlue.Size = new System.Drawing.Size(312, 136);
            this.histogramBlue.TabIndex = 9;
            this.histogramBlue.Text = "histogram2";
            this.histogramBlue.Values = null;
            // 
            // histogramGreen
            // 
            this.histogramGreen.Location = new System.Drawing.Point(920, 272);
            this.histogramGreen.Name = "histogramGreen";
            this.histogramGreen.Size = new System.Drawing.Size(312, 136);
            this.histogramGreen.TabIndex = 8;
            this.histogramGreen.Text = "histogram1";
            this.histogramGreen.Values = null;
            // 
            // histogramaRed
            // 
            this.histogramaRed.Location = new System.Drawing.Point(920, 96);
            this.histogramaRed.Name = "histogramaRed";
            this.histogramaRed.Size = new System.Drawing.Size(312, 136);
            this.histogramaRed.TabIndex = 7;
            this.histogramaRed.Text = "histogram1";
            this.histogramaRed.Values = null;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(712, 624);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 32);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOriginal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOriginal.Location = new System.Drawing.Point(248, 624);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(168, 32);
            this.btnOriginal.TabIndex = 4;
            this.btnOriginal.Text = "Imagen Original";
            this.btnOriginal.UseVisualStyleBackColor = false;
            // 
            // editorImagen
            // 
            this.editorImagen.BackColor = System.Drawing.Color.Black;
            this.editorImagen.Location = new System.Drawing.Point(256, 96);
            this.editorImagen.Name = "editorImagen";
            this.editorImagen.Size = new System.Drawing.Size(630, 500);
            this.editorImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editorImagen.TabIndex = 0;
            this.editorImagen.TabStop = false;
            // 
            // EdicionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdicionImagen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.LeftMenu.ResumeLayout(false);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox editorImagen;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnCamaraTab;
        private System.Windows.Forms.Button btnEditTab;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Button btnOriginal;
        private AForge.Controls.Histogram histogramaRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AForge.Controls.Histogram histogramBlue;
        private AForge.Controls.Histogram histogramGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmboss;
        private System.Windows.Forms.Button btnPrewitt;
        private System.Windows.Forms.Button btnGlitch;
        private System.Windows.Forms.Button btnSobel;
        private System.Windows.Forms.Button btnErosion;
    }
}



namespace PruebaWFA
{
    partial class Camara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnCamaraTab = new System.Windows.Forms.Button();
            this.btnEditTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.btnOriginalVideo = new System.Windows.Forms.Button();
            this.btnEmbossVideo = new System.Windows.Forms.Button();
            this.btnPrewittVideo = new System.Windows.Forms.Button();
            this.btnGlitchVideo = new System.Windows.Forms.Button();
            this.btnSobelVideo = new System.Windows.Forms.Button();
            this.btnErosionVideo = new System.Windows.Forms.Button();
            this.btnCargarVideo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramBlueV = new AForge.Controls.Histogram();
            this.histogramGreenV = new AForge.Controls.Histogram();
            this.histogramaRedV = new AForge.Controls.Histogram();
            this.btnReiniciarVideo = new System.Windows.Forms.Button();
            this.btnGuardarVideo = new System.Windows.Forms.Button();
            this.VideoPlayer = new System.Windows.Forms.PictureBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.LeftMenu.SuspendLayout();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Header.Controls.Add(this.btnManual);
            this.Header.Controls.Add(this.btnCamaraTab);
            this.Header.Controls.Add(this.btnEditTab);
            this.Header.Controls.Add(this.panel2);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1280, 70);
            this.Header.TabIndex = 4;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
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
            this.btnEditTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEditTab_MouseDown);
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
            this.LeftMenu.Controls.Add(this.btnOriginalVideo);
            this.LeftMenu.Controls.Add(this.btnEmbossVideo);
            this.LeftMenu.Controls.Add(this.btnPrewittVideo);
            this.LeftMenu.Controls.Add(this.btnGlitchVideo);
            this.LeftMenu.Controls.Add(this.btnSobelVideo);
            this.LeftMenu.Controls.Add(this.btnErosionVideo);
            this.LeftMenu.Controls.Add(this.btnCargarVideo);
            this.LeftMenu.Controls.Add(this.btnSalir);
            this.LeftMenu.Location = new System.Drawing.Point(0, 56);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(208, 664);
            this.LeftMenu.TabIndex = 5;
            // 
            // btnOriginalVideo
            // 
            this.btnOriginalVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnOriginalVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOriginalVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOriginalVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOriginalVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOriginalVideo.Location = new System.Drawing.Point(16, 392);
            this.btnOriginalVideo.Name = "btnOriginalVideo";
            this.btnOriginalVideo.Size = new System.Drawing.Size(168, 32);
            this.btnOriginalVideo.TabIndex = 14;
            this.btnOriginalVideo.Text = "Original";
            this.btnOriginalVideo.UseVisualStyleBackColor = false;
            this.btnOriginalVideo.Click += new System.EventHandler(this.btnOriginalVideo_Click);
            // 
            // btnEmbossVideo
            // 
            this.btnEmbossVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnEmbossVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmbossVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmbossVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmbossVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmbossVideo.Location = new System.Drawing.Point(16, 344);
            this.btnEmbossVideo.Name = "btnEmbossVideo";
            this.btnEmbossVideo.Size = new System.Drawing.Size(168, 32);
            this.btnEmbossVideo.TabIndex = 13;
            this.btnEmbossVideo.Text = "Emboss";
            this.btnEmbossVideo.UseVisualStyleBackColor = false;
            this.btnEmbossVideo.Click += new System.EventHandler(this.btnEmbossVideo_Click);
            // 
            // btnPrewittVideo
            // 
            this.btnPrewittVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnPrewittVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrewittVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrewittVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrewittVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrewittVideo.Location = new System.Drawing.Point(16, 296);
            this.btnPrewittVideo.Name = "btnPrewittVideo";
            this.btnPrewittVideo.Size = new System.Drawing.Size(168, 32);
            this.btnPrewittVideo.TabIndex = 12;
            this.btnPrewittVideo.Text = "Prewitt";
            this.btnPrewittVideo.UseVisualStyleBackColor = false;
            this.btnPrewittVideo.Click += new System.EventHandler(this.btnPrewittVideo_Click);
            // 
            // btnGlitchVideo
            // 
            this.btnGlitchVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnGlitchVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGlitchVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGlitchVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlitchVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGlitchVideo.Location = new System.Drawing.Point(16, 248);
            this.btnGlitchVideo.Name = "btnGlitchVideo";
            this.btnGlitchVideo.Size = new System.Drawing.Size(168, 32);
            this.btnGlitchVideo.TabIndex = 11;
            this.btnGlitchVideo.Text = "Negativo";
            this.btnGlitchVideo.UseVisualStyleBackColor = false;
            this.btnGlitchVideo.Click += new System.EventHandler(this.btnGlitchVideo_Click);
            // 
            // btnSobelVideo
            // 
            this.btnSobelVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnSobelVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSobelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobelVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobelVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSobelVideo.Location = new System.Drawing.Point(16, 200);
            this.btnSobelVideo.Name = "btnSobelVideo";
            this.btnSobelVideo.Size = new System.Drawing.Size(168, 32);
            this.btnSobelVideo.TabIndex = 10;
            this.btnSobelVideo.Text = "Sepia";
            this.btnSobelVideo.UseVisualStyleBackColor = false;
            this.btnSobelVideo.Click += new System.EventHandler(this.btnSobelVideo_Click);
            // 
            // btnErosionVideo
            // 
            this.btnErosionVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnErosionVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnErosionVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErosionVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErosionVideo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnErosionVideo.Location = new System.Drawing.Point(16, 152);
            this.btnErosionVideo.Name = "btnErosionVideo";
            this.btnErosionVideo.Size = new System.Drawing.Size(168, 32);
            this.btnErosionVideo.TabIndex = 9;
            this.btnErosionVideo.Text = "Escala de Grises";
            this.btnErosionVideo.UseVisualStyleBackColor = false;
            this.btnErosionVideo.Click += new System.EventHandler(this.btnErosionVideo_Click);
            // 
            // btnCargarVideo
            // 
            this.btnCargarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnCargarVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVideo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarVideo.Location = new System.Drawing.Point(16, 88);
            this.btnCargarVideo.Name = "btnCargarVideo";
            this.btnCargarVideo.Size = new System.Drawing.Size(168, 32);
            this.btnCargarVideo.TabIndex = 8;
            this.btnCargarVideo.Text = "Cargar Video";
            this.btnCargarVideo.UseVisualStyleBackColor = false;
            this.btnCargarVideo.Click += new System.EventHandler(this.btnCargarVideo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(16, 592);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.Screen.Controls.Add(this.label1);
            this.Screen.Controls.Add(this.label3);
            this.Screen.Controls.Add(this.label2);
            this.Screen.Controls.Add(this.histogramBlueV);
            this.Screen.Controls.Add(this.histogramGreenV);
            this.Screen.Controls.Add(this.histogramaRedV);
            this.Screen.Controls.Add(this.btnReiniciarVideo);
            this.Screen.Controls.Add(this.btnGuardarVideo);
            this.Screen.Controls.Add(this.VideoPlayer);
            this.Screen.Controls.Add(this.btnPausar);
            this.Screen.Controls.Add(this.btnReproducir);
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1280, 720);
            this.Screen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1080, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1072, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1064, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Green";
            // 
            // histogramBlueV
            // 
            this.histogramBlueV.Location = new System.Drawing.Point(952, 472);
            this.histogramBlueV.Name = "histogramBlueV";
            this.histogramBlueV.Size = new System.Drawing.Size(312, 136);
            this.histogramBlueV.TabIndex = 15;
            this.histogramBlueV.Text = "histogram2";
            this.histogramBlueV.Values = null;
            // 
            // histogramGreenV
            // 
            this.histogramGreenV.Location = new System.Drawing.Point(952, 288);
            this.histogramGreenV.Name = "histogramGreenV";
            this.histogramGreenV.Size = new System.Drawing.Size(312, 136);
            this.histogramGreenV.TabIndex = 14;
            this.histogramGreenV.Text = "histogram1";
            this.histogramGreenV.Values = null;
            // 
            // histogramaRedV
            // 
            this.histogramaRedV.Location = new System.Drawing.Point(952, 112);
            this.histogramaRedV.Name = "histogramaRedV";
            this.histogramaRedV.Size = new System.Drawing.Size(312, 136);
            this.histogramaRedV.TabIndex = 13;
            this.histogramaRedV.Text = "histogram1";
            this.histogramaRedV.Values = null;
            // 
            // btnReiniciarVideo
            // 
            this.btnReiniciarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnReiniciarVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReiniciarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarVideo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReiniciarVideo.Location = new System.Drawing.Point(576, 648);
            this.btnReiniciarVideo.Name = "btnReiniciarVideo";
            this.btnReiniciarVideo.Size = new System.Drawing.Size(168, 32);
            this.btnReiniciarVideo.TabIndex = 10;
            this.btnReiniciarVideo.Text = "Reiniciar";
            this.btnReiniciarVideo.UseVisualStyleBackColor = false;
            this.btnReiniciarVideo.Click += new System.EventHandler(this.btnReiniciarVideo_Click);
            // 
            // btnGuardarVideo
            // 
            this.btnGuardarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnGuardarVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVideo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarVideo.Location = new System.Drawing.Point(776, 648);
            this.btnGuardarVideo.Name = "btnGuardarVideo";
            this.btnGuardarVideo.Size = new System.Drawing.Size(168, 32);
            this.btnGuardarVideo.TabIndex = 9;
            this.btnGuardarVideo.Text = "Guardar";
            this.btnGuardarVideo.UseVisualStyleBackColor = false;
            this.btnGuardarVideo.Click += new System.EventHandler(this.btnGuardarVideo_Click);
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.BackColor = System.Drawing.Color.Black;
            this.VideoPlayer.Location = new System.Drawing.Point(224, 112);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.Size = new System.Drawing.Size(720, 464);
            this.VideoPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VideoPlayer.TabIndex = 8;
            this.VideoPlayer.TabStop = false;
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPausar.Location = new System.Drawing.Point(400, 648);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(168, 32);
            this.btnPausar.TabIndex = 7;
            this.btnPausar.Text = "Pausa";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnReproducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReproducir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproducir.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReproducir.Location = new System.Drawing.Point(224, 648);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(168, 32);
            this.btnReproducir.TabIndex = 6;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Camara";
            this.Text = "Camara";
            this.Header.ResumeLayout(false);
            this.LeftMenu.ResumeLayout(false);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnCamaraTab;
        private System.Windows.Forms.Button btnEditTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnCargarVideo;
        private System.Windows.Forms.PictureBox VideoPlayer;
        private System.Windows.Forms.Button btnErosionVideo;
        private System.Windows.Forms.Button btnSobelVideo;
        private System.Windows.Forms.Button btnGlitchVideo;
        private System.Windows.Forms.Button btnPrewittVideo;
        private System.Windows.Forms.Button btnEmbossVideo;
        private System.Windows.Forms.Button btnGuardarVideo;
        private System.Windows.Forms.Button btnOriginalVideo;
        private System.Windows.Forms.Button btnReiniciarVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AForge.Controls.Histogram histogramBlueV;
        private AForge.Controls.Histogram histogramGreenV;
        private AForge.Controls.Histogram histogramaRedV;
    }
}
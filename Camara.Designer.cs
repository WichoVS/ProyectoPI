
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnCamaraTab = new System.Windows.Forms.Button();
            this.btnEditTab = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Panel();
            this.btnActivarCam = new System.Windows.Forms.Button();
            this.btnDesactivarCam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.LeftMenu.SuspendLayout();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Header.Size = new System.Drawing.Size(1280, 70);
            this.Header.TabIndex = 4;
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
            this.LeftMenu.Controls.Add(this.btnSalir);
            this.LeftMenu.Location = new System.Drawing.Point(0, 56);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(208, 664);
            this.LeftMenu.TabIndex = 5;
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
            this.btnSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.Screen.Controls.Add(this.btnActivarCam);
            this.Screen.Controls.Add(this.btnDesactivarCam);
            this.Screen.Controls.Add(this.pictureBox1);
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1280, 720);
            this.Screen.TabIndex = 6;
            // 
            // btnActivarCam
            // 
            this.btnActivarCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnActivarCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActivarCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivarCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarCam.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActivarCam.Location = new System.Drawing.Point(824, 648);
            this.btnActivarCam.Name = "btnActivarCam";
            this.btnActivarCam.Size = new System.Drawing.Size(168, 32);
            this.btnActivarCam.TabIndex = 7;
            this.btnActivarCam.Text = "Activar";
            this.btnActivarCam.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarCam
            // 
            this.btnDesactivarCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(172)))), ((int)(((byte)(255)))));
            this.btnDesactivarCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDesactivarCam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarCam.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesactivarCam.Location = new System.Drawing.Point(368, 648);
            this.btnDesactivarCam.Name = "btnDesactivarCam";
            this.btnDesactivarCam.Size = new System.Drawing.Size(168, 32);
            this.btnDesactivarCam.TabIndex = 6;
            this.btnDesactivarCam.Text = "Desactivar";
            this.btnDesactivarCam.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(368, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActivarCam;
        private System.Windows.Forms.Button btnDesactivarCam;
    }
}
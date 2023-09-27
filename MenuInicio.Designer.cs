
namespace Proyecto_Año
{
    partial class MenuInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFlechaI = new System.Windows.Forms.Button();
            this.btnFlechaD = new System.Windows.Forms.Button();
            this.TituloPrincipal = new System.Windows.Forms.Label();
            this.ImagenFondo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.labelRegistrate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRegistrate);
            this.panel1.Controls.Add(this.labelIniciarSesion);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 631);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(844, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 631);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFlechaI);
            this.panel3.Controls.Add(this.btnFlechaD);
            this.panel3.Controls.Add(this.TituloPrincipal);
            this.panel3.Controls.Add(this.ImagenFondo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(332, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 631);
            this.panel3.TabIndex = 2;
            // 
            // btnFlechaI
            // 
            this.btnFlechaI.Location = new System.Drawing.Point(7, 303);
            this.btnFlechaI.Name = "btnFlechaI";
            this.btnFlechaI.Size = new System.Drawing.Size(75, 23);
            this.btnFlechaI.TabIndex = 3;
            this.btnFlechaI.Text = "<";
            this.btnFlechaI.UseVisualStyleBackColor = true;
            this.btnFlechaI.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFlechaD
            // 
            this.btnFlechaD.Location = new System.Drawing.Point(431, 303);
            this.btnFlechaD.Name = "btnFlechaD";
            this.btnFlechaD.Size = new System.Drawing.Size(75, 23);
            this.btnFlechaD.TabIndex = 2;
            this.btnFlechaD.Text = ">";
            this.btnFlechaD.UseVisualStyleBackColor = true;
            this.btnFlechaD.Click += new System.EventHandler(this.button1_Click);
            // 
            // TituloPrincipal
            // 
            this.TituloPrincipal.AutoSize = true;
            this.TituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.TituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TituloPrincipal.Location = new System.Drawing.Point(20, 65);
            this.TituloPrincipal.Name = "TituloPrincipal";
            this.TituloPrincipal.Size = new System.Drawing.Size(466, 42);
            this.TituloPrincipal.TabIndex = 1;
            this.TituloPrincipal.Text = "Bienvenido a Quick Carry";
            // 
            // ImagenFondo
            // 
            this.ImagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagenFondo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenFondo.Image")));
            this.ImagenFondo.Location = new System.Drawing.Point(0, 0);
            this.ImagenFondo.Name = "ImagenFondo";
            this.ImagenFondo.Size = new System.Drawing.Size(512, 631);
            this.ImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFondo.TabIndex = 0;
            this.ImagenFondo.TabStop = false;
            this.ImagenFondo.Click += new System.EventHandler(this.ImagenFondo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(118, 91);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(86, 29);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Ir";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(118, 236);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(97, 34);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrate";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.Location = new System.Drawing.Point(104, 65);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(123, 23);
            this.labelIniciarSesion.TabIndex = 3;
            this.labelIniciarSesion.Text = "Iniciar Sesion";
            // 
            // labelRegistrate
            // 
            this.labelRegistrate.AutoSize = true;
            this.labelRegistrate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrate.Location = new System.Drawing.Point(61, 199);
            this.labelRegistrate.Name = "labelRegistrate";
            this.labelRegistrate.Size = new System.Drawing.Size(224, 23);
            this.labelRegistrate.TabIndex = 4;
            this.labelRegistrate.Text = "¿Aun no estas registrado?";
            this.labelRegistrate.Click += new System.EventHandler(this.labelRegistrate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFlechaI;
        private System.Windows.Forms.Button btnFlechaD;
        private System.Windows.Forms.Label TituloPrincipal;
        private System.Windows.Forms.PictureBox ImagenFondo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label labelRegistrate;
    }
}


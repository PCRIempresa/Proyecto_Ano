
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
            this.btn_Buscar_Paquete = new System.Windows.Forms.Button();
            this.TituloPrincipal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ImagenFondo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Funcionarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Funcionarios);
            this.panel1.Controls.Add(this.btn_Buscar_Paquete);
            this.panel1.Controls.Add(this.TituloPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 631);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Buscar_Paquete
            // 
            this.btn_Buscar_Paquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar_Paquete.Location = new System.Drawing.Point(64, 273);
            this.btn_Buscar_Paquete.Name = "btn_Buscar_Paquete";
            this.btn_Buscar_Paquete.Size = new System.Drawing.Size(330, 47);
            this.btn_Buscar_Paquete.TabIndex = 5;
            this.btn_Buscar_Paquete.Text = "¿Buscas un Paquete?";
            this.btn_Buscar_Paquete.UseVisualStyleBackColor = true;
            this.btn_Buscar_Paquete.Click += new System.EventHandler(this.btn_Buscar_Paquete_Click);
            // 
            // TituloPrincipal
            // 
            this.TituloPrincipal.AutoSize = true;
            this.TituloPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.TituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TituloPrincipal.Location = new System.Drawing.Point(5, 36);
            this.TituloPrincipal.Name = "TituloPrincipal";
            this.TituloPrincipal.Size = new System.Drawing.Size(466, 126);
            this.TituloPrincipal.TabIndex = 1;
            this.TituloPrincipal.Text = "Bienvenido a Quick Carry\r\nEl Mejor Servicio de \r\nEnvios del Uruguay";
            this.TituloPrincipal.Click += new System.EventHandler(this.TituloPrincipal_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ImagenFondo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(481, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 631);
            this.panel3.TabIndex = 2;
            // 
            // ImagenFondo
            // 
            this.ImagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagenFondo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenFondo.Image")));
            this.ImagenFondo.Location = new System.Drawing.Point(0, 0);
            this.ImagenFondo.Name = "ImagenFondo";
            this.ImagenFondo.Size = new System.Drawing.Size(504, 631);
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
            // btn_Funcionarios
            // 
            this.btn_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Funcionarios.Location = new System.Drawing.Point(47, 388);
            this.btn_Funcionarios.Name = "btn_Funcionarios";
            this.btn_Funcionarios.Size = new System.Drawing.Size(357, 33);
            this.btn_Funcionarios.TabIndex = 6;
            this.btn_Funcionarios.Text = "¿Eres Funcionario de la Empresa?";
            this.btn_Funcionarios.UseVisualStyleBackColor = true;
            this.btn_Funcionarios.Click += new System.EventHandler(this.btn_Funcionarios_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 631);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MenuInicio";
            this.Text = "Biembenido a Quick Carry";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MenuInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TituloPrincipal;
        private System.Windows.Forms.PictureBox ImagenFondo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Buscar_Paquete;
        private System.Windows.Forms.Button btn_Funcionarios;
    }
}



namespace Proyecto_Año
{
    partial class Menu_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Funcionarios));
            this.label_CI = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.necesitasAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoIngresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoRegistrarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CI
            // 
            this.label_CI.AutoSize = true;
            this.label_CI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CI.Location = new System.Drawing.Point(12, 58);
            this.label_CI.Name = "label_CI";
            this.label_CI.Size = new System.Drawing.Size(154, 29);
            this.label_CI.TabIndex = 0;
            this.label_CI.Text = "Ingrese su CI";
            this.label_CI.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.Location = new System.Drawing.Point(12, 126);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(223, 29);
            this.label_Contraseña.TabIndex = 1;
            this.label_Contraseña.Text = "Ingrese Contraseña";
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCI.Location = new System.Drawing.Point(284, 55);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(297, 35);
            this.txtCI.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(284, 123);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(297, 35);
            this.txtContraseña.TabIndex = 3;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(373, 182);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(107, 38);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(17, 303);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(275, 35);
            this.btn_Registrar.TabIndex = 5;
            this.btn_Registrar.Text = "Registrarse";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.necesitasAyudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // necesitasAyudaToolStripMenuItem
            // 
            this.necesitasAyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoIngresarToolStripMenuItem,
            this.comoRegistrarteToolStripMenuItem});
            this.necesitasAyudaToolStripMenuItem.Name = "necesitasAyudaToolStripMenuItem";
            this.necesitasAyudaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.necesitasAyudaToolStripMenuItem.Text = "¿Necesitas ayuda?";
            // 
            // comoIngresarToolStripMenuItem
            // 
            this.comoIngresarToolStripMenuItem.Name = "comoIngresarToolStripMenuItem";
            this.comoIngresarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.comoIngresarToolStripMenuItem.Text = "Como Ingresar";
            this.comoIngresarToolStripMenuItem.Click += new System.EventHandler(this.comoIngresarToolStripMenuItem_Click);
            // 
            // comoRegistrarteToolStripMenuItem
            // 
            this.comoRegistrarteToolStripMenuItem.Name = "comoRegistrarteToolStripMenuItem";
            this.comoRegistrarteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.comoRegistrarteToolStripMenuItem.Text = "Como Registrarte";
            this.comoRegistrarteToolStripMenuItem.Click += new System.EventHandler(this.comoRegistrarteToolStripMenuItem_Click);
            // 
            // Menu_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 454);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_CI);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Funcionarios";
            this.Text = "Iniciar_Secion";
            this.Load += new System.EventHandler(this.Iniciar_Secion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CI;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem necesitasAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoIngresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoRegistrarteToolStripMenuItem;
    }
}
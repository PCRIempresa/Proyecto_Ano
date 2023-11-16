
namespace Proyecto_Año
{
    partial class Menu_Conductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Conductores));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.necesitasAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxConductores = new System.Windows.Forms.ListBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.labelCI = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelInformacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.necesitasAyudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // necesitasAyudaToolStripMenuItem
            // 
            this.necesitasAyudaToolStripMenuItem.Name = "necesitasAyudaToolStripMenuItem";
            this.necesitasAyudaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.necesitasAyudaToolStripMenuItem.Text = "¿Necesitas ayuda?";
            this.necesitasAyudaToolStripMenuItem.Click += new System.EventHandler(this.necesitasAyudaToolStripMenuItem_Click);
            // 
            // listBoxConductores
            // 
            this.listBoxConductores.FormattingEnabled = true;
            this.listBoxConductores.Location = new System.Drawing.Point(159, 127);
            this.listBoxConductores.Name = "listBoxConductores";
            this.listBoxConductores.Size = new System.Drawing.Size(688, 485);
            this.listBoxConductores.TabIndex = 43;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(71, 98);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(220, 20);
            this.txtCI.TabIndex = 40;
            // 
            // labelCI
            // 
            this.labelCI.AutoSize = true;
            this.labelCI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCI.Location = new System.Drawing.Point(79, 76);
            this.labelCI.Name = "labelCI";
            this.labelCI.Size = new System.Drawing.Size(91, 19);
            this.labelCI.TabIndex = 33;
            this.labelCI.Text = "Ingresa tu CI:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(446, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 27);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // labelInformacion
            // 
            this.labelInformacion.AutoSize = true;
            this.labelInformacion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacion.Location = new System.Drawing.Point(397, 24);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(186, 24);
            this.labelInformacion.TabIndex = 27;
            this.labelInformacion.Text = "Informacion del Dia";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(913, 87);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 36);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Menu_Conductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 624);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listBoxConductores);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.labelCI);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelInformacion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Conductores";
            this.Text = "Menu_Conductores";
            this.Load += new System.EventHandler(this.Menu_Conductores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem necesitasAyudaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxConductores;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label labelCI;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelInformacion;
        private System.Windows.Forms.Button btnVolver;
    }
}
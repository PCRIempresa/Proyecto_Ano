
namespace Proyecto_Año
{
    partial class Menu_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Clientes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.necesitasAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSabesComoSeguirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiaDeLaVentanaActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laVentanaNoRespondeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarAlSoporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_IngresarDatos = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.necesitasAyudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // necesitasAyudaToolStripMenuItem
            // 
            this.necesitasAyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noSabesComoSeguirToolStripMenuItem,
            this.laVentanaNoRespondeToolStripMenuItem});
            this.necesitasAyudaToolStripMenuItem.Name = "necesitasAyudaToolStripMenuItem";
            this.necesitasAyudaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.necesitasAyudaToolStripMenuItem.Text = "¿Necesitas ayuda?";
            this.necesitasAyudaToolStripMenuItem.Click += new System.EventHandler(this.necesitasAyudaToolStripMenuItem_Click);
            // 
            // noSabesComoSeguirToolStripMenuItem
            // 
            this.noSabesComoSeguirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiaDeLaVentanaActualToolStripMenuItem});
            this.noSabesComoSeguirToolStripMenuItem.Name = "noSabesComoSeguirToolStripMenuItem";
            this.noSabesComoSeguirToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.noSabesComoSeguirToolStripMenuItem.Text = "¿No sabes como seguir?";
            // 
            // guiaDeLaVentanaActualToolStripMenuItem
            // 
            this.guiaDeLaVentanaActualToolStripMenuItem.Name = "guiaDeLaVentanaActualToolStripMenuItem";
            this.guiaDeLaVentanaActualToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.guiaDeLaVentanaActualToolStripMenuItem.Text = "Guia de la ventana actual";
            this.guiaDeLaVentanaActualToolStripMenuItem.Click += new System.EventHandler(this.guiaDeLaVentanaActualToolStripMenuItem_Click);
            // 
            // laVentanaNoRespondeToolStripMenuItem
            // 
            this.laVentanaNoRespondeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactarAlSoporteTecnicoToolStripMenuItem});
            this.laVentanaNoRespondeToolStripMenuItem.Name = "laVentanaNoRespondeToolStripMenuItem";
            this.laVentanaNoRespondeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.laVentanaNoRespondeToolStripMenuItem.Text = "¿La ventana no responde?";
            // 
            // contactarAlSoporteTecnicoToolStripMenuItem
            // 
            this.contactarAlSoporteTecnicoToolStripMenuItem.Name = "contactarAlSoporteTecnicoToolStripMenuItem";
            this.contactarAlSoporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.contactarAlSoporteTecnicoToolStripMenuItem.Text = "Contactar al Soporte Tecnico";
            this.contactarAlSoporteTecnicoToolStripMenuItem.Click += new System.EventHandler(this.contactarAlSoporteTecnicoToolStripMenuItem_Click);
            // 
            // label_IngresarDatos
            // 
            this.label_IngresarDatos.AutoSize = true;
            this.label_IngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IngresarDatos.Location = new System.Drawing.Point(58, 38);
            this.label_IngresarDatos.Name = "label_IngresarDatos";
            this.label_IngresarDatos.Size = new System.Drawing.Size(379, 25);
            this.label_IngresarDatos.TabIndex = 3;
            this.label_IngresarDatos.Text = "Por favor ingrese los siguientes datos:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(85, 107);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(324, 50);
            this.label_ID.TabIndex = 5;
            this.label_ID.Text = "Numero del paquete, que recibio\r\ncuando realizo la compra:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 180);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(502, 31);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(109, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_IngresarDatos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Clientes";
            this.Text = "Menu Clientes";
            this.Load += new System.EventHandler(this.Menu_Clientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem necesitasAyudaToolStripMenuItem;
        private System.Windows.Forms.Label label_IngresarDatos;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem noSabesComoSeguirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guiaDeLaVentanaActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laVentanaNoRespondeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarAlSoporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
namespace PulsacionesGUI
{
    partial class principalGui
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pulsacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pulsacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pulsacionesToolStripMenuItem
            // 
            this.pulsacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPersonaToolStripMenuItem,
            this.consultarPersonaToolStripMenuItem});
            this.pulsacionesToolStripMenuItem.Name = "pulsacionesToolStripMenuItem";
            this.pulsacionesToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.pulsacionesToolStripMenuItem.Text = "Menu De Pulsaciones";
            // 
            // registrarPersonaToolStripMenuItem
            // 
            this.registrarPersonaToolStripMenuItem.Name = "registrarPersonaToolStripMenuItem";
            this.registrarPersonaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.registrarPersonaToolStripMenuItem.Text = "Registrar Persona";
            this.registrarPersonaToolStripMenuItem.Click += new System.EventHandler(this.registrarPersonaToolStripMenuItem_Click);
            // 
            // consultarPersonaToolStripMenuItem
            // 
            this.consultarPersonaToolStripMenuItem.Name = "consultarPersonaToolStripMenuItem";
            this.consultarPersonaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultarPersonaToolStripMenuItem.Text = "Consultar persona";
            this.consultarPersonaToolStripMenuItem.Click += new System.EventHandler(this.consultarPersonaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(637, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 454);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // principalGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principalGui";
            this.Text = "Pulsaciones Sofware";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pulsacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPersonaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}


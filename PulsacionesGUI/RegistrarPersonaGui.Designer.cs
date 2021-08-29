namespace PulsacionesGUI
{
    partial class RegistrarPersonaGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPersonaGui));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RegistrarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.EdadTxt = new System.Windows.Forms.TextBox();
            this.PulsacionTxt = new System.Windows.Forms.TextBox();
            this.SexoCmb = new System.Windows.Forms.ComboBox();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pulsacion";
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarBtn.Image")));
            this.RegistrarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegistrarBtn.Location = new System.Drawing.Point(42, 284);
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.Size = new System.Drawing.Size(75, 53);
            this.RegistrarBtn.TabIndex = 5;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            this.RegistrarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBtn.Image")));
            this.BuscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarBtn.Location = new System.Drawing.Point(144, 284);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 53);
            this.BuscarBtn.TabIndex = 6;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBtn.Image")));
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBtn.Location = new System.Drawing.Point(243, 284);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 53);
            this.EliminarBtn.TabIndex = 7;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(89, 43);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(100, 20);
            this.IdentificacionTxt.TabIndex = 8;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(89, 77);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 9;
            // 
            // EdadTxt
            // 
            this.EdadTxt.Location = new System.Drawing.Point(89, 112);
            this.EdadTxt.Name = "EdadTxt";
            this.EdadTxt.Size = new System.Drawing.Size(100, 20);
            this.EdadTxt.TabIndex = 10;
            // 
            // PulsacionTxt
            // 
            this.PulsacionTxt.Location = new System.Drawing.Point(89, 186);
            this.PulsacionTxt.Name = "PulsacionTxt";
            this.PulsacionTxt.ReadOnly = true;
            this.PulsacionTxt.Size = new System.Drawing.Size(100, 20);
            this.PulsacionTxt.TabIndex = 11;
            // 
            // SexoCmb
            // 
            this.SexoCmb.FormattingEnabled = true;
            this.SexoCmb.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexoCmb.Location = new System.Drawing.Point(89, 149);
            this.SexoCmb.Name = "SexoCmb";
            this.SexoCmb.Size = new System.Drawing.Size(121, 21);
            this.SexoCmb.TabIndex = 12;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditarBtn.Image")));
            this.EditarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditarBtn.Location = new System.Drawing.Point(343, 284);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(75, 53);
            this.EditarBtn.TabIndex = 13;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarBtn.UseVisualStyleBackColor = true;
            this.EditarBtn.Click += new System.EventHandler(this.EditarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Image = ((System.Drawing.Image)(resources.GetObject("limpiarBtn.Image")));
            this.limpiarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.limpiarBtn.Location = new System.Drawing.Point(435, 284);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 53);
            this.limpiarBtn.TabIndex = 14;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 174);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(528, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 370);
            this.panel1.TabIndex = 16;
            // 
            // RegistrarPersonaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.SexoCmb);
            this.Controls.Add(this.PulsacionTxt);
            this.Controls.Add(this.EdadTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.RegistrarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarPersonaGui";
            this.Text = "Registro De Personas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegistrarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox EdadTxt;
        private System.Windows.Forms.TextBox PulsacionTxt;
        private System.Windows.Forms.ComboBox SexoCmb;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
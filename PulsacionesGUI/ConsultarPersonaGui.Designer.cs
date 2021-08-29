namespace PulsacionesGUI
{
    partial class ConsultarPersonaGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPersonaGui));
            this.TipoConsultaCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Totalinscritostxt = new System.Windows.Forms.TextBox();
            this.TotalMujerestxt = new System.Windows.Forms.TextBox();
            this.TotalHombrestxt = new System.Windows.Forms.TextBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdentificacionDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PulsacionesDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoConsultaCmb
            // 
            this.TipoConsultaCmb.FormattingEnabled = true;
            this.TipoConsultaCmb.Items.AddRange(new object[] {
            "Todos",
            "Masculino",
            "Femenino"});
            this.TipoConsultaCmb.Location = new System.Drawing.Point(171, 31);
            this.TipoConsultaCmb.Name = "TipoConsultaCmb";
            this.TipoConsultaCmb.Size = new System.Drawing.Size(125, 21);
            this.TipoConsultaCmb.TabIndex = 2;
            this.TipoConsultaCmb.SelectedIndexChanged += new System.EventHandler(this.TipoConsultaCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Inscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Mujeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Hombres";
            // 
            // Totalinscritostxt
            // 
            this.Totalinscritostxt.Location = new System.Drawing.Point(154, 332);
            this.Totalinscritostxt.Name = "Totalinscritostxt";
            this.Totalinscritostxt.Size = new System.Drawing.Size(100, 20);
            this.Totalinscritostxt.TabIndex = 6;
            // 
            // TotalMujerestxt
            // 
            this.TotalMujerestxt.Location = new System.Drawing.Point(303, 332);
            this.TotalMujerestxt.Name = "TotalMujerestxt";
            this.TotalMujerestxt.Size = new System.Drawing.Size(100, 20);
            this.TotalMujerestxt.TabIndex = 7;
            // 
            // TotalHombrestxt
            // 
            this.TotalHombrestxt.Location = new System.Drawing.Point(455, 332);
            this.TotalHombrestxt.Name = "TotalHombrestxt";
            this.TotalHombrestxt.Size = new System.Drawing.Size(100, 20);
            this.TotalHombrestxt.TabIndex = 8;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsulta.Image")));
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsulta.Location = new System.Drawing.Point(455, 12);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(94, 53);
            this.BtnConsulta.TabIndex = 10;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdentificacionDgv,
            this.NombreDgv,
            this.EdadDgv,
            this.SexoDgv,
            this.PulsacionesDgv});
            this.dataGridView1.Location = new System.Drawing.Point(144, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 223);
            this.dataGridView1.TabIndex = 11;
            // 
            // IdentificacionDgv
            // 
            this.IdentificacionDgv.HeaderText = "Indentificacion";
            this.IdentificacionDgv.Name = "IdentificacionDgv";
            // 
            // NombreDgv
            // 
            this.NombreDgv.HeaderText = "Nombre";
            this.NombreDgv.Name = "NombreDgv";
            // 
            // EdadDgv
            // 
            this.EdadDgv.HeaderText = "Edad";
            this.EdadDgv.Name = "EdadDgv";
            // 
            // SexoDgv
            // 
            this.SexoDgv.HeaderText = "Sexo";
            this.SexoDgv.Name = "SexoDgv";
            // 
            // PulsacionesDgv
            // 
            this.PulsacionesDgv.HeaderText = "Pulsaciones";
            this.PulsacionesDgv.Name = "PulsacionesDgv";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 386);
            this.panel1.TabIndex = 12;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.Image")));
            this.CancelarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarBtn.Location = new System.Drawing.Point(603, 316);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(85, 51);
            this.CancelarBtn.TabIndex = 13;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // ConsultarPersonaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 384);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.TotalHombrestxt);
            this.Controls.Add(this.TotalMujerestxt);
            this.Controls.Add(this.Totalinscritostxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoConsultaCmb);
            this.Name = "ConsultarPersonaGui";
            this.Text = "ConsultarPersonaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TipoConsultaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Totalinscritostxt;
        private System.Windows.Forms.TextBox TotalMujerestxt;
        private System.Windows.Forms.TextBox TotalHombrestxt;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificacionDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PulsacionesDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelarBtn;
    }
}
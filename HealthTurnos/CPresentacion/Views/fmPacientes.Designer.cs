namespace CPresentacion
{
    partial class fmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPacientes));
            this.viewDataPacientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbFiltro = new System.Windows.Forms.TextBox();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelText = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataPacientes)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewDataPacientes
            // 
            this.viewDataPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewDataPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.viewDataPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDataPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Gender,
            this.Age,
            this.Birthdate,
            this.Occupation,
            this.Status});
            this.viewDataPacientes.Location = new System.Drawing.Point(27, 172);
            this.viewDataPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewDataPacientes.Name = "viewDataPacientes";
            this.viewDataPacientes.RowHeadersWidth = 51;
            this.viewDataPacientes.Size = new System.Drawing.Size(1176, 432);
            this.viewDataPacientes.TabIndex = 0;
            this.viewDataPacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewDataPacientes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // Birthdate
            // 
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.MinimumWidth = 6;
            this.Birthdate.Name = "Birthdate";
            // 
            // Occupation
            // 
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.MinimumWidth = 6;
            this.Occupation.Name = "Occupation";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // textbFiltro
            // 
            this.textbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textbFiltro.Location = new System.Drawing.Point(640, 111);
            this.textbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbFiltro.Name = "textbFiltro";
            this.textbFiltro.Size = new System.Drawing.Size(327, 31);
            this.textbFiltro.TabIndex = 38;
            this.textbFiltro.TextChanged += new System.EventHandler(this.textbFiltro_TextChanged);
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Location = new System.Drawing.Point(976, 110);
            this.cbxOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(225, 33);
            this.cbxOpciones.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(513, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "Buscador";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(203)))));
            this.panelInfo.Controls.Add(this.labelText);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1232, 85);
            this.panelInfo.TabIndex = 39;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(112, 28);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(231, 33);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Lista de paciente";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.textbFiltro);
            this.panelContainer.Controls.Add(this.cbxOpciones);
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1232, 639);
            this.panelContainer.TabIndex = 40;
            // 
            // fmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 639);
            this.Controls.Add(this.viewDataPacientes);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1250, 686);
            this.MinimumSize = new System.Drawing.Size(1250, 686);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthTurnos - Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.viewDataPacientes)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewDataPacientes;
        private System.Windows.Forms.TextBox textbFiltro;
        private System.Windows.Forms.ComboBox cbxOpciones;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Label labelText;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
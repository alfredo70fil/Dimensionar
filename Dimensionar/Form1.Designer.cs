namespace Dimensionar
{
    partial class Dimensionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCampo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.campos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanoCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encabezadoCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblBloqueencabezado = new System.Windows.Forms.Label();
            this.lblbloque = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txttb = new System.Windows.Forms.TextBox();
            this.txtEb = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDespliegue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCampo.Location = new System.Drawing.Point(39, 22);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(67, 21);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campos,
            this.tipoCampo,
            this.tamanoCampo,
            this.encabezadoCampo});
            this.dataGridView1.Location = new System.Drawing.Point(39, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 204);
            this.dataGridView1.TabIndex = 1;
            // 
            // campos
            // 
            this.campos.HeaderText = "Campo";
            this.campos.Name = "campos";
            this.campos.ReadOnly = true;
            // 
            // tipoCampo
            // 
            this.tipoCampo.HeaderText = "Tipo de campo";
            this.tipoCampo.Name = "tipoCampo";
            this.tipoCampo.ReadOnly = true;
            // 
            // tamanoCampo
            // 
            this.tamanoCampo.HeaderText = "Tamaño de campo";
            this.tamanoCampo.Name = "tamanoCampo";
            this.tamanoCampo.ReadOnly = true;
            // 
            // encabezadoCampo
            // 
            this.encabezadoCampo.HeaderText = "Encabezado de campo";
            this.encabezadoCampo.Name = "encabezadoCampo";
            this.encabezadoCampo.ReadOnly = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnadir.Location = new System.Drawing.Point(40, 256);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 29);
            this.btnAnadir.TabIndex = 2;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistros.Location = new System.Drawing.Point(503, 47);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(161, 21);
            this.lblRegistros.TabIndex = 3;
            this.lblRegistros.Text = "Números de registros";
            // 
            // lblBloqueencabezado
            // 
            this.lblBloqueencabezado.AutoSize = true;
            this.lblBloqueencabezado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloqueencabezado.Location = new System.Drawing.Point(505, 105);
            this.lblBloqueencabezado.Name = "lblBloqueencabezado";
            this.lblBloqueencabezado.Size = new System.Drawing.Size(188, 21);
            this.lblBloqueencabezado.TabIndex = 6;
            this.lblBloqueencabezado.Text = "Encabezado de bloque (B)";
            // 
            // lblbloque
            // 
            this.lblbloque.AutoSize = true;
            this.lblbloque.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblbloque.Location = new System.Drawing.Point(504, 76);
            this.lblbloque.Name = "lblbloque";
            this.lblbloque.Size = new System.Drawing.Size(169, 21);
            this.lblbloque.TabIndex = 5;
            this.lblbloque.Text = "Tamaño de bloque (KB)";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimpiar.Location = new System.Drawing.Point(152, 256);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(75, 29);
            this.lblLimpiar.TabIndex = 7;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.UseVisualStyleBackColor = true;
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(736, 49);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 23);
            this.txtNum.TabIndex = 8;
            // 
            // txttb
            // 
            this.txttb.Location = new System.Drawing.Point(736, 78);
            this.txttb.Name = "txttb";
            this.txttb.Size = new System.Drawing.Size(100, 23);
            this.txttb.TabIndex = 10;
            // 
            // txtEb
            // 
            this.txtEb.Location = new System.Drawing.Point(736, 107);
            this.txtEb.Name = "txtEb";
            this.txtEb.Size = new System.Drawing.Size(100, 23);
            this.txtEb.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(505, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(505, 141);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(82, 21);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Resultado:";
            // 
            // lblDespliegue
            // 
            this.lblDespliegue.AutoSize = true;
            this.lblDespliegue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDespliegue.Location = new System.Drawing.Point(593, 141);
            this.lblDespliegue.Name = "lblDespliegue";
            this.lblDespliegue.Size = new System.Drawing.Size(0, 21);
            this.lblDespliegue.TabIndex = 14;
            // 
            // Dimensionamiento
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 307);
            this.Controls.Add(this.lblDespliegue);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtEb);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblLimpiar);
            this.Controls.Add(this.lblBloqueencabezado);
            this.Controls.Add(this.lblbloque);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCampo);
            this.Name = "Dimensionamiento";
            this.Text = "Dimensionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCampo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn campos;
        private DataGridViewTextBoxColumn tipoCampo;
        private DataGridViewTextBoxColumn tamanoCampo;
        private DataGridViewTextBoxColumn encabezadoCampo;
        private Button btnAnadir;
        private Label lblRegistros;
        private Label lblBloqueencabezado;
        private Label lblbloque;
        private Button lblLimpiar;
        private TextBox txtNum;
        private TextBox txttb;
        private TextBox txtEb;
        private Button btnCalcular;
        private Label lbl;
        private Label lblDespliegue;
    }
}
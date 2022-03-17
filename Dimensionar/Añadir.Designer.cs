namespace Dimensionar
{
    partial class Añadir
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
            this.lbltC = new System.Windows.Forms.Label();
            this.lblTaC = new System.Windows.Forms.Label();
            this.lblEC = new System.Windows.Forms.Label();
            this.txtTaC = new System.Windows.Forms.TextBox();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.btnanadir = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbltC
            // 
            this.lbltC.AutoSize = true;
            this.lbltC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltC.Location = new System.Drawing.Point(32, 26);
            this.lbltC.Name = "lbltC";
            this.lbltC.Size = new System.Drawing.Size(112, 21);
            this.lbltC.TabIndex = 0;
            this.lbltC.Text = "Tipo de campo";
            // 
            // lblTaC
            // 
            this.lblTaC.AutoSize = true;
            this.lblTaC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaC.Location = new System.Drawing.Point(32, 67);
            this.lblTaC.Name = "lblTaC";
            this.lblTaC.Size = new System.Drawing.Size(136, 21);
            this.lblTaC.TabIndex = 1;
            this.lblTaC.Text = "Tamaño de campo";
            // 
            // lblEC
            // 
            this.lblEC.AutoSize = true;
            this.lblEC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEC.Location = new System.Drawing.Point(32, 110);
            this.lblEC.Name = "lblEC";
            this.lblEC.Size = new System.Drawing.Size(164, 21);
            this.lblEC.TabIndex = 2;
            this.lblEC.Text = "Encabezado de campo";
            // 
            // txtTaC
            // 
            this.txtTaC.Location = new System.Drawing.Point(232, 65);
            this.txtTaC.Name = "txtTaC";
            this.txtTaC.Size = new System.Drawing.Size(121, 23);
            this.txtTaC.TabIndex = 4;
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(232, 112);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(121, 23);
            this.txtEC.TabIndex = 5;
            // 
            // btnanadir
            // 
            this.btnanadir.Location = new System.Drawing.Point(137, 162);
            this.btnanadir.Name = "btnanadir";
            this.btnanadir.Size = new System.Drawing.Size(75, 23);
            this.btnanadir.TabIndex = 6;
            this.btnanadir.Text = "Añadir";
            this.btnanadir.UseVisualStyleBackColor = true;
            this.btnanadir.Click += new System.EventHandler(this.btnanadir_Click);
            // 
            // txtTC
            // 
            this.txtTC.FormattingEnabled = true;
            this.txtTC.Items.AddRange(new object[] {
            "VARCHAR",
            "INT",
            "FLOAT"});
            this.txtTC.Location = new System.Drawing.Point(232, 26);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(121, 23);
            this.txtTC.TabIndex = 3;
            // 
            // Añadir
            // 
            this.AcceptButton = this.btnanadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 221);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnanadir);
            this.Controls.Add(this.txtEC);
            this.Controls.Add(this.txtTaC);
            this.Controls.Add(this.lblEC);
            this.Controls.Add(this.lblTaC);
            this.Controls.Add(this.lbltC);
            this.Name = "Añadir";
            this.Text = "Añadir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltC;
        private Label lblTaC;
        private Label lblEC;
        private TextBox txtTaC;
        private TextBox txtEC;
        private Button btnanadir;
        private ComboBox txtTC;
    }
}
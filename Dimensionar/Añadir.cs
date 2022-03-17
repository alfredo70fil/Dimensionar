using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimensionar
{
    public partial class Añadir : Form
    {
        int cantidad;
        DataGridView dgv;
        public Añadir(int cantidad, DataGridView dgv)
        {
            InitializeComponent();
            this.cantidad = cantidad;
            this.dgv = dgv;
        }

        private void btnanadir_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Campo " + cantidad;
                fila.Cells[1].Value = txtTC.Text;
                fila.Cells[2].Value = txtTaC.Text;
                fila.Cells[3].Value = txtEC.Text;
                dgv.Rows.Add(fila);
                Close();
            }
            catch (System.FormatException estado)
            {
                string mensaje = estado.ToString();
                MessageBox.Show(mensaje);
            }
        }
    }
}

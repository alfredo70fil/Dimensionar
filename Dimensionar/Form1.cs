namespace Dimensionar
{
    public partial class Dimensionamiento : Form
    {
        public Dimensionamiento()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            int cantidad = dataGridView1.Rows.Count;
            Añadir frm = new Añadir(cantidad, dataGridView1);
            frm.Visible = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculos calcular = new Calculos(int.Parse(txtNum.Text), int.Parse(txttb.Text), int.Parse(txtEb.Text), dataGridView1);
            
            try
            {
                lblDespliegue.Text = "Longitud de Fila: " + calcular.LongitudDeFila().ToString() + "\nTamaño real del bloque: " + calcular.TamanoRealBloque().ToString() + "\nFilas por bloque: " + calcular.FilasPorBloque().ToString() + "\nCantidad de bloques necesarios: " + calcular.CantidadBloques().ToString() + "\nTamaño de la Base de datos: "+calcular.TamanoBD().ToString() + " kB";
            }
            catch (System.FormatException estado)
            {
                string mensaje = estado.ToString();
                MessageBox.Show(mensaje);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txttb.Text = "";
            txtEb.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
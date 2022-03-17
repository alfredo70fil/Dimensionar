using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensionar
{
    internal class Calculos
    {
        int numRegistros, tamBloque, encBloque, cantidad, mayor, mayor1, tipodatoLong;
        DataGridView dgv;

        public Calculos(int numRegistros, int tamBloque, int encBloque, DataGridView dgv)
        {
            this.numRegistros = numRegistros;
            this.tamBloque = tamBloque;
            this.encBloque = encBloque;
            this.dgv = dgv;
        }

        public int LongitudDeFila()
        {
            mayor = 0;
            cantidad = dgv.Rows.Count - 1;
            for (int i = 0; i < cantidad; i++)
            {
                string strvalor = (string)dgv.Rows[i].Cells[2].Value;
                int valor = int.Parse(strvalor);
                if (mayor < valor)
                {
                    mayor = valor;
                } 
            }
            for (int i = 0; i < cantidad; i++)
            {
                string strvalor = (string)dgv.Rows[i].Cells[2].Value;
                int valor = int.Parse(strvalor);
                if (string.Equals("VARCHAR", (string)dgv.Rows[i].Cells[1].Value))
                {
                    tipodatoLong = 1;
                }
                else if (string.Equals("INT", (string)dgv.Rows[i].Cells[1].Value))
                {
                    tipodatoLong = 4;
                }
                else if (string.Equals("FLOAT", (string)dgv.Rows[i].Cells[1].Value))
                {
                    tipodatoLong = 8;
                }
            }
            return cantidad * (mayor + tipodatoLong) + 3;
        }

        public int TamanoRealBloque()
        {
            return (tamBloque * 1024) - encBloque;
        }

        public int FilasPorBloque()
        {
            return TamanoRealBloque() / LongitudDeFila();
        }

        public int CantidadBloques()
        {
            return numRegistros / FilasPorBloque();
        }

        public int TamanoBD()
        {
            return CantidadBloques() * tamBloque;
        }
    }
}

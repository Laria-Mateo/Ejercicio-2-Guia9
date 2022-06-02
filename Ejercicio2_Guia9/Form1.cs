using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_Guia9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Camion micamion;
        private void tcarga_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void biniciar_Click(object sender, EventArgs e)
        {

            int cantidad5litros = Convert.ToInt32(tB5litros.Text);
            int cantidad10litros = Convert.ToInt32(tB10litros.Text);
            if (cantidad5litros != 0 || cantidad10litros != 0)
            {
                micamion = new Camion(cantidad5litros, cantidad10litros);
                binformar.Enabled = true;
                bdescargar.Enabled = true;
                biniciar.Visible = false;
                tcarga.Visible = false;
                tdescarga.Visible = true;

                tinforme.Text = "Se inicio la carga con " + micamion.C5litros.ToString() + " bidones de 5 Litros" + " y " + micamion.C10litros.ToString() + " bidones de 10 Litros";
            }
            else
                tinforme.Text = "Sos boludito como vas a ir a trabar con el camion vacio";
        }

        private void bdescargar_Click(object sender, EventArgs e)
        {

            int cantidad5litros = Convert.ToInt32(tB5litros.Text);
            int cantidad10litros = Convert.ToInt32(tB10litros.Text);
            if (cantidad5litros != 0 || cantidad10litros != 0)
            {
                if (cantidad5litros <= micamion.C5litros && cantidad10litros <= micamion.C10litros)
                {
                    micamion.Descarga(cantidad5litros, cantidad10litros);
                    bdescargar.Enabled = true;
                    biniciar.Visible = false;
                    tinforme.Text = "Quedan: " + micamion.C5litros.ToString() + " bidones de 5 Litros" + " y " + micamion.C10litros.ToString() + " bidones de 10 Litros";
                }
                else
                    tinforme.Text = "Te faltan unos bidones pa";
            }
            else
                tinforme.Text = "Como vas a descargar nada estupido";
        }

        private void binformar_Click(object sender, EventArgs e)
        {
            if (micamion.CantidadParadas() > 0)
            {
                lBinforme.Items.Add("Cantidad de Paradas: " + micamion.CantidadParadas());
                lBinforme.Items.Add("Promedio de bidones de 5L: " + micamion.Promedio5litros());
                lBinforme.Items.Add("Promedio de bidones de 10L: " + micamion.Promedio10litros());
                lBinforme.Items.Add("Mayor descarga de bidones de 5L: " + micamion.Mayor5litros());
                lBinforme.Items.Add("Mayor descarga de bidones de 10L: " + micamion.Mayor10litros());
            }
            else
                tinforme.Text = "No se descargo nada pa";
        }
    }
}

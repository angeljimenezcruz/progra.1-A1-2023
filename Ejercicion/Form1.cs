using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1ConvertirConversores_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de= cbo1DeConversores.SelectedIndex;
            a = cbo2Aconversores.SelectedIndex;

            cantidad = double.Parse (txt1CantidadConversores.Text);
            double[] monedas = { 1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79 };

            respuesta = monedas[a] /[de] * cantidad;
            lbl4RespuestaConversores.Text = "respuesta: " + Math.Round(respuesta, 3);
        }
    }
}

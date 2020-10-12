using System;
using System.Windows.Forms;

namespace SobreCargaG3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           //Funciones
        private void btnSumar_Click(object sender, EventArgs e)
        {
            Funciones miFuncion = new Funciones();
            float a = float.Parse(txtbOperando1.Text);
            float b = float.Parse(txtbOperando2.Text);

            lbResultado.Text = miFuncion.sumar(a, b).ToString() ;

        }

        private void btnSumar21_Click(object sender, EventArgs e)
        {
            Funciones miFuncion = new Funciones();
            float a = float.Parse(txtbOper22.Text);
            float b = float.Parse(txbOper21.Text);
            float c = float.Parse(txtbOper23.Text);
            lbResultado21.Text = miFuncion.sumar(a, b, c).ToString();

        }
    }
}

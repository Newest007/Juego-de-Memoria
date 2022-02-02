using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_Memoria
{
    public partial class Form1 : Form
    {

        Random random = new Random(); //Utilizado para crear objetos random, se usa una lista de c# para crear
                                      //elementos tipo string de manera que seán los valores predeterminados a mezclar
        List<string> iconos = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
        };

        Label primerClick = null;
        Label segundoClick = null;

        //=======================================================================//
        //         Método para asignar iconos a cada label
        //=======================================================================//
        private void Asignar()
        {
            foreach(Control control in tableLayoutPanel1.Controls) //Usado para recorrer cada cuadro del tableLayout
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    int numeroRandom = random.Next(iconos.Count);
                    iconLabel.Text = iconos[numeroRandom];
                    iconos.RemoveAt(numeroRandom);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            Asignar(); //Llamando al método
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

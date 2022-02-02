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
            "p","p","N","N","t","t","o","o","Z","Z","ó","ó","d","d","j","j"
        };

        int prueba = 0;

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
                iconLabel.ForeColor = iconLabel.BackColor; //Ocultando los iconos al usuario
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            primerClick.ForeColor = primerClick.BackColor; //Color del fondo click 1
            segundoClick.ForeColor = segundoClick.BackColor; //Color del fondo click 2
            primerClick = null; //Retorna null al primer click
            segundoClick = null; //Retorna null al segundo click
            
        }

        private void VerificarGana()
        {
            /*
            if(label1.ForeColor == Color.Black && label2.ForeColor == Color.Black && label3.ForeColor == Color.Black && label4.ForeColor == Color.Black &&
                label5.ForeColor == Color.Black &&  label6.ForeColor == Color.Black && label7.ForeColor == Color.Black && label8.ForeColor == Color.Black &&
                label9.ForeColor == Color.Black && label10.ForeColor == Color.Black && label11.ForeColor == Color.Black && label12.ForeColor == Color.Black &&
                label13.ForeColor == Color.Black && label14.ForeColor == Color.Black && label15.ForeColor == Color.Black && label16.ForeColor == Color.Black)
            {
                MessageBox.Show("FELICIDADES HAS GANADO!!");

            }
            */


        }

        private void MensajeGanador()
        {
            if (prueba == 8)
            {
                MessageBox.Show("FELICIDADES HAS GANADO!!!","Enhorabuena",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        //Programación cuadro 1
        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if(clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if(primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if(primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                        
                    }
                    
                    timer1.Start();
                }
            }
            MensajeGanador();
        }
        //Programación cuadro 2
        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado

            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 3
        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado

            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }

        }
        //Programación cuadro 4
        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado

            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    
                    timer1.Start();
                }

            }

        }
        //Programación cuadro 5
        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 6
        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 7
        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 8
        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 9
        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 10
        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 11
        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 12
        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 13
        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 14
        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 15
        private void label15_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
        //Programación cuadro 16
        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label; //Para registrar si el label ha sido seleccionado
            //Si este label en concreto ha sido selecciona significa que no esta nullo
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificarGana();
                if (primerClick == null) //Para determinar si no ha habido un click antes
                {
                    primerClick = clickedLabel; //Se convierte en el primer elemento clickeado
                    primerClick.ForeColor = Color.Black;//al hacer click cambia el color del label a negro
                    return;
                }
                else
                {
                    //Si hay algo en el primer click será entonces el segundo
                    segundoClick = clickedLabel;
                    segundoClick.ForeColor = Color.Black;
                    if (primerClick.Text == segundoClick.Text)//Si el elemento clickeado es el segundo
                    {
                        primerClick = null;
                        segundoClick = null;
                        prueba += 1;

                        MensajeGanador();

                        return;
                    }
                    timer1.Start();
                }

            }
        }
    }
}

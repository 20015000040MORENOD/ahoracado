using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahoracado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] palabras = {"avance","vector","inicio","cuerpo"};
        public string palabraSecreta = "";
        public int intentosRestantes = 0;
        public int JuegoFinal = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            palabraSecreta = palabras[rand.Next(palabras.Length)];
            intentosRestantes = 6;
            label14.Text = "" + intentosRestantes;
            textBox1.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1 && char.IsLetter(textBox1.Text[0]))
            {
                char LetraIngresada = char.ToLower(textBox1.Text[0]);
                bool LetraExiste = palabraSecreta.Contains(LetraIngresada);

                if (LetraExiste)
                {
                    MessageBox.Show("La letra: '" + LetraIngresada + "' está en la palabra");
                    if (palabraSecreta[0] == LetraIngresada)
                    {
                        label1.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (palabraSecreta[1] == LetraIngresada)
                    {
                        label2.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (palabraSecreta[2] == LetraIngresada)
                    {
                        label3.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (palabraSecreta[3] == LetraIngresada)
                    {
                        label4.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (palabraSecreta[4] == LetraIngresada)
                    {
                        label5.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (palabraSecreta[5] == LetraIngresada)
                    {
                        label6.Text = LetraIngresada.ToString();
                        JuegoFinal = JuegoFinal + 1;
                    }
                    if (JuegoFinal == 6)
                    {
                        MessageBox.Show("Ganaste");
                        textBox1.Enabled = false;
                        label1.Text = "________";
                        label2.Text = "________";
                        label3.Text = "________";
                        label4.Text = "________";
                        label5.Text = "________";
                        label6.Text = "________";
                       }
                }
                else
                {
                    MessageBox.Show("la letra '" + LetraIngresada + "' no está en la palabra");
                    intentosRestantes = intentosRestantes - 1;
                    label14.Text = "" + intentosRestantes;
                    if (intentosRestantes == 0)
                    {
                        MessageBox.Show("Haz perdido incia otra vez");
                        textBox1.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingresa solo letras válidas");
            }
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}

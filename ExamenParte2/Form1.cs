using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblpromedio.Visible = false;
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            double nota1decimal = double.Parse(txtnota1.Text);
            double nota2decimal = double.Parse(txtnota2.Text);
            double nota3decimal = double.Parse(txtnota3.Text);
            double nota4decimal = double.Parse(txtnota4.Text);
            double nota5decimal = double.Parse(txtnota5.Text);

            double notafinal = (nota1decimal + nota2decimal + nota3decimal + nota4decimal + nota5decimal) / 5;
            lblpromedio.Text = Convert.ToDecimal(notafinal).ToString("N1");
            lblpromedio.Visible = true;

            if (notafinal <= 1.0)
            {
                MessageBox.Show("Reprueba la materia sin lograr realizar proceso de recuperación."); 
            }
            else
                if (notafinal <= 2.9)
                {
                    MessageBox.Show("Reprueba la materia y puede hacer la habilitación.");
                } 
                else
                    if (notafinal <= 3.9)
                       {
                           MessageBox.Show("Aprueba la materia con plan de mejora.");
                       }
                       else
                           if (notafinal <= 4.5)
                            {
                                MessageBox.Show("Buen rendimiento.");
                            }
                            else
                                if(notafinal <= 4.9)
                                    {
                                         MessageBox.Show("Excelente.");
                                    } 
                                 else
                                    {
                                         MessageBox.Show("Graduado con honores.");
                                    } 
        }
    }
}

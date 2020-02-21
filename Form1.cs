using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonApp
{
    public partial class Form1 : Form
    {
        int FiguraID = 0;
        int DzialanieID = 0;
        public Form1()
        {

            InitializeComponent();
            Obliczenia.Enabled = false;

            LiczPole.Enabled = false;
            LiczObwod.Enabled = false;
            LiczObjetosc.Enabled = false;
            LiczPolePowCal.Enabled = false;

            Val_1.Enabled = false;
            Val_2.Enabled = false;
            Val_3.Enabled = false;

            LiczButton.Enabled = false;

            Wynik.Enabled = false;
        }

        private void Figura_kwadrat_CheckedChanged(object sender, EventArgs e)
        {
            Obliczenia.Enabled = true;
            LiczPole.Enabled = true;
            LiczObwod.Enabled = true;

            if (Figura_kwadrat.Checked)
            {
                FiguraID = 1;
            }
        }

        private void LiczPole_CheckedChanged(object sender, EventArgs e)
        {
            Val_1.Enabled = true;
            Val_2.Enabled = true;

            if (LiczPole.Checked)
            {
                DzialanieID = 1;
            }

            LiczButton.Enabled = true;
        }

        private void LiczButton_Click(object sender, EventArgs e)
        {
            switch (FiguraID)
            {
                case 1:
                    {
                        Kwadrat Figura = new Kwadrat(double.Parse(Val_1.Text));
                        switch (DzialanieID)
                        {
                            case 1:
                                {
                                    Wynik.Text = "Pole Kwadratu wynosi" + Figura.Pole();
                                    break;
                                }
                            case 2:
                                {
                                    Wynik.Text = "Obwód Kwadratu wynosi: " + Figura.Obwod();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}

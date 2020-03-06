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

        

        private void LiczPole_CheckedChanged(object sender, EventArgs e)
        {
            Val_1.Enabled = false;
            Val_2.Enabled = false;

            if (LiczPole.Checked)
            {
                Val_1.Enabled = true;
                Val_2.Enabled = true;
                DzialanieID = 1;
            }

            LiczButton.Enabled = true;
        }

        private void LiczObwod_CheckedChanged(object sender, EventArgs e)
        {
            Val_1.Enabled = false;
            Val_2.Enabled = false;


            if (LiczObwod.Checked)
            {
                Val_1.Enabled = true;
                Val_2.Enabled = true;
                DzialanieID = 2;
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
                                    Wynik.Text = "Pole Kwadratu wynosi: " + Figura.LiczPole();
                                    break;
                                }
                            case 2:
                                {
                                    Wynik.Text = "Obwód Kwadratu wynosi: " + Figura.LiczObwod();
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        Prostokat Figura = new Prostokat(double.Parse(Val_1.Text), double.Parse(Val_2.Text));
                        switch (DzialanieID)
                        {
                            case 1:
                                {
                                    Wynik.Text = "Pole Prostokąta wynosi: " + Figura.LiczPole();
                                    break;
                                }
                            case 2:
                                {
                                    Wynik.Text = "Obwód Prostokąta wynosi: " + Figura.LiczObwod();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private void Figura_kwadrat_CheckedChanged(object sender, EventArgs e)
        {
            
            DisableAll();
            

            if (Figura_kwadrat.Checked)
            {
                Obliczenia.Enabled = true;
                LiczPole.Enabled = true;
                LiczObwod.Enabled = true;
                FiguraID = 1;
            }
        }

        private void Figura_Szescian_CheckedChanged(object sender, EventArgs e)
        {
            
            DisableAll();
            
            if(Figura_Szescian.Checked)
            {
                Obliczenia.Enabled = true;
                LiczObjetosc.Enabled = true;
                LiczPolePowCal.Enabled = true;
                FiguraID = 2;
            }
        }

        private void Figura_Prostokat_CheckedChanged(object sender, EventArgs e)
        {
            
            DisableAll();

            if (Figura_Prostokat.Checked)
            {
                Obliczenia.Enabled = true;
                LiczPole.Enabled = true;
                LiczObwod.Enabled = true;
                FiguraID = 3;
            }

        }


        private void DisableAll()
        {
            LiczObwod.Enabled = false;
            LiczPole.Enabled = false;
            LiczObjetosc.Enabled = false;
            LiczPolePowCal.Enabled = false;
        }


    }
}

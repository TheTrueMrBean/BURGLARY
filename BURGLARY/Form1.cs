using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BURGLARY
{
    public partial class Form1 : Form
    {

        double flashlightPrice = 5;
        double crowbarPrice = 15;
        double skiMaskPrice = 7.5;
        double flashlightNumber = 0;
        double crowbarNumber = 0;
        double skiMaskNumber = 0;
        double subtotalVari = 0;
        double taxVari = 0;
        double totalVari;
        double tenderedVari = 0;
        double changeVari = 0;
        string orderVari;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                errorOutput.Text = "";
                errorOutput.Visible = false;


                 flashlightPrice = 5;
                crowbarPrice = 15;
                 skiMaskPrice = 7.5;
                skiMaskNumber = Convert.ToDouble(skiMaskInput.Text);
                flashlightNumber = Convert.ToDouble(flashlightInput.Text);
                crowbarNumber = Convert.ToDouble(crowbarInput.Text);
                double flashlightVari = flashlightPrice * flashlightNumber;
                 double crowbarVari = crowbarPrice * crowbarNumber;
                double skiMaskVari = skiMaskPrice * skiMaskNumber;

                 subtotalVari = flashlightVari + crowbarVari + skiMaskVari;
                 taxVari = subtotalVari * .13;
                 totalVari = subtotalVari + taxVari;

                subtotalDisplay.Text = $"{subtotalVari}";
                taxDisplay.Text = $"{taxVari}";
                totalDisplay.Text = $"{totalVari}";
                calculateT.Visible = true;



            }
            catch
            {
                errorOutput.Text = "Error Error Error Error Input Number";
                errorOutput.Visible = true;    
            }

        }

        private void calculateT_Click(object sender, EventArgs e)
        {
            try
            {
                errorOutput.Text = "";
                errorOutput.Visible = false;
                tenderedVari = Convert.ToDouble(tenderedInput.Text);

                double changeVari = tenderedVari - totalVari;
                changeDisplay.Text = $"{changeVari}";
                printRecipt.Visible = true;

            }
            catch
            {
                errorOutput.Text = "Error Error Error Error Input Number";
                errorOutput.Visible = true;
            }

        }

        private void printRecipt_Click(object sender, EventArgs e)
        {
            orderVari = nameInput.Text;
        }
    }
}

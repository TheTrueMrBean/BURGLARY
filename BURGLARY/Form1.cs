using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
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
        double subtotalVari;
        double taxVari = 0;
        double totalVari;
        double tenderedVari = 0;
        double changeVari;
        string orderVari;
        double flashlightVari;
        double crowbarVari;
        double skiMaskVari;
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
                 flashlightVari = flashlightPrice * flashlightNumber;
                 crowbarVari = crowbarPrice * crowbarNumber;
                 skiMaskVari = skiMaskPrice * skiMaskNumber;

                 subtotalVari = flashlightVari + crowbarVari + skiMaskVari;
                 taxVari = subtotalVari * .13;
                 totalVari = subtotalVari + taxVari;

                subtotalDisplay.Text = $"{subtotalVari.ToString("C")}";
                taxDisplay.Text = $"{taxVari.ToString("C")}";
                totalDisplay.Text = $"{totalVari.ToString("C")}";
                calculateT.Enabled= true;



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

                changeVari = tenderedVari - totalVari;
                changeDisplay.Text = $"{changeVari.ToString("C")}";
                printRecipt.Enabled = true; 

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
            titleRecipt.Visible = true;
            errorOutput.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            finalFlashlight.Text = $"x{flashlightNumber}   =   {flashlightVari.ToString("C")}";
            finalFlashlight.Visible = true;
            flashlightRecipt.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            finalCrowbar.Text = $"x{crowbarNumber}   =   {crowbarVari.ToString("C")}";
            finalCrowbar.Visible = true;
            crowbarDisplay.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            finalSkiMask.Text = $"x{skiMaskNumber}   =   {skiMaskVari.ToString("C")}";
            finalSkiMask.Visible = true;
            skiMaskRecipt.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            subtotalRecipt.Visible = true;
            finalSubtotal.Text = $"{subtotalVari.ToString("C")}";
            finalSubtotal.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            taxRecipt.Visible = true;
            finalTax.Text = $"{taxVari.ToString("C")}";
            finalTax.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            totalRecipt.Visible = true;
            finalTotal.Text = $"{totalVari.ToString("C")}";
            finalTotal.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            tenderedRecipt.Visible = true;
            finalTendered.Text = $"{tenderedVari.ToString("C")}";
            finalTendered.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            changeRecipt.Visible = true;
            changeDisplay.Visible = true;
            finalChange.Text = $"{changeVari.ToString("C")}";
            finalChange.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            message.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            dateRecipt.Visible = true;
            finalDate.Visible = true;
            finalDate.Text = "September   25   2024";
            Refresh();
            Thread.Sleep(1000);
            orderRecipt.Visible = true;
            finalOrderNumber.Visible = true;
            finalOrderNumber.Text = "3025647";
            Refresh();
            Thread.Sleep(1000);
            nameRecipt.Visible = true;
            finalOrderName.Visible = true;
            finalOrderName.Text = $"{orderVari}";
            Refresh();
            Thread.Sleep(1000);



        }

        private void prices_Click(object sender, EventArgs e)
        {
            errorOutput.Visible = true;
            titleRecipt.Visible = true;
            flashlightRecipt.Visible = true;
            crowbarDisplay.Visible = true;
            skiMaskRecipt.Visible = true;
            finalFlashlight.Text = $"{flashlightPrice.ToString("C")}";
            finalCrowbar.Text = $"{crowbarPrice.ToString("C")}";
            finalSkiMask.Text = $"{skiMaskPrice.ToString("C")}";
            finalSkiMask.Visible = true;
            finalFlashlight.Visible = true;
            finalCrowbar.Visible = true;   


        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            flashlightInput.Text = "";
            crowbarInput.Text = "";
            skiMaskInput.Text = "";
            calculateT.Enabled = false;
            printRecipt.Enabled = false;
            nameInput.Text = "";
            tenderedInput.Text = "";
            subtotalDisplay.Text = "";
            taxDisplay.Text = "";
            totalDisplay.Text = "";
            changeDisplay.Text = "";
        }
    }
}

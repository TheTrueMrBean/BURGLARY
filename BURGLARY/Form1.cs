using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        SoundPlayer player = new SoundPlayer(Properties.Resources.Checkout_Scanner_Beep_SoundBible_com_593325210);
        SoundPlayer steve = new SoundPlayer(Properties.Resources.steve_calling_Dave_1592335974);
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
                player.Play();
                Refresh();
                Thread.Sleep(1000);

                taxDisplay.Text = $"{taxVari.ToString("C")}";
                player.Play();
                Refresh();
                Thread.Sleep(1000);

                totalDisplay.Text = $"{totalVari.ToString("C")}";
                player.Play();
                Refresh();
                Thread.Sleep(1000);

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
                player.Play();
                Refresh();
                Thread.Sleep(1000);
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
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            finalFlashlight.Text = $"x{flashlightNumber}   =   {flashlightVari.ToString("C")}";
            finalFlashlight.Visible = true;
            flashlightRecipt.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            finalCrowbar.Text = $"x{crowbarNumber}   =   {crowbarVari.ToString("C")}";
            finalCrowbar.Visible = true;
            crowbarDisplay.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            finalSkiMask.Text = $"x{skiMaskNumber}   =   {skiMaskVari.ToString("C")}";
            finalSkiMask.Visible = true;
            skiMaskRecipt.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            subtotalRecipt.Visible = true;
            finalSubtotal.Text = $"{subtotalVari.ToString("C")}";
            finalSubtotal.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            taxRecipt.Visible = true;
            finalTax.Text = $"{taxVari.ToString("C")}";
            finalTax.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            totalRecipt.Visible = true;
            finalTotal.Text = $"{totalVari.ToString("C")}";
            finalTotal.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            tenderedRecipt.Visible = true;
            finalTendered.Text = $"{tenderedVari.ToString("C")}";
            finalTendered.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            changeRecipt.Visible = true;
            changeDisplay.Visible = true;
            finalChange.Text = $"{changeVari.ToString("C")}";
            finalChange.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            message.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            dateRecipt.Visible = true;
            finalDate.Visible = true;
            finalDate.Text = "September   25   2024";
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            orderRecipt.Visible = true;
            finalOrderNumber.Visible = true;
            finalOrderNumber.Text = "3025647";
            player.Play();
            Refresh();
            Thread.Sleep(1000);
            nameRecipt.Visible = true;
            finalOrderName.Visible = true;
            finalOrderName.Text = $"{orderVari}";
            steve.Play();
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
            errorOutput.Visible = false;
            flashlightRecipt.Visible = false;
            crowbarDisplay.Visible = false;
            skiMaskRecipt.Visible = false;
            subtotalRecipt.Visible = false;
            totalRecipt.Visible = false;
            taxRecipt.Visible = false;
            tenderedRecipt.Visible = false;
            changeRecipt.Visible = false;
            message.Visible = false;
            dateRecipt.Visible = false;
            orderRecipt.Visible = false;
            nameRecipt.Visible = false;
            finalFlashlight.Visible = false;
            finalCrowbar.Visible = false;
            finalFlashlight.Text = "";
            finalCrowbar.Text = "";
            finalSkiMask.Text = "";
            finalSkiMask.Visible = false;


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class TshirtOrderFrm : Form
    {
        public TshirtOrderFrm()
        {
            InitializeComponent();
        }
        //Setting constant prices for print/material
        const decimal PrintPrice = 2.00m;
        const decimal MaterialCostLycra = 2.50m;
        const decimal MaterialCostCotton = 1.00m;
        //Declaring all variables required 
        decimal TotalPrintPrice = 0m;
        decimal TotalPrice = 0m; 
        decimal TotalMaterialCost = 0m;
        decimal TotalSizeCost = 0m;
        string ShirtMaterial = "";
        string ShirtSize = "";
        Random RandomNumber = new Random();

        private void TshirtPrintTextChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //Checking if Printing check boxs is checked
            if (!TshirtPrintTextChkBox.Checked){
                TshirtPrintingTxtBox.Hide();
                TotalPrintPrice = 0m;
            }
            else
            {
                TshirtPrintingTxtBox.Show();
                TotalPrintPrice = PrintPrice;
            }
   
        }

        private void TshirtSizeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TshirtSizeCmbBox.SelectedItem != null)
            {
                //Getting selected value from the shirt size combobox
                var ShirtSizeSelected = (string)TshirtSizeCmbBox.SelectedItem;
                //splitting the selected value every space there is as only the number is required
                string[] ShirtSplit = ShirtSizeSelected.Split(' ');
                //Using substring to extract required number for example ShirtSplit[2] = £4.50 and ShirtSplit[2].Substring(1, 4) = 4.50
                decimal ShirtCost = decimal.Parse(ShirtSplit[2].Substring(1, 4));
                //Setting the shirt size for the MessageBox later on
                ShirtSize = ShirtSplit[0];
                //Setting the total cost of the size to the shirt cost
                TotalSizeCost = ShirtCost;
            }
        }

        private void TshirtCalculateBtn_Click(object sender, EventArgs e)
        {
            //Checking which radio button is pressed and setting the material based on which radio button is checked
            if (TshirtMaterialLycraRadioBtn.Checked)
            {
                TotalMaterialCost = MaterialCostLycra;
                ShirtMaterial = "Lycra";
            } 
            if (TshirtMaterialCottonRadioBtn.Checked)
            {
                TotalMaterialCost = MaterialCostCotton;
                ShirtMaterial = "Cotton";
            }
            //Calculation for Total price
            TotalPrice = (TotalPrintPrice + TotalSizeCost + TotalMaterialCost) * TshirtQauntityNumUD.Value;
            //Generating a new random number for the order number
            TshirtOrderNumLbl.Text = $"No: {RandomNumber.Next(1000)}";
            //Setting the total label text to the totalprice calculation
            TshirtTotalCostBoxLbl.Text = $"£{TotalPrice}";
            //Concatenating the variables together inorder to show what has been ordered
            MessageBox.Show($"Surname: {TshirtSurnameBoxLbl.Text} \n " +
                $"{TshirtQauntityNumUD.Value} {ShirtSize} {ShirtMaterial} T-shirt(s) \n " +
                $"Text: {TshirtPrintingTxtBox.Text} \n " +
                $"Pickup: {TshirtCollectionDateDTPicker.Text} \n " +
                $"{TshirtTotalCostBoxLbl.Text}");


        }

        private void TshirtClearBtn_Click(object sender, EventArgs e)
        {
            TshirtCollectionDateDTPicker.Value = DateTime.Now.Date;
            TshirtColorCmbBox.SelectedItem = null;
            TshirtMaterialCottonRadioBtn.Checked = true;
            TshirtSizeCmbBox.SelectedItem= null;
            TshirtSurnameBoxLbl.Text = "";
            TshirtPrintTextChkBox.Checked = false;
            TshirtTotalCostBoxLbl.Text = "£0.00";
            TshirtPrintingTxtBox.Text = "";
            TshirtQauntityNumUD.Value = 1;

        }

        private void TshirtExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

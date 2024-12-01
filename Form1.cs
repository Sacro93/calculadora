using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calculadora__
{
    public partial class Form1 : Form
    {
        private double currentValue = 0; // Almacena el valor actual
        private string currentOperation = ""; // Operación actual (+, -, *, /)
        private bool operationPressed = false; // Indica si se presionó un operador

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || operationPressed)
                txtResult.Clear();

            operationPressed = false;
            Button b = (Button)sender;
            txtResult.Text += b.Text;
        }

        private void btnAction(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            currentOperation = b.Text;
            currentValue = double.Parse(txtResult.Text);
            operationPressed = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            currentValue = 0;
            currentOperation = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            double secondValue = double.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            double result = 0;

            switch (currentOperation)
            {
                case "+":
                    result = currentValue + secondValue;
                    break;
                case "-":
                    result = currentValue - secondValue;
                    break;
                case "*":
                    result = currentValue * secondValue;
                    break;
                case "/":
                    result = secondValue != 0 ? currentValue / secondValue : 0;
                    break;
            }
            txtResult.Text = result.ToString(CultureInfo.InvariantCulture);
            txtResult.Text = result.ToString();
            lstHistory.Items.Add($"{currentValue} {currentOperation} {secondValue} = {result.ToString("0.00", CultureInfo.InvariantCulture)}");
            currentValue = result;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
                txtResult.Text += ".";
        }
    }
}

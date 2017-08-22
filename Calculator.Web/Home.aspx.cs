using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            ResultLabel.Text = client.Add(Convert.ToInt32(FirstNumberTextBox.Text), Convert.ToInt32(SecondNumberTextBox.Text)).ToString();
        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            ResultLabel.Text = client.Subtract(Convert.ToInt32(FirstNumberTextBox.Text), Convert.ToInt32(SecondNumberTextBox.Text)).ToString();            
        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            ResultLabel.Text = client.Multiply(Convert.ToInt32(FirstNumberTextBox.Text), Convert.ToInt32(SecondNumberTextBox.Text)).ToString();
        }

        protected void DivideButton_Click(object sender, EventArgs e)
        {
            CalculatorService.CalculatorWebServiceSoapClient client = new CalculatorService.CalculatorWebServiceSoapClient();

            int firstNumber = Convert.ToInt32(FirstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);

            if(secondNumber == 0)
            {
                ResultLabel.Text = "Divide by zero not permitted!!";
            }
            else
                ResultLabel.Text = client.Divide(Convert.ToInt32(FirstNumberTextBox.Text), Convert.ToInt32(SecondNumberTextBox.Text)).ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        [WebMethod]
        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        [WebMethod]
        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        [WebMethod]
        public int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber/secondNumber;
        }
    }
}

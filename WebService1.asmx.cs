using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Service_Application
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int aFromCelsiustoFahrenheit(int Celsius)
        {
            int Fahrenheit = Celsius * 9 / 5 + 32;

            return Fahrenheit; 
            
        }

        [WebMethod]
        public int aFromFahrenheittoCelsius(int Fahrenheit)
        {
            int Celsius = (Fahrenheit - 32) * 5 / 9;

            return Celsius;
        }

        [WebMethod]
        public string bDateTimeDisplay()
        {
            return DateTime.Now.ToString("dddddd, dd MMMMMM yyy HH':'mm':'ss");
        }

        [WebMethod]
        public double dEuroToLei(double Lei)
        {
            // 1 EUR = 4.9279 RON
            double Euro = 4.9279 * Lei;

            return Euro;
        }

        [WebMethod]
        public double dLeiToEuro(double Euro)
        {
            // 1 RON = 0.2029 EUR
            double Lei = 0.2029 * Euro;

            return Lei;
        }

        [WebMethod]
        public List<string> cfiveElements()
        {

            List<string> numbersStrLst = new List<string>
            { "One mango", "Two bananas", "Three apples","Four strawberries","Five bubbles"};

            return numbersStrLst;
        }

    }
}

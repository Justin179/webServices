using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://pragimtech.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(MessageName="add two numbers")]
        public int Add(int firstNum, int secondNum)
        {
            return firstNum+secondNum;
        }

        [WebMethod]
        public int Add(int firstNum, int secondNum, int thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATION"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("you have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<String>) Session["CALCULATION"];
            }

        }
    }
}

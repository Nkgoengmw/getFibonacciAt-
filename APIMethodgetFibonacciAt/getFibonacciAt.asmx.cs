using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace APIMethodgetFibonacciAt
{
    /// <summary>
    /// Summary description for getFibonacciAt
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class getFibonacciAt : System.Web.Services.WebService
    {


        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n > 100) { return -1; }
            else
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
        }

    }
}


    


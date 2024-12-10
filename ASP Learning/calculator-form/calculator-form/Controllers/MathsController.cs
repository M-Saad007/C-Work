using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calculator_form.Controllers
{
    public class MathsController : Controller
    {
        // GET: Maths
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection obj)
        {
            try
            {
                int num1 = Convert.ToInt32(obj["txtnum1"]);
                int num2 = Convert.ToInt32(obj["txtnum2"]);
                string operation = obj["operation"];

                string result = string.Empty;

                if (operation == "Add")
                {
                    result = $"The sum is {num1 + num2}";
                }
                else if (operation == "Subtract")
                {
                    result = $"The difference is {num1 - num2}";
                }
                else if (operation == "Multiply")
                {
                    result = $"The product is {num1 * num2}";
                }
                else if (operation == "Divide")
                {
                    if (num2 != 0)
                    {
                        result = $"The quotient is {num1 / num2}";
                    }
                    else
                    {
                        result = "Division by zero is not allowed.";
                    }
                }
                else
                {
                    result = "Invalid operation selected.";
                }

                ViewBag.data = result;
            }
            catch (Exception ex)
            {
                ViewBag.data = "Error: " + ex.Message;
            }

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace semana16.Controllers
{
    public class HelloWorldController1 : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }
        public string welcome()
        {
            return "esta es la accion de bienvenida";
        }
        public string Parameters(string name, int edad)
        {
        return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad} años");
            }
    }
}

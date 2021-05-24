using ContactForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ContactForm.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactForm()
        {
            return View();
        }
        public IActionResult SaveContactInformation(ContactInformation newinfo)
        {    
            //Saves contact info/message into new file in root directory
            StreamWriter writer = System.IO.File.CreateText($"wwwroot/{newinfo.FirstName}{newinfo.LastName}.txt");
            writer.WriteLine($"First Name: {newinfo.FirstName}\nLast Name: {newinfo.LastName}\nEmail: {newinfo.Email}\nMessage: \n{newinfo.Message}");
            writer.Close();
            return View(newinfo);
        }
    }
}

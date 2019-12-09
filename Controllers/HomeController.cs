using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        // Display Registration Form
        public IActionResult Index()
        {
            return View();
        }
        // Display Login Form
        public IActionResult LoginForm()
        {
            return View();
        }
        // Form validation for registering new user
        public IActionResult Register()
        {
            return View(); // redirect to Dashboard upon success
        }
        // Form validation for logging in user
        public IActionResult Login()
        {
            return View(); // redirect to Dashboard upon success
        }
        // Display Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
        // Add or subtract transactions from account
        public IActionResult Transaction()
        {
            return View(); // redirect to Dashboard
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

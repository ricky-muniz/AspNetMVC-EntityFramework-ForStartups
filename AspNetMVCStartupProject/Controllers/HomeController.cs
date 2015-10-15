using AspNetMVCStartupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCStartupProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            TestViewModel vm = new TestViewModel();

            vm.Title = "Título";
            vm.Message = "This is the page message";
            vm.TestList = new List<TestDataModel>();
            vm.TestList.Add(new TestDataModel() { id = 12345, name = "Test 1" });
            vm.TestList.Add(new TestDataModel() { id = 12347, name = "Test 2" });
            vm.TestList.Add(new TestDataModel() { id = 12348, name = "Test 3" });
            vm.TestList.Add(new TestDataModel() { id = 12349, name = "Test 4" });
            vm.TestList.Add(new TestDataModel() { id = 12350, name = "Test 5" });

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
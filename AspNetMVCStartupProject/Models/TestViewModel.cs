using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVCStartupProject.Models
{
    public class TestViewModel
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public List<TestDataModel> TestList { get; set; }
    }
}
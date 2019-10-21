using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Project.ViewModels
{
    public class TestViewModel
    {
        //   public int mTestID { get; set; }
        public string mTestDescription { get; set; }
        public int mTestMark { get; set; }
        public string mTestDate { get; set; }

        public List<TestViewModel> TestsList { get; set; }
        public List<TestViewModel> Tests { get; set; }

        public TestViewModel()
        {
            // mTestID = 0;
            mTestDescription = "";
            mTestMark = 0;
            mTestDate = "";

        }


        public TestViewModel(string TestDescription, int TestMark, string TestDate)
        {
            mTestDescription = TestDescription;
            mTestMark = TestMark;
            mTestDate = TestDate;


        }
    }


}
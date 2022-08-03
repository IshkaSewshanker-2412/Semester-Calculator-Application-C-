using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_Application
{
    class library
    {
        //declaring public getters and setter

        //getter and setter for weeks in the semester
        public static int weeksInTheSemester { get; set; }
        //getter and setter for date and time for starting of semester
        public static DateTime startOfSemester { get; set; }
        //getter and setter for date and time ending of semester
        public static DateTime endOfSemester { get; set; }
        //getter and setter for module code
        public  string moduleCode { get; set; }
        //getter and setter for module name
        public  string moduleName { get; set; }
        //getter and setter for number of credits
        public  int noOfCredits { get; set; }
        //getter and setter for hours per week
        public  int hoursPerWeek { get; set; }
        //getter and setter for self studying
        public  double selfStudy { get; set; }
    }
}

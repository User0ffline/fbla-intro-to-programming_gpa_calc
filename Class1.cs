using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAUX
{
    public class Courses
    {
        public static string AP_COURSE_TYPE = "AP";
        public static string IB_COURSE_TYPE = "IB";
        public static string HONORS_COURSE_TYPE = "Honors";
        public static string REG_COURSE_TYPE = "Regular";

        public static Dictionary<String, double> gradesMapping = new Dictionary<String, double>(){
            {"A", 1},
            {"A-", .9},
            {"B+", .8}
        };

        public Courses() { }

        public String name;
        public double credits;

    }
}

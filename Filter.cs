namespace LSSEastProblemsDB
{
    internal class Filter
    {
        public static readonly string[] Subjects =
        {
            "All",
            "Math",
            "Biology",
            "Chemistry",
            "Physics",
            "Computer Information Systems",
            "Computer Science",
            "Business Math/Accounting"
        };

        public static readonly string[] MathCourseCodes =
        {
            "All",
            "MATH 92","MATH 98","MATH 101","MATH 147",

            "AMATH 97","AMATH 141",

            "CMATH 107","CMATH 146",

            "MATH& 107","MATH& 141","MATH& 142","MATH& 146",
            "MATH& 148","MATH& 151","MATH& 152","MATH& 153","MATH& 254"
        };
        public static readonly string[] BioCourseCodes = 
        { 
            "All",
            "BIOL 180","BIOL 185",
            "BIOL 214","BIOL 215","BIOL 216",

            "BIOL& 160","BIOL& 175",
            "BIOL& 211","BIOL& 212","BIOL& 213",
            "BIOL& 241","BIOL& 242","BIOL& 260"

        };
        public static readonly string[] ChemCourseCodes = 
        { 
            "All",
            "CHEM 115",
            "CHEM 214", "CHEM 215", "CHEM 216",

            "CHEM& 110","CHEM& 121","CHEM& 131","CHEM& 139",
            "CHEM& 161","CHEM& 162","CHEM& 163",
        };
        public static readonly string[] PhysicsCourseCodes = 
        { 
            "All",
            "PHYS 214","PHYS 215","PHYS 216",

            "PHYS& 110","PHYS& 114","PHYS& 115","PHYS& 116",
            "PHYS& 221","PHYS& 222","PHYS& 223"
        };
        public static readonly string[] CompSciCourseCodes = 
        { 
            "All",
            "CS 142","CS 143","CS 310",
            "CS 320","CS 330","CS 340",
            "CS 350","CS 360","CS 370",
            "CS 380","CS 410","CS 420",
            "CS 440","CS 450","CS 490","CS 491"
        };
        public static readonly string[] CompInfoSysCourseCodes =
        {
            "All",
            "CIS 110","CIS 160","CIS 166",
            "CIS 169","CIS 182","CIS 185", 
            "CIS 189","CIS 195","CIS 218",
            "CIS 235","CIS 245","CIS 266",
            "CIS 269","CIS 282","CIS 284",
            "CIS 287","CIS 293"
        };
        public static readonly string[] BusAccCourseCodes = { "All" };

        public static string[] GetCourses(string filter)
        {
            string[] courses = null;
            switch (filter)
            {
                case "Math":
                    courses = Filter.MathCourseCodes;
                    break;
                case "Biology":
                    courses = Filter.BioCourseCodes;
                    break;
                case "Chemistry":
                    courses = Filter.ChemCourseCodes;
                    break;
                case "Physics":
                    courses = Filter.PhysicsCourseCodes;
                    break;
                case "Computer Science":
                    courses = Filter.CompSciCourseCodes;
                    break;
                case "Computer Information Systems":
                    courses = Filter.CompInfoSysCourseCodes;
                    break;
                case "Business Math/Accounting":
                    courses = Filter.BusAccCourseCodes;
                    break;
            }
            return courses;
        }
    }
}

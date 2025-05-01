namespace LSSEastProblemsDB
{
    internal class Filter
    {
        public string[] Subjects =
        {
            "All",
            "Math",
            "Biology",
            "Chemistry",
            "Physics",
            "Computer Science",
            "Business Math/Accounting"
        };

        public string[] MathCourseCodes =
        {
            "All",
            "MATH 92", "MATH 98", "MATH 101", "MATH 147",
            "AMATH 97", "AMATH 141",
            "CMATH 107", "CMATH 146",
            "MATH& 107", "MATH& 141", "MATH& 142", "MATH& 146",
            "MATH& 148", "MATH& 151", "MATH& 152", "MATH& 153", "MATH& 254"
        };

        public string[] BioCourseCodes = { "All" };
        public string[] ChemCourseCodes = { "All" };
        public string[] PhysicsCourseCodes = { "All" };
        public string[] CompSciCourseCodes = { "All" };
        public string[] BusAccCourseCodes = { "All" };

        public static string[] GetCourses(string filter)
        {
            string[] courses = null;
            switch (filter)
            {
                case "Math":
                    courses = new Filter().MathCourseCodes;
                    break;
                case "Biology":
                    // set courses to bio property
                    break;
                case "Chemistry":
                    // set courses to chem property
                    break;
                case "Physics":
                    // set courses to physics property
                    break;
                case "Computer Science":
                    // set courses to comp/sci property
                    break;
                case "Business Math/Accounting":
                    // set courses to bus/acc property
                    break;
                default:
                    // set courses to all
                    break;
            }
            return courses;
        }
    }
}

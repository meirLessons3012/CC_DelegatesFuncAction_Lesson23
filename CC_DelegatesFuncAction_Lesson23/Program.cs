namespace CC_DelegatesFuncAction_Lesson23
{

    public class Program
    {
        public PrintMessageDelegate methodReturnVoidAndGetString;
        public MethodReturnIntAcceptNoParams methodReturnIntAcceptNoParams;
        public Program()
        {


            methodReturnVoidAndGetString = PrintMessage;
            methodReturnIntAcceptNoParams = GetHour;
            // best way:
            methodReturnVoidAndGetString.Invoke("first invoke...");

            methodReturnVoidAndGetString("second invoke...");
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Student s1 = new Student
            {
                Id = 12123,
                Name = "Harel",
                Grade = 100
            };
            Student s2 = new Student
            {
                Id = 245234,
                Name = "Dana",
                Grade = 85
            };
            Student s3 = new Student
            {
                Id = 124124,
                Name = "Tsur",
                Grade = 25
            };
            Student s4 = new Student
            {
                Id = 23412,
                Name = "Yanai",
                Grade = 75
            };
            MyClassRoom mcr = new MyClassRoom();
            mcr.Students = new List<Student>();
            mcr.Students.Add(s1);
            mcr.Students.Add(s2);
            mcr.Students.Add(s3);
            StudentChecker sc = new StudentChecker();
            bool checkById = mcr.CheckIfStudnetExist(sc.CheckStduentById, s1);
            bool checkByName = mcr.CheckIfStudnetExist(sc.CheckStduentByName, s3);
            bool checkByGrade = mcr.CheckIfStudnetExist(sc.CheckStduentByGrade, s4);



            string input = "address";
            MethodReturnStringAndAcceptLong DetailMethod = GetPersonDetails(input);
            string res = DetailMethod?.Invoke(51243124);
            Console.WriteLine(res);
            Calculator c = new Calculator();
            MessagesControler msgCntrlr = new MessagesControler();

            c.onGetResult = msgCntrlr.PrintMessageInConsoleAndDebug;
            MethodReturnIntAcceptTwoInts calcMethod = c.GetCalcMethod("-");
            calcMethod += c.GetCalcMethod("/");
            calcMethod += c.GetCalcMethod("*");
            int? res1 = calcMethod?.Invoke(14, 2);//res = to last method in invocation list

            c.onGetResult = msgCntrlr.PrintMessage;
            c.calcOpeartion.Invoke(13, 26);
            c.onGetResult = msgCntrlr.PrintMessageInConsoleAndDebug;
            c.calcOpeartion.Invoke(2, 53);


            foreach (var del in c.calcOpeartion.GetInvocationList())
            {
                MessageBox.Show(del.Method.ToString());
                MessageBox.Show(del.Method.Name);
                MessageBox.Show(del.Method.ReturnType.ToString());
            }

            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message); 
        }

        public static void ValidateString(string value)
        {
            if(value == null)
            Console.WriteLine("value is null");
            if (value == "")
                Console.WriteLine("value is empty");
        }

        public int GetHour()
        {
            return DateTime.Now.Hour;
        }

        static MethodReturnStringAndAcceptLong GetPersonDetails(string detail)//פונקציה המחזירה מופע מהדלגאט
        {
            switch (detail.ToLower())
            {
                case "firstname": 
                    return GetFirstName;
                case "lastname": 
                    return GetLastName;
                case "address": 
                    return GetAddress;
                default: return null;
            }
        }

        static string GetFirstName(long id)
        {
            //GetDetilsById()...
            return "Niso";
        }

        static string StamFunction(long id)
        {
            //GetDetilsById()...
            return "Niso";
        }
        static string GetLastName(long id)
        {
            //GetDetilsById()...
            return "Halevi";
        }
        static string GetAddress(long id)
        {
            //GetDetilsById()...
            return "Hamaapilim 6 Haifa.";
        }




    }
}
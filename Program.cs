using System;

namespace OOPTask3A
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillMore = false;
            do
            {
                Console.Write("First name: ");
                string firstname = Console.ReadLine();
                Console.Write("Family name: ");
                string familyname = Console.ReadLine();
                Console.Write("Birthday: ");
                string isThisValid = Console.ReadLine();
                DateTime dateofbirth;
                while(!DateTime.TryParse(isThisValid, out dateofbirth) || 
                    dateofbirth<=new DateTime(1900,1,1))
                {
                    Console.Write("Not valid, try again: ");
                    isThisValid = Console.ReadLine();
                }
                //Now you have it all!!!
                //Create the object of type Student
                Student student = new Student(firstname, familyname, dateofbirth);

                // this may not work immediatly...
                Console.WriteLine(student);
                //Console.WriteLine("First name: "+student.FirstName);


                Console.Write("More of this Y/N?: ");
                string youDecided = Console.ReadLine().ToUpper();
                if (youDecided.StartsWith("Y"))
                    stillMore = true;
                else
                    stillMore = false;
            }while(stillMore);
        }
    }
}

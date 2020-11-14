using System;

namespace Day5_PersonExt
{

    public static class PersonExt
    {
        public static string Name { get; set; }
        public static int? Age { get; set; }

        // Extention method
        public static string ValidateExt(this Person p)
        {

            string val;
            if (!string.IsNullOrWhiteSpace(Name) && Age != 0)
                val = "Correct";
            else
                val = "Incorrect";

            return val;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            //string Name = "Иван";
            //int? Age = 25;
            //Person p = new Person( Name,  Age);

            //можно так var p = new Person();
 /*           Person p = new Person();

            p.Name = "Иван";
            p.Age = 25;
            var res = p.Validate(p);
            Console.WriteLine($"{res}");*/

              Person p = new Person();
            PersonExt.Name = "Иван";
            PersonExt.Age = 25;
            string res = p.ValidateExt(); // вызов Extention
            Console.WriteLine($"{res}");
        }
    }
}

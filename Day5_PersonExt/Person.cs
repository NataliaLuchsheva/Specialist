using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_PersonExt
{
   
        // работает
        public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        //public Person(string Name, int? Age)
        //{
        //    this.Name = Name;
        //    this.Age = Age;
        //}


        public string Validate(Person p) 
        {

            string val;
            if (!string.IsNullOrWhiteSpace(Name) && Age != 0)
                val = "Correct";
            else
                val = "Incorrect";

            return val;
        }

    }

}

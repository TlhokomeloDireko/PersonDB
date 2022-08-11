using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB.BL.Classes
{
    public class Person
    {
        [Key] public string ID { get; set; }// end property
        public int Age { get; set; }// end property
        public string FirstName { get; set; }// end property
        public string LastName { get; set; }// end property

        public Person(string ID, int Age, string FirstName, string LastName)
        {
            this.ID = ID;
            this.Age = Age;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }// end contructor

        public Person()
        {

        }// end constructor

        public override string ToString()
        {
            return $"{ID} : {FirstName} {LastName} ({Age})";
        }// end method
    }// end class
}// end namespace

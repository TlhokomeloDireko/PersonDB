using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB.BL.Classes
{
    public class Persons : CollectionBase
    {
        public void Add(Person newPerson)
        {
            List.Add(newPerson);
        }// end method
        
        public void Remove(Person existingPerson)
        {
            List.Remove(existingPerson);
        }// end method

        public Person this[int personIndex]
        {
            get
            {
                return (Person)List[personIndex];
            }// end get
            set
            {
                List[personIndex] = value;
            }// end set
        }// end indexer
    }// end class
}// end namespace

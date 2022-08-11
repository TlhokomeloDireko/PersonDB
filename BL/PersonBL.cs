using PersonDB.BL.Classes;
using PersonDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDB.BL
{
    public class PersonBL
    {
        private ProviderBase providerBase;

        public PersonBL(string Provider)
        {
            //
            //Method Name     : PersonBL(string Provider)
            //Purpose         : Overloaded constructor; invoke setupProviderBase to setup
            //                  data provider
            //Re-use          : setupProviderBase()
            //Input Parameter : string Provider
            //                  - The name of the data provider to use
            //Output Type     : None
            //
            setupProviderBase(Provider);
        } // end method

        /// <summary>
        /// This method gets the list of all the business objects from the Person datastore.
        /// It returns the list of business objects
        /// </summary>
        public Persons SelectAll()
        {
            return providerBase.SelectAll();
        } // end method

        /// <summary>
        /// This method gets a single Person object from the Person datastore.
        /// It returns 0 to indicate the Person was loaded from the datastore, or
        /// -1 to indicate that no Person was loaded from the datastore.
        /// </summary>
        /// <param name="ID">The Person ID of the Person to load from the datastore.</param>
        /// <param name="person">The Person object loaded from the datastore.</param>
        public int SelectPerson(string ID, ref Person person)
        {
            return providerBase.SelectPerson(ID, ref person);
        } // end method

        /// <summary>
        /// This method inserts a record in the Person datastore.
        /// It returns 0 to indicate the Person was inserted into datastore, or
        /// -1 to indicate the Person was not inserted because a duplicate was found
        /// </summary>
        /// <param name="newPerson">The Person object to add to the Person datastore.</param>
        public int Insert(Person newPerson)
        {
            return providerBase.Insert(newPerson);
        } // end method

        /// <summary>
        /// This method updates a record in the Person datastore.
        /// It returns 0 to indicate the Person was found and updated successfully, or
        /// -1 to indicate the Person was not updated because the record was not found
        /// </summary>
        /// <param name="existingPerson">The new Person data for the record in the Person
        /// datastore.</param>
        public int Update(Person existingPerson)
        {
            return providerBase.Update(existingPerson);
        } // end method

        /// <summary>
        /// This method deletes a record in the Person datastore.
        /// It returns 0 to indicate the Person was found and deleted successfully, or
        /// -1 to indicate the Person was not deleted because the record was not found
        /// </summary>
        /// <param name="ID">The Person ID of the Person to delete in the Person datastore.</param>
        public int Delete(string ID)
        {
            return providerBase.Delete(ID);
        } // end method

        private void setupProviderBase(string Provider)
        {
            //
            //Method Name     : void setupProviderBase()
            //Purpose         : Helper method to select the correct data provider
            //Re-use          : None
            //Input Parameter : string Provider
            //                  - The name of the data provider to use
            //Output Type     : None
            //
            if (Provider == "XMLProvider")
            {
                //providerBase = new XMLProvider();
            } // end if
            else
            {
                if(Provider == "SQLiteProvider")
                {
                    providerBase = new SQLiteProvider();
                } // end if
                else
                {
                    if (Provider == "MySQLProvider")
                    {
                        //providerBase = new MySQLProvider();
                    } // end if
                }// end else
            }// end else
        }// end method
    }// end Class
}// end namespace

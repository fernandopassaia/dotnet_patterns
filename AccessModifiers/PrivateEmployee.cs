
namespace AccessModifiers
{
    //Private access is the least permissive access level.Private members are accessible only within the body of the class or the struct in which they are declared.
    //They will be available only on the same Assembly. When you don't declare nothing (like "class Employee") - private will be the default, always, in C#. When you
    //declare a private class, the properties should be access just by "getters ans setters" methods (you can use public properties, but make no sense...).

    class PrivateEmployee
    {
        private string NameOnPrivateEmployee { get; set; }
        private string AddressOnPrivateEmployee { get; set; }

        //on private stuff I'll need getters and setters methods (or better than that, a constructor my friend
        public string getNameOnPrivateEmployee()
        {
            return this.NameOnPrivateEmployee;
        }

        public void setNameOnPrivateEmployee(string value)
        {
            this.NameOnPrivateEmployee = value;
        }

        public string getAddressOnPrivateEmployee()
        {
            return this.AddressOnPrivateEmployee;
        }

        public void setAddressOnPrivateEmployee(string value)
        {
            this.AddressOnPrivateEmployee = value;
        }

        public override string ToString()
        {
            return string.Format("PrivateEmployee: {0}, {1}", NameOnPrivateEmployee, AddressOnPrivateEmployee);
            // Where Nome, Cognome and Number are variables in Persona class
        }
    }
}

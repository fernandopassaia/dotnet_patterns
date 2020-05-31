using System;

namespace AccessModifiers
{
    //public: The public keyword is an access modifier for types and type members. Public access is the most permissive access level.
    //There are no restrictions on accessing public member. Don't need getters and setters to access the members.
    public class PublicEmployee
    {        
        public string name;
        public string address;
        PrivateEmployee privateEmployee;

        public PublicEmployee()
        {
            privateEmployee = new PrivateEmployee();
            //to access the members of a Private Classes, i should build public set and public get methods on the Private Class
            //privateEmployee.name = "Private classes can be access just from the same Assembly";
            //privateEmployee.address = "Private classes can be access just from the same Assembly";

            privateEmployee.setNameOnPrivateEmployee("PrivateName");
            privateEmployee.setAddressOnPrivateEmployee("PrivateAddress");            
        }

        public override string ToString()
        {            
            return string.Format("PublicEmployee: {0}, {1}, {2}", name, address, privateEmployee.ToString());            
        }
    }
}

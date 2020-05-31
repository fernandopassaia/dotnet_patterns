using AccessModifiers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //public: The public keyword is an access modifier for types and type members. Public access is the most permissive access level.
            //There are no restrictions on accessing public member. Don't need getters and setters to access the members.
            PublicEmployee publicEmployee = new PublicEmployee();
            publicEmployee.address = "Aradi Utca";
            publicEmployee.name = "Fernando Passaia";

            //Can't access PrivateEmployee because it's accessible just inside the same assembly (dll)
            //PrivateEmployee privateEmployee = new AccessModifiers.PrivateEmployee();

            //Can't access InternalEmployee because it's accessible just inside the same assembly (dll)
            //InternalEmployee internalEmployee = new AccessModifiers.InternalEmployee();

            System.Console.WriteLine(publicEmployee.ToString());
            System.Console.ReadKey();

        }

        //aux method to receive a object (that will be a class) and return a PropertyInfo[] with all it's propertys and fields (to be print on the screen)
       

    }
}

## C# Questions/Principles Review:

### OOP:
**(1) How to prevent a class from being inherited?**
Using the "sealed" keyword. This is how you can prevent it from inheritance.

**(2) Difference between Classes and Objects**
Class is the DEFINITION of a object. It's a template of the object that describes all methods, properties. OBJECT is a instance of a classes, that needs to be instancied, and it's used to access all the properties from a class.

**(3) What Are the Different Constructors in C#**
Default, Parameterized, Copy, Static, Private.

Default: with no parameters. Should initialize numeric fields with 0, strings and classes to null.
Parameterized: the one that will receive at least one parameter and initialize something with it.
Copy: This constructor initialize variables from copying data from another object. Create a new instance with values from a existing instance.
Static: will inicialize data on the class only once. User has no control and it have no parameter as well.
Private: It's impossible to create a instance of the class.

**(4) Difference Between Abstract class and Interface**
Abstract class contains a partial implementation for a functionality that must be implemented by the inheriting entities - but yeah, abstract can have methods and implementations. An abstract class declares fields too. An INTERFACE declares a contract that the implementing classes should have - may declare properties, methods and events with no access modifiers. All methods of a Interface are public, on partial we can have private methods.

**(5) Difference access modifiers of a class in C#**

**public**: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
**protected**: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
**internal**: The type or member can be accessed by any code in the same assembly, but not from another assembly.
**protected internal**: The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly. (as in protected OR internal)
**private**: The type or member can be accessed only by code in the same class or struct.
**private protected**: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class. (as in private OR protected)

                                      public 	protected 	internal 	protected internal 	private 	private protected
Entire program 	                        Yes 	    No 	        No 	        No 	                No 	        No
Containing class 	                    Yes 	    Yes 	    Yes 	    Yes 	            Yes 	    Yes
Current assembly 	                    Yes 	    No 	        Yes 	    Yes 	            No 	        No
Derived types 	                        Yes 	    Yes 	    No 	        Yes 	            No      	No
Derived types within current assembly 	Yes 	    Yes 	    No 	        Yes 	            No 	        Yes

**Another Modifiers that could be mixed with those below**:
**Static**: A Static Class cannot be instantiated. You just need to use the classname itselft to accees it.
**Sealed**: We create it when we don't want the class to be inherited by others. We Prevent it to be derivated.
**Partial**: You can "brake" your class info multiple files, and they will be compiled as "one" in compilation time. So you can create a lot of different files with name "geeks1.cs, geeks2.cs, geeks3.cs", first class can contains only properties, second and tirth containing methods and properties, once all of them starts with "public partial class Geeks" - the builder will understand it and compile as one.
**Abstract**: Abstract classes cannot be instantied (cannot use "new"). It's designed to be inherited by subclasses that either implement or override its methods. Abstracts classes are either implemented or not at all. Abstract classes can have constructor (this is one of the major difference between interfaces). You can take advantage of abstract classes to design components and some level of common functionality that must be implemented by derived classes.

Example of Internal Classes or Modifiers:
public class MyHelper
{
    internal string InternalMethod()
    {
        return "should only be visible to the class itself & tests";
    }
 
    public string PublicMethod()
    {
        return "Everyone can call this method";
    }
 
    private string PrivateMethod()
    {
        return "you should not be able to call this directly";
    }
}

If you instanciate this class, the only method you will see is the "PublicMethod()". But for example, if you need to TEST this helper, for sure your TEST project needs to see all the methods. To allow it, you should (1) set "InternasVisibleTo" in you AssemblyInfo.cs. Example: [assembly: InternalsVisibleTo("Logic.Tests")]. In .NET Core you don't have AssemblyInfo, so you need to update your .csproj by adding:

<ItemGroup>
  <AssemblyAttribute Include="System.Runtime.CompilerServices.InternalsVisibleTo">
    <_Parameter1>Logic.Tests</_Parameter1>
  </AssemblyAttribute>
</ItemGroup>

**(6) Encapsulation and Abstractionm, Inheritance, Polymorphism (difference)**
Abstraction is used to map the entities on the real world, understanding it reasons, caracteristics and actions. Abstraction is about to hide the complexity and provide set of interfaces to consume the funcionality. A Method is a good example of abstraction: When we call a method, we never knows the logic behind it, we know just how to call it, but not how it works inside. For example: If i want to call someone, i know how i can do it and where i need to go, but i don't know how it works inside, between the mobilephone and the operator.

Entity: Car. Properties: Size, Color, Height, Weight. Actions: Accelerate, stop, start, ends (engineOn).
Entity: Elevator. Properties: Size, MaxWeight. Actions: GoUp, GoDown, ChooseFloor.
Entity: BankAccount. Properties: Value, Limit, Number. Actions: Deposit, WithDraw, GetExtract.

Encapsulation is the techinique used to hide an idea, to not expose to user it details. So: You try to hide all the internal things of a class from other developers, and only offer them a subset of funcionality to use. You can achieve this by setting an appropriate acces modifier, for example: In a process of Encapsulation, the atributes of class should be set as PRIVATE, and to access these modifiers is necessary to create setters and getters methods.

In Inheritance, a class can get attributes from another class. The great gain is on the Reutilization of Code. For example:
Manager, Secretary, Techinical, different kind of professionals can make Inheritance of a "super class" called Employee.
To make inheritance you need to use the keyword EXTENDS on C#.

Inheritance is the ability to create a classe from another class, extending the functionality and state of the parent in the derived (or child). In "simple way" we can say that parent child between classes is inheritance. It allows derived classes to overload methods (polymorphism) from their parent classes.

Polymorphism: Polimorphism means that one name can have many forms. One object behaving as multiple forms, one function behaves in different forms. For example: A Object of type "Fernando" at the company will be an Employee. But when he arrives at home, now he's a husband, a father. It will change it's behavior according to conditions. So in other words, Many Forms of a single object is called polimorphism. We can have Polimorphism in two situations:

Method overloading and Method Overriding (now with examples became easier, huh?)

**(7) Polymorphism (Static and Dynamic)**
On the Polymophism static the decision about witch method will be called is made in compilation time. The Dynamic, this decision is made during the execution time.

**(8) Difference between Structs and Classes**
Structs are ValueType variables and will be saved in the stack, meanwhile classes are ReferenceType and will be stored on the heap. Structs cannot be inherited.

**(9) Difference Between Overriding and OverLoading**
Overriding is when you "rewrite" a Method that came from a class that you make herance. Overloading is when you have differente constructors/parameters for methods with same names.

### LISTS:
**(10) Difference Between IEnumerable and IEnumerator**
IEnumerable and IEnumerator is very similar and work basically the same. But IEnumerator is more complex to deal, once you have to call "MoveNext()" method to walk thought the list. IEnumerable is most simple, has a simplier and shorter syntax. Let's Create a List<string> of months, and then load an IEnumerable and IEnumerator, to show how IEnumerable is most simple to use.

   List<string> Month = new List<string>();  
   Month.Add("January");  
   Month.Add("February");  
   Month.Add("March");  
   Month.Add("April");  
   Month.Add("May");  
   Month.Add("June");  
   Month.Add("July");  
   Month.Add("August");  
   Month.Add("September");  
   Month.Add("October");  
   Month.Add("November");  
   Month.Add("December");   

   //create IEnumerable of string 
   IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;      
   //If we want to retrieve all the items from this IEnumerable object, we can use a foreach loop. 
   foreach(string AllMonths in iEnumerableOfString)
   {  
    Console.WriteLine(AllMonths);  
   }  

    //Create IEnumerator of string. 
    IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();//to convert list into IEnumerator we can invoke the GetEnumerator method      
    //To retrieve all the items from the above IEnumerator object, we cannot use foreach loop instead of that we need to invoke MoveNext() Boolean method.  
    while(iEnumeratorOfString.MoveNext())
    {  
        //as you can see, iEnumerator is more complex, you have to invoke moveNext
    }  


**(11) When to use IDictionary, Hashtable, IEnumerable x IList x IQueryable**
**IDictionary** could be use to store a simple relationship, a key/value pair collection. For example:

        IDictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "Facebook");
        dic.Add(2, "Orkut");
        dic.Add(3, "Twitter");
        Console.WriteLine(dic[1]);
        Console.WriteLine(dic[2]);
        Console.WriteLine(dic[3]);
        Console.ReadLine();

The Values in Dictionary is stored as values, so they do not need to be Box/Unboxing.

**Hashtable**: Hashtable is very similar to Dictionary, but here you have the values stored as OBJECTS and you need to do Boxing and Unboxing.

**IQueryable** is a specific interface that contains a provedor of query, like LINQ-TO-SQL. It's a special object, where you can use filters and apply queries. IQueryable makes inheritance of IEnumerable, so basically everything IEnumerable can do, IQueryable also can.


Now the most complex question: **IEnumrable x IList**

**IEnumerable**: First important thing to have in mind, is that IEnumerable don't allow updates on the collection. It's Readonly, and you don't have any information about the collection, but just the necessary to run over it (foreach). Another thing is that you cannot have access to random positions, so with a IEnumerable, you cannot do: var position = IEnumerable[i]. It's a readonly simple collection of registrys. If we can say a "gross" and "simple" definition, let's say that IEnumerable allow us to interact the list (foreach), but if you want more options, like add items, remove, order, count, you should use something more specific, like List.

**List**: First thing here is that you can Add, Update and Remove items from a List. So the List is not readonly, but contains methods and can be manipulated. List also have another methods, like .Count(), .Any(). 

**Important concept**: Another important concept to have in mind, is that IEnumerable is LAZY Loading. So IEnumerable don't contains the data in true, it just will be loaded when we need then (on demand). List (or ToList()) will LOAD all the data need into the List, because of it Lists know how to Count(), if have Any(), list can add items, remove, get by position and lot of other methods.

**(12) What is LINQ**
Linq is a set of features that extend query capabilities to the .NET framework language that allows data manipulation irrespective of the data source. Linq bridges the gap between the world of objects and the world of data. You can use it with Xml, DataBases and Collections.

### VARIABLES: 
**(13) Ref x Out Parameter**
Both are parameters passed by REFERENCE, not by "value" like commons parameters. They are very similar, difference of "ref" and "out", is that REF parameters should be initialized BEFORE it's passed to the method.

If you pass a parameter by value, what happens to the parameter inside the method, will NOT reflect to the passed parameter. When you pass it by Referente, what happens inside a method, will AFFECT the original parameter. So again: When you pass by Reference, the changes made to the argument in the method will REFLECT in the variable when it returns to the calling method.

**(14) Constant and Readonly**
Constants support ValueType variables. Cannot be initialized in a constructor or declaration. 
ReadOnly variables can hold ReferenceType variables. Can be initialized in a constructor or declaration.

**(15) Var and Dynamic**
When we define a variable as VAR, we cannot change it type after the first initialization. A variable Dynamic can have it's type changed after first initialization.

**(16) Differente between AS and IS**
Is is a operator used to check the compatibility of a object with a given type. "as" operator is used for casting a object to a type or a class.

**(17) Boxing and Unboxing - Type of Value and Types of Reference**
Everything on .Net Platform is a OBJECT, so we can say that ALL the types on the platform derivates from System.Object. So basically if we want to do an OPERATION like 1 + 2, we will need 3 Objects, one to allocate 1, a second to allocate 2, and a thirt to put the result in. This is a big complex solution. To avoid all this problem, Java solve this questions by creatint primitive types (int, char, boolean, byte). Because they are primitive types, they don't have methods, they just allocate values in memory. The New Versions of Java also addopt Box and Unboxing as solution.

And How C# solves this question? Types of Reference, and Type of Values.

ValueTypes are the primitive types that will be stored on the stack (a variable that will be structured on memory to contains a direct value). So basically ValueTypes will be stored right to the memory. Example: Byte, Integer, Single, Double, Decimal, Float, Uint, ULong, Boolean, Char, Struct, Enum and etc... This most primitive type are references of "System.ValueType" and don't contains methods, are the most primitive types.

ReferenceTypes are stored on the heap. A ReferenceType doesn't store it's value directly, instead, stores the address where the value is being store: a reference type contains a pointer to another memory location that holds the data. All "Classes" that we create, all the "new" and instances, are ReferenceType. ReferenceTypes are derivated from System.Object. Example: String, All Arrays (even if their elements are value types), Class, Delegates.

Boxing is the Conversion of a ValueType to a ReferenceType. Unboxing is the conversion back of ReferenceType to ValueType.
Boxing occurs when you convert a Int to a Object, for example. Unboxing is the opositive, the process of converting a Object to a Primitive ValueType.

Exempla of boxing:
int i = 10;
object o = i; //boxing - a conversion of valuetype (integer) to object
double d = (double)(int)o; //unboxing a object o (of type int) to a double

Example of Unboxing:
object o = 10;
int i = (int)o; //you're unboxing an object to a integer

OR
int y = Convert.ToInt32(o); //this is also unboxing

**(18) Whats the difference between a Stack and a Heap?**
Stack store ValueTypes, and Heap stores ReferenceTypes (read under). Stack is more faster because will store primitive types, and Heap is more slower, but has capabilities to deal with more complex types like object or data.

**(19) Difference between String and StringBuilder**
The First one is that with StringBuilder you can use Append method (like i did in the past) to organize better the code, you can store queries and everthing else. But there are more than this that you need to catch:

Strings are immutable. So basically you cannot modify a value of a string, and everytime you did it, C# will always create a New Object with TypeString in memory. Example:
string str = "Hello";
str += "Hello?";
str += "How are you?".

It will creates 3 strings on memory. StringBuilder is mutable, so here i can perform insert, replace, apprend without creating new instances for everytime, it will update the space in memory without creating new spaces.

**(20) What is a Delegate in C#?**
Delegate is similar to the pointer to functions in C / C++ languages. A delegate allow you to make reference to a method, that will be defined in execution time. You don't have to define witch method will be called in compilation time, it could be make dynamic in execution time. You have flexibility to define any funcionality in execution time. 

Advantages: Encapsulating the methods call from caller, effective use improves the performance of application, and it's used to call method assincronously.
A construction of a Delegate:

Delegate int SampleOfDelegate(string name, bool b);

(this delegate returns a integer, and receive a string and a boolean). Example calling it:

namespace Macoratti.SimplesDelegate
{
    // Declaração
    public delegate void SimplesDelegate();

    class ExemploDeDelegate 
    {
        public static void minhaFuncao()
        {
            Console.WriteLine("Eu fui chamada por um delegate ...");
        }

        public static void Main()
        {
            // Instanciação
            SimplesDelegate simplesDelegate = new SimplesDelegate(minhaFuncao);

            // Invocação
            simplesDelegate();
            Console.ReadKey();
        }
    }
}

**(21) Difference between Dispose() and Finalize()**
Dispose is called when we want an object to release any unmanaged resources with them. OtherHand, Finalize() is used for the same purpose, but it doens't assure the garbage collection of an object. So Dispose is more accertive and will force the GB.

### THEORICAL PART:
**(22) What is .Net Framework?**
A Platform to build object-oriented applications multiplatform. It supports languages like C#, VB, Cobol, Perl, etc. It has a wide variety of tools and functionalities like class, library, APIs that can be used to build, deploy and run web servicies and different applications.

**(23) Explain the different components of the .NET platform and how it works:**
C# Programs don't run right on the Operational System, but, in a Virtual Machine, likes Java. So the Programs made in C# will not affect the operational system, or even the other applications, making it more stable and safe.


Common Intermediate Language (CIL) (or MSIL - Microsoft Intermediate Language):
Because the CLR should works with lot of different languages (C#, VB...) - CLR needs a common "intermediate" language to all the languages of .NET. This is a compiler that will get the C# code (or other language) and turns to CLR. It's the "csc.exe" (the compiler) that will generate CLR. The Compiler will "transform" the CLI to CRL. All the .NET codes are first compiled to Microsoft intermediate language.

Common Language Runtime (CLR)
CLR is the execution envoirnment for all .NET languages. It's responsible to manage memory, threads, GC and everything. Is the most vital part. It's the layer between the Operating System and your APP, that handles the execution of the .Net Applications. Our Apps do not speaks right to the Operational System, but through the CLR. CLR will also manage memory, load assemblies used in the assembly, manage garbage collector and more. See below how a .Net Program is executed to understand the work of CLR.

Just in Time (JIT):
To Run the C# Application, we need to convert the CIL to CLR, the virtual machine of C#. The CLR needs to be executed into the Operational System of the user, and do to it, needs to generate machine-code to the operational system where the program will be executed. CLR instead of "interpretate" the CLI code (that will be slow) - compile its to machinecode using a CLR internal JIT (just in time) compiler. So basically: CLR will generate machine-code and allocate the whole program on memory, making C# run faster as any other language.

**So basically to Execute a .Net Program we have this architecture (note that program will be compiled 2 times)**
(1) Your C#/VB code (or other) needs to be compiled to CIL, using csc.exe or another compiler (like dotnet, on .net core).
(2) When you Run the Program and Open It, CLR will get this CIL and pass into a JIT compiler to generate machine-code.

Framework Class Library (FCL):
Here we are: The Main Librarys, Packages and APIs of .Net Platform, the ones you'll see on Visual Studio, and you will use to develop your program. Entrance to Windows Api, string manipulation, common data structures, IO, streams, threads, security, windows-web-networking programming, data access and go on.

Base Class Library (BCL):
The Base Class Library BCL is literally the basic, fundamental types like System.String, System.DateTime...

Common Type System (CTS):
Is the Types that is a common for any language. Let's imagine that you have an integer, or a string. This should be the SAME, with same bytes in C# or VB. Using this principle, you don't have to worry about converting types when you integrate C# and VB code. We can even make our own classes and functions with the rules in CTS, it helps in calling the data type declared in one program language by other programming language.

Common Language Specification (CLS):
Common language specification help the developers to use the components that are inter-language compatible with certain rules. It helps in reusing the code in other .Net compatible language. Express all .NET Consistent dialects can make utilization of CLR and FCL. It's the specification and determination of every dialect a language should meet to qualify as a .NET Compliant Language. 

Assembly:
It's the group of all code in a logical file, your .EXE or DLL.

Garbagy Collector (GC):
CLR contains the GC that will keeps your app running in low-need and check for unferenced poerfully dispensed memory space. It basically discovers some information that is not referenced anymore, and re-claim it spaces to returns the ilvolved memory back to OS. The main point is to liberates the software enginners from monitoring dangling information.

Profiling:
We can use to improve memory usage and program performance ajusting specific details.

**(24) Difference between Managed and Unmamaged Code**
All the Code of .Net Platform is MANAGED code. .NET Framework is necessary to execute managed code, and managed code is managed by CLR, that will make memory management, garbage collection and so on... Unmanaged code is that independent of .Net Framework, not managed by CLR. Remember some times when you have to integrate to 3th Dlls components (like Daruma, Bematech) or even call right System32.dll.

**(25) What is the different parts of an Assembly**
Manifest (information about the assembly). Type Metadata (binary information of the program). MSIL (Microsoft intermediate language) and the Resources (files, images).

**(26) Difference between DLL and EXE?**
An EXE cannot be shared with other applications, and can run right and directly the applications. All the assemblies will be LOAD when we run the EXE. DLL otherwise, consists of code that needs to be hide. The code is encapsulated in this library, and can be shared with other N applications.

### MultiParallel Programming - Task, Async, Await**
**(27) ASYNC and AWAIT Review**:
In "general" words, you should use async when you have IO operations, and you want to increase the performance and scability of your app. In the Sincronous programming you will have an ORDER and the things will happen in the order you defined. In Assincronous programming you will allow your application to do lot of things at same time, without blocking or waiting for other operations.

In the Development of Desktop, ClientSide, like WindowsForms, Mobile or FrontEnd Web the most benefit of async is to keep the UI responsible meanwhile operations are being executed in background. In BackEnd Development, the principal reason to use Async is scability.

The Main Reason to CHOOSE between use async or not, should be the I/O operations, when you have to read a file, read a large amount of data on database, something that will "take time". If your operation makes uses of just CPU for example, use async is a BAD choice because will create a unecessary overhead in the processor.

Another thing to take care: If you have a problem in your database, a performance problem, async will not help and can make it worst, depending on scenario. Server will get more requests at the same time and overload too much more the database - you have to fix your database performance problems, and in this case, async will not solve it.

Now Let's explain how it works on IIS:

Syncronous Process: When IIS receives a Request, it takes a Thread in the Thread Pool and put this request. So IIS will process this request using this Thread, do all the process (including database operations, I/O, anything else) until the process is over, giving an answer to the user. Now let's imagine that you have a DataBase Operation that will take 8 seconds to Run: The Thread will get stuck waiting for database.

 The problem is: If you have a LOT of requests, if there's not Thread in the Thread Pool, IIS will put the request into Queue to wait for a chance to get a thread to process it... Depending on time, Request will give user a 503 (Service Unavailable) to the user.

Asyncronous Process: Now looking for the Syncronous Process and the problem there (Thread will have to wait 8 seconds the operation on database finish) - Async comes to solve it. When you use Async, Windows/IIS will put the Operation in a TASK, and will run it in a Parallel processing. The Thread will RETURN to IIS Thread Pool, and will be available to IIS. So Basically what happens is that during this 8 seconds of database processing, the Thread will be available on the Pool, to receive more and more Requests. Basically you will have more "scability" and you will attempt to more and more requests at the same time, with the same number of Threads.

When the Async method finish (so the 8 seconds to DataBase response an operations): Windows will notify the Runtime/IIS and the continuing of the Task will be schedelue on the Thread Pool. So basically IIS will get an available Thread, and put the Request Again to Run, to Finish it and Answer the HTTP Requests. Look for Bruno Brito Article to see Graphics and Understand Perfectly how it works. (Also saved on Async Folder).

**Note**: When you use the keyword "async", the compilator will generate a "status-machine" (called TAP) on background. It's an extra code, so you have to take it in mind, you'll have an "small aditional" processor cost on it, so have in mind that your should use it when it needs. Don't use async in everything... If your operation depends on CPU operations for example (not I/O), don't use async operations, you can loose performance and async could be a problem instead of solution. Same thing for DataBase problems: Performance problems on your database will NOT be solved by Async in BackEnd.


Fonts:
EXCELENT Article: https://www.brunobrito.net.br/asp-net-e-iis-anatomia-de-uma-aplicacao-web-parte-ii/ 


### WEB PARTS (old, more relative to classic AspNet WebForms):
**(28) What is caching?**  
Caching means storing the data temporarily in memory so the data can be access in a more efficiency and speed way.

**(29) What is Localization and Globalization?**
Localization means changing the already Globalized application to cater a specific language or culture. Globalization is the process of developing apps to suppor multi languages. One is opose other.

**(30) Different type of validators in Asp.Net?**
Client Side validation (normally JS) and ServerSide, that will runs on the backend.
----------------------------------------------------------------------------------------------------------------------------------------------------
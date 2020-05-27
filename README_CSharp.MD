### C# Questions/Principles Review:

**(1) What is .Net Framework?**
A Platform to build object-oriented applications multiplatform. It supports languages like C#, VB, Cobol, Perl, etc. It has a wide variety of tools and functionalities like class, library, APIs that can be used to build, deploy and run web servicies and different applications.

**(2) Explain the different components of the .NET platform and how it works:**
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

**(3) Difference between Managed and Unmamaged Code**
All the Code of .Net Platform is MANAGED code. .NET Framework is necessary to execute managed code, and managed code is managed by CLR, that will make memory management, garbage collection and so on... Unmanaged code is that independent of .Net Framework, not managed by CLR. Remember some times when you have to integrate to 3th Dlls components (like Daruma, Bematech) or even call right System32.dll.

**(4) Difference between Classes and Objects**
Class is the DEFINITION of a object. It's a template of the object that describes all methods, properties. OBJECT is a instance of a classes, that needs to be instancied, and it's used to access all the properties from a class.

**(5) Boxing and Unboxing - Type of Value and Types of Reference**
Everything on .Net Platform is a OBJECT, so we can say that ALL the types on the platform derivates from System.Object. So basically if we want to do an OPERATION like 1 + 2, we will need 3 Objects, one to allocate 1, a second to allocate 2, and a thirt to put the result in. This is a big complex solution. To avoid all this problem, Java solve this questions by creatint primitive types (int, char, boolean, byte). Because they are primitive types, they don't have methods, they just allocate values in memory. The New Versions of Java also addopt Box and Unboxing as solution.

And How C# solves this question? Types of Reference, and Type of Values.

ValueTypes are the primitive types that will be stored on the stack (a variable that will be structured on memory to contains a direct value). So basically ValueTypes will be stored right to the memory. Example: Byte, Integer, Single, Double, Decimal, Float, Uint, ULong, Boolean, Char, Struct, Enum and etc... This most primitive type are references of "System.ValueType" and don't contains methods, are the most primitive types.

ReferenceTypes are stored on the heap. A ReferenceType doesn't store it's value directly, instead, stores the address where the value is being store: a reference type contains a pointer to another memory location that holds the data. All "Classes" that we create, all the "new" and instances, are ReferenceType. ReferenceTypes are derivated from System.Object. Example: String, All Arrays (even if their elements are value types), Class, Delegates.

Boxing is the Conversion of a ValueType to a ReferenceType. Unboxing is the conversion back of ReferenceType to ValueType.

Exempla of boxing:
int i = 10;
object o = i; //boxing - a conversion of valuetype (integer) to object
double d = (double)(int)o; //unboxing a object o (of type int) to a double

Example of Unboxing:
object o = 10;
int i = (int)o; //you're unboxing an object to a integer

**(6) Difference between constants and readonly variables**
Constants support ValueType variables. Cannot be initialized in a constructor or declaration.
ReadOnly variables can hold ReferenceType variables. Can be initialized in a constructor or declaration.

**(7) What is LINQ**
Linq is a set of features that extend query capabilities to the .NET framework language that allows data manipulation irrespective of the data source. Linq bridges the gap between the world of objects and the world of data. You can use it with Xml, DataBases and Collections.

**(8) What is the different parts of an Assembly**
Manifest (information about the assembly). Type Metadata (binary information of the program). MSIL (Microsoft intermediate language) and the Resources (files, images).

**(9) How to prevent a class from being inherited?**
Using the "sealed" keyword. This is how you can prevent it from inheritance.

**(10) What Are the Different Constructors in C#**
Default, Parameterized, Copy, Static, Private.

Default: with no parameters. Should initialize numeric fields with 0, strings and classes to null.
Parameterized: the one that will receive at least one parameter and initialize something with it.
Copy: This constructor initialize variables from copying data from another object. Create a new instance with values from a existing instance.
Static: will inicialize data on the class only once. User has no control and it have no parameter as well.
Private: It's impossible to create a instance of the class.

**(11) How to prevent a class from being inherited?**
Using the "sealed" keyword. This is how you can prevent it from inheritance.

**(12) What is caching?**
Caching means storing the data temporarily in memory so the data can be access in a more efficiency and speed way.

**(13) What is Localization and Globalization?**
Localization means changing the already Globalized application to cater a specific language or culture. Globalization is the process of developing apps to suppor multi languages. One is opose other.

**(14) What is a Delegate in C#?**
Delegate is similar to the pointer to functions in C / C++ languages. A delegate allow you to make reference to a method, that will be defined in execution time. You don't have to define witch method will be called in compilation time, it could be make dynamic in execution time. You have flexibility to define any funcionality in execution time. A construction of a Delegate:

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

**(14) Difference Between Abstract class and Interface**
Abstract class contains a partial implementation for a functionality that must be implemented by the inheriting entities. An abstract class declares fields too. An INTERFACE declares a contract that the implementing classes should have - may declare properties, methods and events with no access modifiers.

**(15) Whats the difference between a Stack and a Heap?**
Stack store ValueTypes, and Heap stores ReferenceTypes (read under). Stack is more faster because will store primitive types, and Heap is more slower, but has capabilities to deal with more complex types like object or data.

**(16) Different type of validators in Asp.Net?**
Client Side validation (normally JS) and ServerSide, that will runs on the backend.

**(17) Difference between DLL and EXE?**
An EXE cannot be shared with other applications, and can run right and directly the applications. All the assemblies will be LOAD when we run the EXE. DLL otherwise, consists of code that needs to be hide. The code is encapsulated in this library, and can be shared with other N applications.

----------------------------------------------------------------------------------------------------------------------------------------------------

### ASYNC and AWAIT Review
In "general" words, you should use async when you have IO operations, and you want to increase the performance and scability of your app. In the Sincronous programming you will have an ORDER and the things will happen in the order you defined. In Assincronous programming you will allow your application to do lot of things at same time, without blocking or waiting for other operations.

In the Development of Desktop, ClientSide, like WindowsForms, Mobile or FrontEnd Web the most benefit of async is to keep the UI responsible meanwhile operations are being executed in background. In BackEnd Development, the principal reason to use Async is scability.

The Main Reason to CHOOSE between use async or not, should be the I/O operations, when you have to read a file, read a large amount of data on database, something that will "take time". If your operation makes uses of just CPU for example, use async is a BAD choice because will create a unecessary overhead in the processor.

Another thing to take care: If you have a problem in your database, a performance problem, async will not help and can make it worst, depending on scenario. Server will get more requests at the same time and overload too much more the database - you have to fix your database performance problems, and in this case, async will not solve it.

Now Let's explain how it works on IIS:

Syncronous Process: When IIS receives a Request, it takes a Thread in the Thread Pool and put this request. So IIS will process this request using this Thread, do all the process (including database operations, I/O, anything else) until the process is over, giving an answer to the user. Now let's imagine that you have a DataBase Operation that will take 8 seconds to Run: The Thread will get stuck waiting for database.

 The problem is: If you have a LOT of requests, if there's not Thread in the Thread Pool, IIS will put the request into Queue to wait for a chance to get a thread to process it... Depending on time, Request will give user a 503 (Service Unavailable) to the user.

Asyncronous Process: Now looking for the Syncronous Process and the problem there (Thread will have to wait 8 seconds the operation on database finish) - Async comes to solve it. When you use Async, Windows/IIS will put the Operation in a TASK, and will run it in a Parallel processing. The Thread will RETURN to IIS Thread Pool, and will be available to IIS. So Basically what happens is that during this 8 seconds of database processing, the Thread will be available on the Pool, to receive more and more Requests. Basically you will have more "scability" and you will attempt to more and more requests at the same time, with the same number of Threads.

When the Async method finish (so the 8 seconds to DataBase response an operations): Windows will notify the Runtime/IIS and the continuing of the Task will be schedelue on the Thread Pool. So basically IIS will get an available Thread, and put the Request Again to Run, to Finish it and Answer the HTTP Requests. Look for Bruno Brito Article to see Graphics and Understand Perfectly how it works. (Also saved on Async Folder).




Fonts:
EXCELENT Article: https://www.brunobrito.net.br/asp-net-e-iis-anatomia-de-uma-aplicacao-web-parte-ii/ 
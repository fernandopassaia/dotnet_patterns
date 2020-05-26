C# Questions/Principles Review:

**(1) What is .Net Framework?**
A Platform to build object-oriented applications multiplatform. It supports languages like C#, VB, Cobol, Perl, etc. It has a wide variety of tools and functionalities like class, library, APIs that can be used to build, deploy and run web servicies and different applications.

**(2) Explain the different components of the .NET platform and how it works:**
C# Programs don't run right on the Operational System, but, in a Virtual Machine, likes Java. So the Programs made in C# will not affect the operational system, or even the other applications, making it more stable and safe.


Common Intermediate Language (CIL) (or MSIL - Microsoft Intermediate Language):
Because the CLR should works with lot of different languages (C#, VB...) - CLR needs a common "intermediate" language to all the languages of .NET. This is a compiler that will get the C# code (or other language) and turns to CLR. It's the "csc.exe" (the compiler) that will generate CLR. The Compiler will "transform" the CLI to CRL.

Common Language Runtime (CLR)
CLR is the execution envoirnment for all .NET languages. It's responsible to manage memory, threads, GC and everything. Is the most vital part. It's the layer between the Operating System and your APP, that handles the execution of the .Net Applications. Our Apps do not speaks right to the Operational System, but through the CLR. CLR will also manage memory, load assemblies used in the assembly, manage garbage collector and more. See below how a .Net Program is executed to understand the work of CLR.

Just in Time (JIT):
To Run the C# Application, we need to convert the CIL to CLR, the virtual machine of C#. The CLR needs to be executed into the Operational System of the user, and do to it, needs to generate machine-code to the operational system where the program will be executed. CLR instead of "interpretate" the CLI code (that will be slow) - compile its to machinecode using a CLR internal JIT (just in time) compiler. So basically: CLR will generate machine-code and allocate the whole program on memory, making C# run faster as any other language.

**So basically to Execute a .Net Program we have this architecture (note that program will be compiled 2 times)**
(1) Your C#/VB code (or other) needs to be compiled to CIL, using csc.exe or another compiler (like dotnet, on .net core).
(2) When you Run the Program and Open It, CLR will get this CIL and pass into a JIT compiler to generate machine-code.

Framework Class Library (FCL):
Here we are: The Main Librarys, Packages and APIs of .Net Platform, the ones you'll see on Visual Studio, and you will use to develop your program. Entrance to Windows Api, string manipulation, common data structures, IO, streams, threads, security, windows-web-networking programming, data access and go on.

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
ValueTypes are the primitive types that will be stored on the stack (a variable that will be structured on memory to contains a direct value). Example: Byte, Integer, Single, Double, Boolean, Char, Struct, Enum and etc...

ReferenceTypes are stored on the heap. 


Boxing is the Conversion of a ValueType to a ReferenceType. Unboxing is the conversion back of ReferenceType to ValueType.

Exempla of boxing:
int i = 10;
object o = i; //boxing
double d = (double)(int)o; //unboxing a object o (of type int) to a double

Example of Unboxing:
object o = 10;
int i = (int)o; //you're unboxing an object to a integer





Type of Values store the value itself 




Types of 
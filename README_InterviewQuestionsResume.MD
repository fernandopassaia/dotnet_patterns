**1- How would you write async method and how would you call the async? What happens if you don't use the await?**
public Async Task<IActionResult> or public async Task<IEnumerable<Object>> and call with await.
If you don't use the "await", it will runs anyway, but if EXCEPTIONS happen, it will be lost. Always use await.

**2- What is the benefit of using intefaces in injections into the class?**
(1) Code is more clean and more readable. (2) Promotes logical abstraction of components. (3) Decoupling of application (instead of defining lot
of NEWs). Code can be easily testable with different mock implementations.

**3- Thread Cuncurrency**
Different threads are doing different things at the same time. A simple example is a web application which may start processing one request on one
thread and then, if another request comes in while it's still processing the first one, start processing the next one on another thread.

**3.1- Thread SAFE:**
When you're running multiple threads, could happen that one thread access variables / memory from other threads, and even subscribe it's values.
One way to avoid it is by THREAD-SAFE. One way to implement THREAD-SAFE is using DELEGATE, because DELEGATES are immutable. What is a Delegate:
A delegate allow you to make reference to a method, that will be defined in execution time. Is like Pointer in C++.

**4- How do you clean up unmanaged resources such as database connection?**
Way1 - HARD: Implement IDisposable and GC.SupressFinalize.
Way2 - EASY: "Using" key word and Brackets. Exemple: using (SqlConnection c = new SqlConnection())

**5- Difference between Get and Post in Http verb?**
Post you will use for CREATE something (Insert in Database), and GET to Take Something (Select in DataBase).

**6- What Http verb do you use to update?**
PUT and PATCH. The difference between them is that on PUT you'll always send all the PARAMETERS - full payload, meanwhile in PATCH you send just what you want to UPDATE.

PUT:
{
"front_patio": true,
"back_patio": true,
"windows": 12,
"doors": 4,
"Balcony": false
}
PATCH:
{
"doors": 4
}

**7- How do you use database in your code? Like how do you make connections?**
EF: Create a Context, inject the context from the API with the connection into appsettings.json, rewrite this connection on Azure panel Configs.
Dapper: Basically the same thing.

**8- In CSS how do you select element with ID or with class?**
.people {
background-color: white;
}

#alice {
text-transform: capitalize;
}

#bob {
text-transform: uppercase;
}

<div class="people" id="alice">Alice</div>
<div class="people" id="bob">Bob</div>

**9- How do you empty an array in javascript?**
arr1 = []; (equal square brackets + commapoint)

**10- What is the difference between inner join and outer join in sql?**
Both are used to combine rows for two or more tables. Inner don't include non-matching rows, OUTER include them. =)

**11- In C# is the string value type or reference type?**
Reference Type, it will be storage on the heap.

**12- What is a global variable in javascript?**
It's when you declare it OUTSIDE of the function, and can be accessed by any other function.

**13- What is unit testing? What framework do you use for unit testing?**
Unit testing is a software testing methodology. MsTest, XUnit, NUnit. The way i Use: (1) Create a project test, (2) Red Green Refactory,
(3) Write the Methods with Arrange, Act, Assert, (4) Refactory again
Mocha - to generate Fake Data. Selenium also read HTML pages (control browser). MochaTs - to Test API endpoints (still studying)

**14- What is the difference of Clustered index and unclustered index in sql?**
NICE! Cluster is the MAIN index on table, normally used on PK, and storaged on the table, more faster. NonClustered could be MANY, are not storaged on the Table itself,
could be N, but are slow than clustered.

**15- What do you know about CI/CD?**
IIS - Old VPS Servers.
Azure - Publish using GitHub Actions, Running all tests and deploying it into Azure, Also Deploying using Container pushing into DockerHub and
Azure. LocalStorage, Azure Functions for small apps.

**16- Could you describe SOLID principles?**
S - Single responsability principle - one class should have just one responsability and one reason to change (Brake: You have a Employee class that
CalculateSallary, ProcessPayment and UpdateBankOfHours): Your class is doing more than 1 thing.
O - Open Close Principle - Class should be open to extension, but closed to modification (Brake: Employee as a class with Calculate Sallary method and Enum
for Junior/Senior doing IF and ELSE. RIGHT: Create a IEmployee with fields and methods, and ICalculator with method CalculateSallary. Class SeniorEmployee
and JuniorEmployee will implement the Calculate with different approachs).
L - Barbara Liskov Principle. Square and Retangle should inheritate ABSTRACT class Figure, and rewrite the CalculateArea method.
I - Interface Segregation Principle. Classes shouldn't be forced to depend on methods it will not use. So: Instead of have a BIG interface with lot of methods,
let's brake it on small interfaces. IMultifuncionalPrinter with 4 methods shouldn't be implemented by a NormalPrinter class.
D - Dependency inversion principle. Modules of high level shouldn't depend on modules of low level, both should depend on abstractions, and abstractions shouldn't depend on details, but details depend on abstractions.

public class Email{
public void sendEmail(Client client) WRONG!!!
}
Should implement IContact, and all classes that implement IContact could use the sendEmail.

**To Study Interview of EFD: TRÊS QUESTÕES JAVASCRIPT**: closure - nested - group by

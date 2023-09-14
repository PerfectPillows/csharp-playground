using csharp_playground.playground;
using System.Security.Cryptography;

DelegatesTutorial d = new DelegatesTutorial();

d.del("Hello World");

int square;
bool isGreater; 

//d.calculateSquare(5, out square, out isGreater);


//d.logDel("Rishi",DateTime.Now);

var sentence = "This is an extension method used";
Console.WriteLine(sentence.CapitalizeSentence());

var employeeData = Data.GetEmployees();
var departmentData = Data.GetEmployees();

var joinedData = from emp in employeeData
                 join dept in departmentData on emp.DepartmentId equals dept.Id
                 where emp.IsManager == true
                 select new
                 {
                     FirstName = emp.FirstName,
                     LastName = emp.LastName,
                 };
foreach(var item in joinedData)
{
    Console.WriteLine(item.FirstName + " " + item.LastName);
}



int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = from num in arr
                  where num % 2 == 0
                  select num;

Console.WriteLine(employeeData.Average(emp => emp.AnnualSalary));

var empResult = employeeData.Select(e => new
{
    FullName = e.FirstName + " " + e.LastName,
    AnnualSalary = e.AnnualSalary
}).Where(e=> e.AnnualSalary >= 50000);
 

foreach (var item in empResult)
{
    Console.WriteLine(item.FullName);
}


var persons = new[]
{
    new { Id = 1, Name = "John" },
    new { Id = 2, Name = "Jane" },
    new { Id = 3, Name = "Jake" },
};

var orders = new[]
{
    new { PersonId = 1, Product = "Laptop" },
    new { PersonId = 1, Product = "Mouse" },
    new { PersonId = 2, Product = "Tablet" },
    new { PersonId = 3, Product = "Phone" },
    new { PersonId = 3, Product = "Keyboard" },
};

var groupJoinQuery =
    from order in orders
    join person in persons on order.PersonId equals person.Id 
    select person;


var interfaceExperimentObj = new MultipleInterface();
((IInterfaceA)interfaceExperimentObj).display();
((IInterfaceB)interfaceExperimentObj).display();


foreach (var result in groupJoinQuery) { }
//{
//    Console.WriteLine($"{result.Name} bought:");
//    foreach (var product in result.Products)
//    {
//        Console.WriteLine($"- {product.Product}");
//    }
//}
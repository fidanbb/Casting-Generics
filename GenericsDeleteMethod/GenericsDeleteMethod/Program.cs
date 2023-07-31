
using GenericsDeleteMethod;

DataList<Employee> employee = new DataList<Employee>();

employee.Add(new Employee() { Id = 1, FullName = "Fidan Bashirova", Age = 22, IsDeleted = false });
employee.Add(new Employee() { Id = 2, FullName = "Xeyal Aliyev", Age = 26, IsDeleted = false });
employee.Add(new Employee() { Id = 3, FullName = "Nigar Adilova", Age = 30, IsDeleted = false });
employee.Add(new Employee() { Id = 4, FullName = "Adil Veliyev", Age = 28, IsDeleted = false });



var result = employee.Delete(2);

var employees = employee.GetAll();

foreach (var item in employees)
{
    if (item.IsDeleted==true)
    {
        Console.WriteLine("Deleted Employee: "+item.Id + ", " + item.FullName + ", " + item.Age);
        
    }
}


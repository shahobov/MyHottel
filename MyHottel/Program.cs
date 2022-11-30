// See https://aka.ms/new-console-template for more information
using MyHottel.DataProvider;
using MyHottel.DBContext.ApplicationContext;
using MyHottel.Models;
using MyHottel.Services;

PersonService personService = new PersonService(new DatabaseDataProvider<Person>());

//Person person = new Person()
//{
//    Id=20,
//    Name="Asliddin",
//    FirstName="Fakhriddinovich",
//    Address="Istaravshan",
//    Birthday="1995-01-26",
//    PhoneNumber="+992929997540"
//};

//personService.Add(person);

var personList = new List<Person>();
personList.Add(personService.GetById(10));

foreach (var item in personList)
{
    Console.WriteLine(item.Name);
}

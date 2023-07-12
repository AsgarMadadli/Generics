using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> personList = new List<Person>();

        
        personList.Add(new Person { Name = "Tayfun", Surname = "Nuri", Age = 20 });
        personList.Add(new Person { Name = "Abdullah", Surname = "Manaflı", Age = 16 });
        personList.Add(new Person { Name = "Elvin", Surname = "Hüseynov", Age = 35 });
        personList.Add(new Person { Name = "Aysel", Surname = "Əliyeva", Age = 42 });
        personList.Add(new Person { Name = "Togrul", Surname = "Soltanov", Age = 31 });
        personList.Add(new Person { Name = "Rəşad", Surname = "Daglı", Age = 39 });
        personList.Add(new Person { Name = "Səbuhi", Surname = "İbrahimov", Age = 39 });
        personList.Add(new Person { Name = "Aynur", Surname = "Nəbiyeva", Age = 26 });
        personList.Add(new Person { Name = "Eldar", Surname = "Abbasov", Age = 29 });
        personList.Add(new Person { Name = "Nigar", Surname = "Quliyeva", Age = 33 });

        Console.Write("Aramak istediğiniz adı girin: ");
        string searchName = Console.ReadLine();

        bool found = false;

        foreach (Person person in personList)
        {
            if (person.Name.ToLower() == searchName.ToLower())
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Bulundu");
        }
        else
        {
            Console.WriteLine("Bulunamadı");
        }
    }
}
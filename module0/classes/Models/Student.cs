using System;

class Students
{
    public int Id;
    public string Name;
    public int Marks;

    public Students(int id, string name, int marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student Id: {Id}");
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }
}

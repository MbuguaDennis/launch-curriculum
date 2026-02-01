class Student
{
    // fields
    public int Id;
    public string Name;

    // constructor
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // method to display details
    public void ShowStudent()
    {
        Console.WriteLine($"Student id {Id} and name {Name}");
    }
}
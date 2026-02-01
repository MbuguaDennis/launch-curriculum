var userRole = "Admin";
var tasks = "process shipping, update users";
var isLoggedIn = true;

if (isLoggedIn)
{
    if (userRole != "Admin")
    {
        Console.WriteLine("Welcome! To access tasks, contact an administrator");
    }
    else if (userRole == "Admin" && tasks.Length > 0)
    {
        Console.WriteLine("Today's tasks are: " + tasks);
    }
}
else
{
    Console.WriteLine("Please Log In");
}
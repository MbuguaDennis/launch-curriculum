using System;

class Program
{
    static void Main()
    {
        // Menu items
        string menu1 = "tacos";
        string menu2 = "popcorn";
        string menu3 = "ice cream";
        string menu4 = "burger";
        string menu5 = "pizza";
        string menu6 = "salad";

        // Variables to store each user's order
        string order1, order2, order3, order4;

        // 1️⃣ Ask User 1
        Console.WriteLine("User 1, enter your order:");
        order1 = Console.ReadLine();
        if (order1.ToLower() == menu1 || order1.ToLower() == menu2 || order1.ToLower() == menu3
            || order1.ToLower() == menu4 || order1.ToLower() == menu5 || order1.ToLower() == menu6)
        {
            Console.WriteLine("Order accepted!");
        }
        else
        {
            Console.WriteLine("Sorry, that item is not on the menu.");
            order1 = ""; // ignore invalid order
        }

        // 2️⃣ Ask User 2
        Console.WriteLine("User 2, enter your order:");
        order2 = Console.ReadLine();
        if (order2.ToLower() == menu1 || order2.ToLower() == menu2 || order2.ToLower() == menu3
            || order2.ToLower() == menu4 || order2.ToLower() == menu5 || order2.ToLower() == menu6)
        {
            Console.WriteLine("Order accepted!");
        }
        else
        {
            Console.WriteLine("Sorry, that item is not on the menu.");
            order2 = "";
        }

        // 3️⃣ Ask User 3
        Console.WriteLine("User 3, enter your order:");
        order3 = Console.ReadLine();
        if (order3.ToLower() == menu1 || order3.ToLower() == menu2 || order3.ToLower() == menu3
            || order3.ToLower() == menu4 || order3.ToLower() == menu5 || order3.ToLower() == menu6)
        {
            Console.WriteLine("Order accepted!");
        }
        else
        {
            Console.WriteLine("Sorry, that item is not on the menu.");
            order3 = "";
        }

        // 4️⃣ Ask User 4
        Console.WriteLine("User 4, enter your order:");
        order4 = Console.ReadLine();
        if (order4.ToLower() == menu1 || order4.ToLower() == menu2 || order4.ToLower() == menu3
            || order4.ToLower() == menu4 || order4.ToLower() == menu5 || order4.ToLower() == menu6)
        {
            Console.WriteLine("Order accepted!");
        }
        else
        {
            Console.WriteLine("Sorry, that item is not on the menu.");
            order4 = "";
        }

        // 5️⃣ Combine orders
        string combinedOrder = order1 + " " + order2 + " " + order3 + " " + order4;

        // 6️⃣ Calculate cost ($2.12 per letter, ignore spaces)
        int letterCount = 0;
        for (int i = 0; i < combinedOrder.Length; i++)
        {
            if (combinedOrder[i] != ' ')
            {
                letterCount++;
            }
        }
        double totalCost = letterCount * 2.12;

        // 7️⃣ Print summary
        Console.WriteLine("\n=== Combined Order Summary ===");
        Console.WriteLine(combinedOrder);
        Console.WriteLine($"Total cost: ${totalCost:F2}");
    }
}

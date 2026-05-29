using System.Linq;

Console.WriteLine("Inventory Menu Program Started...");

int exitOption = 0;

List<string> products = new List<string>
{
    "chair",
    "table",
    "bottle",
    "laptop",
    "keyboard",
    "mouse",
    "backpack",
    "notebook",
    "headphones",
    "lamp"
};

while (exitOption == 0)
{
    Console.WriteLine(
        "Choose an inventory operation, please.\n" +
        "1 - Add Item\n" +
        "2 - List Items\n" +
        "3 - Search Item\n" +
        "4 - Exit"
    );

    string? option = Console.ReadLine();

    if (!int.TryParse(option, out int result) ||
        result is not (1 or 2 or 3 or 4))
    {
        Console.WriteLine("Invalid option. Please, try again.");
        continue;
    }

    switch (result)
    {
        case 1:
            Console.WriteLine("Type the name of the new product");
            string newProduct = Console.ReadLine();
            products.Add(newProduct);

            Console.WriteLine("Product added to the inventory");

            Console.WriteLine("Inventory list updated");
            foreach(var product in products)
            {

                Console.WriteLine($" - {product}");
            }
            break;

        case 2:
            foreach (var product in products)
            {
                Console.WriteLine($"List of the items: {product}");
            }

            Console.WriteLine("List Items selected.");
            break;

        case 3:
            Console.WriteLine("Search Item selected.");
            string searchedItem = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] == searchedItem)
                {
                    Console.WriteLine($"Item found: {products[i]}");
                    found = true;
                    break; 
                }
            }

            if (!found) Console.WriteLine("Item not found");

            break;

        case 4:
            Console.WriteLine("Exiting system...");
            exitOption = 1;
            break;

        default:
            Console.WriteLine("None matches the available options.");
            break;
    }

    if (exitOption == 0)
    {
        Console.WriteLine("Do you want to perform another operation? 0 - Yes, 1 - No");
        exitOption = Convert.ToInt32(Console.ReadLine());
    }

}

Console.WriteLine("System exited.");
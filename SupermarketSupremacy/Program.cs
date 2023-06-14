//Console Application for a Supermarket Ordering System

Dictionary<string, Product> productDictionary = new Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase)
{
    { "Apple", new Product {ProductID = 1, Name = "Apple", Price = 0.50m } },
    { "Banana", new Product {ProductID = 2, Name = "Banana", Price = 0.30m } },
    { "Orange", new Product {ProductID = 3, Name = "Orange", Price = 0.30m} },
    { "Lemon", new Product {ProductID = 4, Name = "Lemon", Price = 0.20m} },
    { "Lime", new Product {ProductID = 5, Name = "Lime", Price = 0.20m} },
    { "Bacon", new Product {ProductID = 6, Name = "Bacon", Price = 1.00m} },
    { "Chicken", new Product {ProductID = 7, Name = "Chicken", Price = 2.50m} },
    { "Beef", new Product {ProductID = 8, Name = "Beef", Price = 2.50m} },
    { "Lamb", new Product {ProductID = 9, Name = "Lamb", Price = 1.50m} },
    { "Pork", new Product {ProductID = 10, Name = "Pork", Price = 1.50m} },
    { "Carrot", new Product {ProductID = 11, Name = "Carrot", Price = 0.30m} },
    { "Broccoli", new Product {ProductID = 12, Name = "Broccoli", Price = 0.20m} },
    { "Potato", new Product {ProductID = 13, Name = "Potato", Price = 0.30m} },
    { "Peas", new Product {ProductID = 14, Name = "Peas", Price = 0.30m} },
    { "Celery", new Product {ProductID = 15, Name = "Celery", Price = 0.20m} },
    { "Toothpaste", new Product {ProductID = 16, Name = "Toothpaste", Price = 1.20m} },
    { "Deodorant", new Product {ProductID = 17, Name = "Deodorant", Price = 0.80m} },
    { "Shampoo", new Product {ProductID = 18, Name = "Shampoo", Price = 1.00m} },
    { "Conditioner", new Product {ProductID = 19, Name = "Conditioner", Price = 1.00m} },
    { "Cotton Balls", new Product {ProductID = 20, Name = "Cotton Balls", Price = 0.50m} },
    { "Milk", new Product {ProductID = 21, Name = "Milk", Price = 1.00m} },
    { "Orange Juice", new Product {ProductID = 22, Name = "Orange Juice", Price = 0.80m} },
    { "Apple Juice", new Product {ProductID = 23, Name = "Apple Juice", Price = 0.80m} },
    { "Iced Coffee", new Product {ProductID = 24, Name = "Iced Coffee", Price = 0.80m} },
    { "Water", new Product {ProductID = 25, Name = "Water", Price = 0.30m} },
    { "Chocolate", new Product {ProductID = 26, Name = "Chocolate", Price = 0.80m} },
    { "Gummy Bears", new Product {ProductID = 27, Name = "Gummy Bears", Price = 0.70m} },
    { "Biscuits", new Product {ProductID = 28, Name = "Biscuits", Price = 1.00m} },
    { "Fizzy Cola Sweets", new Product {ProductID = 29, Name = "Fizzy Cola Sweets", Price = 0.30m} },
    { "Milk Chocolate Buttons", new Product {ProductID = 30, Name = "Milk Chocolate Buttons", Price = 0.70m} }
};

List<Product> basket = new List<Product>();

Console.WriteLine("Welcome to the store!");
Console.WriteLine("How can we help you today?");

string userInput = string.Empty;

Product product;

while ((userInput != "Exit") && (userInput != "exit"))
{
    Console.WriteLine("1. Add to basket\n" +
                      "2. Remove from basket\n" +
                      "3. Check basket\n" +
                      "4. Checkout\n" +
                      "5. Exit\n");

    userInput = Console.ReadLine();

    if ((userInput == "Add") || (userInput == "Add to basket") || (userInput == "add"))
    {
        Console.WriteLine("Select a Product Type:");
        Console.WriteLine("1. Fruit\n" +
                          "2. Meat\n" +
                          "3. Vegetables\n" +
                          "4. Self-Care\n" +
                          "5. Drinks\n" +
                          "6. Sweets\n");

        string productInput = Console.ReadLine();

        if ((productInput == "Fruit") || (productInput == "fruit"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Apple - £0.50\n" +
                              "2. Banana - £0.30\n" +
                              "3. Orange - £0.30\n" +
                              "4. Lemon - £0.20\n" +
                              "5. Lime - £0.20\n");

            string fruitInput = Console.ReadLine();
            string formattedFruitInput = fruitInput.Substring(0, 1).ToUpper() + fruitInput.Substring(1);
            if ((fruitInput == "Apple") || (fruitInput == "apple"))
            {
                if (productDictionary.TryGetValue(fruitInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedFruitInput} has been added to the basket.");
                }
            }
            else if ((fruitInput == "Banana") || (fruitInput == "banana"))
            {
                if (productDictionary.TryGetValue(fruitInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedFruitInput} has been added to the basket.");
                }
            }
            else if ((fruitInput == "Orange") || (fruitInput == "orange"))
            {
                if (productDictionary.TryGetValue(fruitInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedFruitInput} has been added to the basket.");
                }
            }
            else if ((fruitInput == "Lemon") || (fruitInput == "lemon"))
            {
                if (productDictionary.TryGetValue(fruitInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedFruitInput} has been added to the basket.");
                }
            }
            else if ((fruitInput == "Lime") || (fruitInput == "lime"))
            {
                if (productDictionary.TryGetValue(fruitInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedFruitInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
        if ((productInput == "Meat") || (productInput == "meat"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Bacon - £1.00\n" +
                              "2. Chicken - £2.50\n" +
                              "3. Beef - £2.50\n" +
                              "4. Lamb - £1.50\n" +
                              "5. Pork - £1.50\n");

            string meatInput = Console.ReadLine();
            string formattedMeatInput = meatInput.Substring(0, 1).ToUpper() + meatInput.Substring(1);
            if ((meatInput == "Bacon") || (meatInput == "bacon"))
            {
                if (productDictionary.TryGetValue(meatInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedMeatInput} has been added to the basket.");
                }
            }
            else if ((meatInput == "Chicken") || (meatInput == "chicken"))
            {
                if (productDictionary.TryGetValue(meatInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedMeatInput} has been added to the basket.");
                }
            }
            else if ((meatInput == "Beef") || (meatInput == "beef"))
            {
                if (productDictionary.TryGetValue(meatInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedMeatInput} has been added to the basket.");
                }
            }
            else if ((meatInput == "Lamb") || (meatInput == "lamb"))
            {
                if (productDictionary.TryGetValue(meatInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedMeatInput} has been added to the basket.");
                }
            }
            else if ((meatInput == "Pork") || (meatInput == "pork"))
            {
                if (productDictionary.TryGetValue(meatInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedMeatInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
        if ((productInput == "Vegetables") || (productInput == "vegetables"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Carrot - £0.30\n" +
                              "2. Broccoli - £0.20\n" +
                              "3. Potato - £0.30\n" +
                              "4. Peas - £0.30\n" +
                              "5. Celery - £0.20\n");

            string vegInput = Console.ReadLine();
            string formattedVegInput = vegInput.Substring(0, 1).ToUpper() + vegInput.Substring(1);
            if ((vegInput == "Carrot") || (vegInput == "carrot"))
            {
                if (productDictionary.TryGetValue(vegInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedVegInput} has been added to the basket.");
                }
            }
            else if ((vegInput == "Broccoli") || (vegInput == "broccoli"))
            {
                if (productDictionary.TryGetValue(vegInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedVegInput} has been added to the basket.");
                }
            }
            else if ((vegInput == "Potato") || (vegInput == "potato"))
            {
                if (productDictionary.TryGetValue(vegInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedVegInput} has been added to the basket.");
                }
            }
            else if ((vegInput == "Peas") || (vegInput == "peas"))
            {
                if (productDictionary.TryGetValue(vegInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedVegInput} has been added to the basket.");
                }
            }
            else if ((vegInput == "Celery") || (vegInput == "celery"))
            {
                if (productDictionary.TryGetValue(vegInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedVegInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
        if ((productInput == "Self-Care") || (productInput == "self-care") || (productInput == "Self Care") || (productInput == "self care"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Toothpaste - £1.20\n" +
                              "2. Deodorant - £0.80\n" +
                              "3. Shampoo - £1.00\n" +
                              "4. Conditioner - £1.00\n" +
                              "5. Cotton Balls - £0.50\n");

            string sCareInput = Console.ReadLine();
            string formattedSCareInput = sCareInput.Substring(0, 1).ToUpper() + sCareInput.Substring(1);
            if ((sCareInput == "Toothpaste") || (sCareInput == "toothpaste"))
            {
                if (productDictionary.TryGetValue(sCareInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSCareInput} has been added to the basket.");
                }
            }
            else if ((sCareInput == "Deodorant") || (sCareInput == "deodorant"))
            {
                if (productDictionary.TryGetValue(sCareInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSCareInput} has been added to the basket.");
                }
            }
            else if ((sCareInput == "Shampoo") || (sCareInput == "shampoo"))
            {
                if (productDictionary.TryGetValue(sCareInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSCareInput} has been added to the basket.");
                }
            }
            else if ((sCareInput == "Conditioner") || (sCareInput == "conditioner"))
            {
                if (productDictionary.TryGetValue(sCareInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSCareInput} has been added to the basket.");
                }
            }
            else if ((sCareInput == "Cotton Balls") || (sCareInput == "cotton balls"))
            {
                if (productDictionary.TryGetValue(sCareInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSCareInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
        if ((productInput == "Drinks") || (productInput == "drinks"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Milk - £1.00\n" +
                              "2. Orange Juice - £0.80\n" +
                              "3. Apple Juice - £0.80\n" +
                              "4. Iced Coffee - £0.80\n" +
                              "5. Water - £0.30\n");

            string drinkInput = Console.ReadLine();
            string formattedDrinkInput = drinkInput.Substring(0, 1).ToUpper() + drinkInput.Substring(1);
            if ((drinkInput == "Milk") || (drinkInput == "milk"))
            {
                if (productDictionary.TryGetValue(drinkInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedDrinkInput} has been added to the basket.");
                }
            }
            else if ((drinkInput == "Orange Juice") || (drinkInput == "orange juice"))
            {
                if (productDictionary.TryGetValue(drinkInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedDrinkInput} has been added to the basket.");
                }
            }
            else if ((drinkInput == "Apple Juice") || (drinkInput == "apple juice"))
            {
                if (productDictionary.TryGetValue(drinkInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedDrinkInput} has been added to the basket.");
                }
            }
            else if ((drinkInput == "Iced Coffee") || (drinkInput == "iced coffee"))
            {
                if (productDictionary.TryGetValue(drinkInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedDrinkInput} has been added to the basket.");
                }
            }
            else if ((drinkInput == "Water") || (drinkInput == "water"))
            {
                if (productDictionary.TryGetValue(drinkInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedDrinkInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
        if ((productInput == "Sweets") || (productInput == "sweets"))
        {
            Console.WriteLine("Select a Product:");
            Console.WriteLine("1. Chocolate - £0.80\n" +
                              "2. Gummy Bears - £0.70\n" +
                              "3. Biscuits - £1.00\n" +
                              "4. Fizzy Cola Sweets - £0.30\n" +
                              "5. Milk Chocolate Buttons - £0.70\n");

            string sweetsInput = Console.ReadLine();
            string formattedSweetsInput = sweetsInput.Substring(0, 1).ToUpper() + sweetsInput.Substring(1);
            if ((sweetsInput == "Chocolate") || (sweetsInput == "chocolate"))
            {
                if (productDictionary.TryGetValue(sweetsInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSweetsInput} has been added to the basket.");
                }
            }
            else if ((sweetsInput == "Gummy Bears") || (sweetsInput == "gummy bears"))
            {
                if (productDictionary.TryGetValue(sweetsInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSweetsInput} has been added to the basket.");
                }
            }
            else if ((sweetsInput == "Biscuits") || (sweetsInput == "biscuits"))
            {
                if (productDictionary.TryGetValue(sweetsInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSweetsInput} has been added to the basket.");
                }
            }
            else if ((sweetsInput == "Fizzy Cola Sweets") || (sweetsInput == "fizzy cola sweets"))
            {
                if (productDictionary.TryGetValue(sweetsInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSweetsInput} has been added to the basket.");
                }
            }
            else if ((sweetsInput == "Milk Chocolate Buttons") || (sweetsInput == "milk chocolate buttons"))
            {
                if (productDictionary.TryGetValue(sweetsInput, out product))
                {
                    basket.Add(product);
                    Console.WriteLine($"{formattedSweetsInput} has been added to the basket.");
                }
            }
            else
            {
                Console.WriteLine("Product not found. Please re-type your product choice.");
            }
        }
    }
    else if ((userInput == "Remove") || (userInput == "Remove from basket") || (userInput == "remove"))
    {
        Console.WriteLine("Current products in basket:");
        for (int i = 0; i < basket.Count; i++)
        {
            Product bProduct = basket[i];
            Console.WriteLine($"{i + 1}. {bProduct.Name}");
        }

        if (basket.Count == 0)
        {
            Console.WriteLine("Error: Basket is empty. Cannot remove items from an empty basket.");
        }
        else
        {
            Console.WriteLine("Which product would you like to remove?:");
            string productChoice = Console.ReadLine();
            bool productRemoved = false;
            string productChoiceR = productChoice.Substring(0, 1).ToUpper() + productChoice.Substring(1);

            for (int i = 0; i < basket.Count; i++)
            {
                if (basket[i].Name.Equals(productChoice, StringComparison.OrdinalIgnoreCase))
                {
                    basket.RemoveAt(i);
                    productRemoved = true;
                    break;
                }
            }
            if (productRemoved)
            {
                Console.WriteLine($"{productChoiceR} has been removed from the basket.");
            }
            else
            {
                Console.WriteLine($"Error: {productChoiceR} not found. Please check your basket and try again.");
            }
        }
    }
    else if ((userInput == "Check Basket") || (userInput == "check basket") || (userInput == "check"))
    {
        Console.WriteLine("Current products in basket:");
        for (int i = 0; i < basket.Count; i++)
        {
            Product bProduct = basket[i];
            Console.WriteLine($"{i + 1}. {bProduct.Name}");
        }
        Console.WriteLine("-----------------------");
    }
    else if ((userInput == "Checkout") || (userInput == "Check Out") || (userInput == "checkout") || (userInput == "check out"))
    {
        Console.WriteLine("Checking Out With:");
        for (int i = 0; i < basket.Count; i++)
        {
            Product bProduct = basket[i];
            Console.WriteLine($"{i + 1}. {bProduct.Name} - £{bProduct.Price}");
        }

        decimal totalPrice = CalculatingTotal(basket);

        Console.WriteLine("Your total comes to: £" + totalPrice);

        Console.WriteLine("Would you like to checkout? (y/n)");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            if ((input == "y") || (input == "Y"))
            {
                basket.Clear();
                Console.WriteLine("Thank you. If there's nothing else you need, please exit the application.");
            }
            else if ((input == "n") || (input == "N"))
            {
                Console.WriteLine("Understood. What would you like to do?");
            }
            else
            {
                Console.WriteLine("Error: Input not recognised. Please re-type.");
            }
        }
        else
        {
            Console.WriteLine("Error: Blank input. Please type in 'y' for Yes or 'n' for No.");
        }
    }
}
if ((userInput == "Exit") || (userInput == "exit"))
{
    Console.WriteLine("Thank you for shopping with us! Press any key to exit.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Error: Invalid input. Select an input from the menu or make sure your input is spelled correctly.");
}


decimal CalculatingTotal(List<Product> basket)
{
    decimal totalPrice = 0;
    foreach(Product product in basket)
    {
        totalPrice += product.Price;
    }
    
    return totalPrice;
}

class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

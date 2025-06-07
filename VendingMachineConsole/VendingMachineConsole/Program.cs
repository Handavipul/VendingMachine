// See https://aka.ms/new-console-template for more information
using VendingMachineConsole.Service;


    var coinService = new USCoinIdentifier();
    var paymentService = new PaymentTracker();
    var productService = new ProductCatalog();
    var display = new DisplayManager();

    while (true)
    {
        Console.Clear();
        Console.WriteLine("--- Vending Machine ---");
        Console.WriteLine($"Display: {display.GetMessage()}");
        Console.WriteLine("1. Insert Coin");
        Console.WriteLine("2. Select Product");
        Console.WriteLine("3. Exit");
        var choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Enter coin (weight size):");
            var input = Console.ReadLine()?.Split();
            if (input?.Length == 2 &&
                double.TryParse(input[0], out var weight) &&
                double.TryParse(input[1], out var size))
            {
                var type = coinService.Identify(weight, size);
                var value = coinService.GetCoinValue(type);
                if (value > 0)
                    paymentService.InsertCoin(value);
                display.ShowInsertCoinOrAmount(paymentService.CurrentAmount);
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter product name (Cola/Chips/Candy):");
            var name = Console.ReadLine();
            var product = productService.GetProduct(name);
            if (product == null)
            {
                display.ShowInsertCoinOrAmount(paymentService.CurrentAmount);
                continue;
            }

            if (paymentService.CurrentAmount >= product.Price && productService.Vend(name))
            {
                display.ShowThankYou();
                paymentService.Reset();
            }
            else
            {
                display.ShowPrice(product.Price);
            }
        }
        else if (choice == "3")
        {
            break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }


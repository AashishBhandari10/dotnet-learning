Console.Write("Choose a number: \n1.Breakfast[12.80$] \n2.Lunch[19.90$] \n3.Dinner[18.78$]: ");
string? userDescription = Console.ReadLine();
if(userDescription != null)
{
    if (int.TryParse(userDescription, out int userMenu))
    {
        if (userMenu >= 1 && userMenu <= 3)
        {
            Console.Write("Enter the quantity: ");
            string? userQuantity = Console.ReadLine();
            if (userQuantity != null)
            {
                if (int.TryParse(userQuantity, out int userQuantity2))
                {
                    if (userQuantity2 >= 1 && userQuantity2 <= 99)
                    {
                        if (userMenu == 1)
                        {
                            decimal finalQuantity = 12.80m * userQuantity2;
                            Console.WriteLine($"Breakfast x {userQuantity2} = ${finalQuantity}");
                        }
                        if (userMenu == 2)
                        {
                            decimal finalQuantity = 19.90m * userQuantity2;
                            Console.WriteLine($"Lunch x {userQuantity2} = ${finalQuantity}");
                        }
                        if (userMenu == 3)
                        {
                            decimal finalQuantity = 18.78m * userQuantity2;
                            Console.WriteLine($"Dinner x {userQuantity2} = ${finalQuantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter Quantity from 1-99.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 1-3.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
   
    
}


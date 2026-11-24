Console.Write("Choose a number: \n1.Breakfast[12.80$] \n2.Lunch[19.90$] \n3.Dinner[18.78$]: ");
string? userDescription = Console.ReadLine();
if(userDescription != null)
{
    int userMenu = int.Parse(userDescription);
    Console.Write("Enter the quantity: ");
    string? userQuantity = Console.ReadLine();
    if (userQuantity != null)
    {
        int userQuantity2 = int.Parse(userQuantity);
        if(userQuantity2 > 0)
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
           
    }
    
}


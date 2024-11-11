using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double price = 0;
        double secondRate = 0.2064;
        double thirdRate = 0.1775;
        double additionalPrice = 0;

        string[] carType = { "Ganze Steuer", "Halbe Steuer", "Viertel Steuer" };
        string[] energyEfficiency = { "Normal Steuer", "Kategorie A", " Kategorie B", "Reinelektrisch" };

        int selectedCarTypeIndex = -1;
        int selectedEnergyEfficiencyIndex = -1;

        Console.WriteLine("What's the weight of the car?");
        int carWeightInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What's the type of the car? \n" +
                          "Press g for Ganze Steuer \n" +
                          "Press h for Halbe Steuer \n" +
                          "Press v for Viertel Steuer");

        char carTypeChoice = Console.ReadLine().ToLower()[0];

        switch (carTypeChoice)
        {
            case 'g':
                selectedCarTypeIndex = 0;
                Console.WriteLine($"You selected {carType[0]}");
                break;
            case 'h':
                selectedCarTypeIndex = 1;
                Console.WriteLine($"You selected {carType[1]}");
                break;
            case 'v':
                selectedCarTypeIndex = 2;
                Console.WriteLine($"You selected {carType[2]}");
                break;
            default:
                Console.WriteLine("Invalid car type selected.");
                return;
        }

        Console.WriteLine("What's the energy efficiency of the car? \n" +
                          "Press n for Normal Steuer \n" +
                          "Press a for Kategorie A \n" +
                          "Press b for Kategorie B");

        char carEfficiencyChoice = Console.ReadLine().ToLower()[0];

        switch (carEfficiencyChoice)
        {
            case 'n':
                selectedEnergyEfficiencyIndex = 0;
                Console.WriteLine($"You selected {energyEfficiency[0]}");
                break;

            case 'a':
                selectedEnergyEfficiencyIndex = 1;
                Console.WriteLine($"You selected {energyEfficiency[1]}");
                break;

            case 'b':
                selectedEnergyEfficiencyIndex = 2;
                Console.WriteLine($"You selected {energyEfficiency[2]}");
                break;

            default:
                Console.WriteLine("Invalid Efficiency Level selected.");
                return;
        }

        // Calculate price based on car weight and efficiency
        if (carWeightInput <= 1000)
        {
            price = carWeightInput * 0.24;

            if (selectedCarTypeIndex == 0)
            {
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if(selectedCarTypeIndex == 1)
            {
                price /= 2;
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if(selectedCarTypeIndex == 2)
            {
                price /= 4; // Viertel Steuer
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
        }
        else if (carWeightInput > 1000 && carWeightInput <= 2000)
        {
            additionalPrice = (carWeightInput - 1000) * secondRate; //185.76

            price += additionalPrice; //425.76
            if (selectedCarTypeIndex == 0) //if Ganze Steuer
            {
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if (selectedCarTypeIndex == 1)
            {
                price /= 2;
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if (selectedCarTypeIndex == 2)
            {
                price /= 4; // Viertel Steuer
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }

        }
        else if (carWeightInput > 2000 && carWeightInput <= 3000)
        {
            additionalPrice = (carWeightInput - 2000) * thirdRate;
            price = 446.4 + additionalPrice;

            if (selectedCarTypeIndex == 0)  // if Ganze Steuer
            {
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if(selectedCarTypeIndex == 1)
            {
                price /= 2;
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if(selectedEnergyEfficiencyIndex == 0)
               {
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }
            else if(selectedCarTypeIndex == 2)
            {
                price /= 4; // Viertel Steuer
                if (selectedEnergyEfficiencyIndex == 1) // if Kategore A too
                {
                    price *= 0.6;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if (selectedEnergyEfficiencyIndex == 2){
                    price *= 0.8;
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
                }
                else if (selectedEnergyEfficiencyIndex == 0)
               {
                    Console.WriteLine($"Your Price is: {Math.Round(price, 2)}");
               } 
            }

        }
        else
        {
            Console.WriteLine("Weight exceeds calculation range.");
        }
    }


}
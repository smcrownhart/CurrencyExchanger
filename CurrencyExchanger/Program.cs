using CurrencyExchanger;

Console.WriteLine("Do you wish to begin currency exchange? y or n");

string start = Console.ReadLine();
int count = 0;
double totalUSCurrency = 0;
double totalGBPCurrency = 0;
double totalCANCurrency = 0;
double totalEURCurrency = 0;

if (start == "n")
{
    Console.WriteLine("Adios!");
    return;
}

if (start == "y")
{
    menuDisplay();

}
else {
    Console.WriteLine("Type y for yes or n for n");
    start = Console.ReadLine();
}


while (start == "y") //&& exitout ==true)
{
    string choice;
    

    choice = Console.ReadLine();

    switch (choice)
    {
        case "exit":

            Console.WriteLine("Have a great day!");
            return;

        case "1":

            USDollarsExchange();
            break;

        case "2":
            GBPExchange();
            break;

        case "3":
            CanadianExchange();
            break;

        case "4":
            ExchangeEuros();
            break;

        default:

            Console.WriteLine("Enter a nuber between 1 and 4 or type the word exit.");
            break;
    }

    Console.WriteLine("Do you wish to keep doing currency exchange? y or n");

    start = Console.ReadLine();

    if (start == "n")
    {
        Console.WriteLine("Your total number of transactions are: " + count);
        Console.WriteLine("Total US Currency exchanged: & " + totalUSCurrency.ToString("#.##"));
        return;
    }

    if (start != "y")
    {
        Console.WriteLine("Sorry, you're not understood... type y or n");
        start = Console.ReadLine();
    }

    menuDisplay();
}



void menuDisplay()
{

    Console.WriteLine("___________________________________________________");
    Console.WriteLine("_                       MENU                      _");
    Console.WriteLine("_ 1.) I have U.S. Dollars I want to Exchnage      _");
    Console.WriteLine("_ 2.) I have British Pounds I want to Exchnage    _");
    Console.WriteLine("_ 3.) I have Canadian Dollars I want to Exchnage  _");
    Console.WriteLine("_ 4.) I have Euros I want to Exchnage             _");
    Console.WriteLine("_ 5.) Type exit to leave                          -");
    Console.WriteLine("___________________________________________________");

    Console.WriteLine("Enter a choice for currency exhcnage \n");


}

void USDollarsExchange()
{
    ExchangeMonitor USD = new ExchangeMonitor(1);
    ExchangeMonitor GBP = new ExchangeMonitor(0.72523);
    ExchangeMonitor CAN = new ExchangeMonitor(1.25427);
    ExchangeMonitor EUR = new ExchangeMonitor(0.83572);

    Console.WriteLine("How many US Dollars would you like to exchange?");

    // //https://stackoverflow.com/questions/13106493/how-do-i-only-allow-number-input-into-my-c-sharp-console-application
    double USDCurrency;
    while (!double.TryParse(Console.ReadLine(), out USDCurrency))
    {
        Console.Write("Numbers only, try again ");
        return;
    }

    

    Console.WriteLine("What are you exchanging for?");
    Console.WriteLine("Enter 1 for pounds.");
    Console.WriteLine("Enter 2 for Canadian");
    Console.WriteLine("Enter 3 for Euros");

    

    string moneyExchange = Console.ReadLine();

    double exchangeGBP;
    double exchangeCAN;
    double exchangeEUR;

    exchangeGBP = GBP.moneyValue();
    exchangeCAN = CAN.moneyValue();
    exchangeEUR = EUR.moneyValue();

    

    if (moneyExchange == "1")
    {
        double resultUSD = Exchanger.ExchangeUSDtoGBP(USDCurrency, exchangeGBP);
        Console.WriteLine("$ " + resultUSD.ToString("#.##"));
        count++;
        
    }


    if (moneyExchange == "2")
    {
        double resultUSD = Exchanger.ExchangeUSDtoCAN(USDCurrency, exchangeCAN);
        Console.WriteLine("$ " + resultUSD.ToString("#.##"));
        count++;
        
    }

    if (moneyExchange == "3")
    {
        double resultUSD = Exchanger.ExchangeUSDtoEUR(USDCurrency, exchangeEUR);
        Console.WriteLine("$ " + resultUSD.ToString("#.##"));
        count++;
        

    }

    totalUSCurrency = USDCurrency + totalUSCurrency;

}

//GBP = 1.37887USD, 1.72947CAN, 1.15195EUR

void GBPExchange()
{
    ExchangeMonitor GBP1= new ExchangeMonitor(1);
    ExchangeMonitor USD1= new ExchangeMonitor(1.37887);
    ExchangeMonitor CAN1= new ExchangeMonitor(1.72947);
    ExchangeMonitor EUR1= new ExchangeMonitor(1.1519);

    Console.WriteLine("How many Pounds would you like to exchange?");

    double GBPpounds;
    while (!double.TryParse(Console.ReadLine(), out GBPpounds))
    {
        Console.Write("Numbers only, try again ");
        return;
    }

    Console.WriteLine("What are you exchanging for?");
    Console.WriteLine("Enter 1 for U.S. Dollars.");
    Console.WriteLine("Enter 2 for Canadian");
    Console.WriteLine("Enter 3 for Euros");

    string moneyExchange = Console.ReadLine();

    double exchangeUSD1;
    double exchangeCAN1;
    double exchangeEUR1;

    exchangeUSD1 = USD1.moneyValue();
    exchangeCAN1 = CAN1.moneyValue();
    exchangeEUR1 = EUR1.moneyValue();

    

    if (moneyExchange == "1")
    {
        double resultGBP = Exchanger.ExchangeGBPtoUSD(GBPpounds, exchangeUSD1);
        Console.WriteLine("£ " + resultGBP.ToString("#.##"));
        count++;
        totalGBPCurrency = totalGBPCurrency + resultGBP;
    }


    if (moneyExchange == "2")
    {
        double resultGBP = Exchanger.ExchangeGBPtoCAN(GBPpounds, exchangeCAN1);
        Console.WriteLine("£ " + resultGBP.ToString("#.##"));
        count++;
        totalGBPCurrency = totalGBPCurrency + resultGBP;
    }

    if (moneyExchange == "3")
    {
        double resultGBP = Exchanger.ExchangeGBPtoEUR(GBPpounds, exchangeEUR1);
        Console.WriteLine("£ " + resultGBP.ToString("#.##"));
        totalGBPCurrency = totalGBPCurrency + resultGBP;
        count++;
    }

    totalUSCurrency = totalUSCurrency + Exchanger.ExchangeGBPtoUSD(totalGBPCurrency, exchangeUSD1);
}

// CAN = .79728USD, .57848GBP, .66645EUR
void CanadianExchange()
{
    ExchangeMonitor CAN2 = new ExchangeMonitor(1);
    ExchangeMonitor USD2 = new ExchangeMonitor(.79728);
    ExchangeMonitor GBP2 = new ExchangeMonitor(.57818);
    ExchangeMonitor EUR2 = new ExchangeMonitor(.66645);

    Console.WriteLine("How many Canadian Dollars would you like to exchange?");

    double CANDollars;

    while (!double.TryParse(Console.ReadLine(), out CANDollars))
    {
        Console.Write("Numbers only, try again ");
        return;
    }

    Console.WriteLine("What are you exchanging for?");
    Console.WriteLine("Enter 1 for U.S. Dollars.");
    Console.WriteLine("Enter 2 for Pounds");
    Console.WriteLine("Enter 3 for Euros");

    string moneyExchange = Console.ReadLine();

    double exchangeUSD2;
    double exchangeGBP2;
    double exchangeEUR2;

    exchangeUSD2 = USD2.moneyValue();
    exchangeGBP2 = GBP2.moneyValue();
    exchangeEUR2 = EUR2.moneyValue();

   

    if (moneyExchange == "1")
    {
        double resultCAN = Exchanger.ExchangeCANtoUSD(CANDollars, exchangeUSD2);
        Console.WriteLine("$" + resultCAN.ToString("#.##"));
        count++;
        totalCANCurrency = totalCANCurrency + resultCAN;
    }


    if (moneyExchange == "2")
    {
        double resultCAN = Exchanger.ExchangeCANtoGBP(CANDollars, exchangeGBP2);
        Console.WriteLine("$" + resultCAN.ToString("#.##"));
        count++;
        totalCANCurrency = totalCANCurrency + resultCAN;
    }

    if (moneyExchange == "3")
    {
        double resultCAN = Exchanger.ExchangeCANtoEUR(CANDollars, exchangeEUR2);
        Console.WriteLine("$" + resultCAN.ToString("#.##"));
        count++;
        totalCANCurrency = totalCANCurrency + resultCAN;
    }

    totalUSCurrency = totalUSCurrency + Exchanger.ExchangeGBPtoUSD(totalCANCurrency, exchangeUSD2);
}
//EUR = 1.19648USD, .86826GBP, 1.50040CAN

void ExchangeEuros()
{
    ExchangeMonitor EUR3 = new ExchangeMonitor(1);
    ExchangeMonitor USD3 = new ExchangeMonitor(1.19648);
    ExchangeMonitor GBP3 = new ExchangeMonitor(.86826);
    ExchangeMonitor CAN3 = new ExchangeMonitor(1.50040);

    Console.WriteLine("How many Euros would you like to exchange?");

    double Euro;
    while (!double.TryParse(Console.ReadLine(), out Euro))
    {
        Console.Write("Numbers only, try again ");
        return;
    }

    Console.WriteLine("What are you exchanging for?");
    Console.WriteLine("Enter 1 for U.S. Dollars.");
    Console.WriteLine("Enter 2 for Pounds.");
    Console.WriteLine("Enter 3 for Canadian Dollars.");

    string moneyExchange = Console.ReadLine();

    double exchangeUSD3;
    double exchangeGBP3;
    double exchangeCAN3;

    exchangeUSD3 = USD3.moneyValue();
    exchangeGBP3 = GBP3.moneyValue();
    exchangeCAN3 = CAN3.moneyValue();

    

    if (moneyExchange == "1")
    {
        double resultEUR = Exchanger.ExchangeEURtoUSD(Euro, exchangeUSD3); 
        Console.WriteLine("€" + resultEUR.ToString("#.##"));
        count++;
        totalEURCurrency = totalEURCurrency + resultEUR;
    }


    if (moneyExchange == "2")
    {
        double resultEUR = Exchanger.ExchangeEURtoGBP(Euro, exchangeGBP3);
        Console.WriteLine("€" + resultEUR.ToString("#.##"));
        count++;
        totalEURCurrency = totalEURCurrency + resultEUR;
    }

    if (moneyExchange == "3")
    {
        double resultEUR = Exchanger.ExchangeEURtoCAN(Euro, exchangeCAN3);
        Console.WriteLine("€" + resultEUR.ToString("#.##")); 
        count++;
        totalEURCurrency = totalEURCurrency + resultEUR;
    }

    totalUSCurrency = totalUSCurrency + Exchanger.ExchangeGBPtoUSD(totalEURCurrency, exchangeUSD3);
}




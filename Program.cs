//available currencies in pakistan
int[] currencies = { 1, 2, 5, 10, 20, 50, 75, 100, 500, 1000, 5000 };


#region currency count via loop
//method to display heading
lineSplit("Currency count via loop");

//get amount
int amount = Convert.ToInt32(Console.ReadLine()),
    //set index/length of currencies (to loop over)
    index = currencies.Length - 1;

//while loop, will be executed till amount becomes 0
while (amount > 0)
{
    //swapping current current(index based) currency
    int currentCurrency = currencies[index], 
        //initializing count of currency to 0
        no = 0;

    //checking if current amount is greater or equal to perticular currency
    if (amount >= currentCurrency)
    {//amount is greater or equal. so,

        //divide amount with current currency to get dividing value (which will be number of times that currency note can be added to reach given amount)
        no = amount / currentCurrency;

        //now remove that number of times amount, so we can easily iterate over remaining amount
        amount -= no * currentCurrency;

        //print 
        Console.WriteLine($"{no} - {currentCurrency} Rupees");
    }
    //decreamnet currencies index length to loop over lowest currency in next turn
    index--;
}
#endregion

/*
 * Now doing same work using recursive method
 */ 

#region currency count via recursive method
//while loop to get values
while (true)
{// will hold console screen for a long time

    //heading
    lineSplit("Currency count via Recursive method");

    //reinitiazling index of currencies for recursive method
    index = currencies.Length - 1;
    //geting new input amount
    amount = Convert.ToInt32(Console.ReadLine());

    //calling recursive method
    recursiveMethod(amount);
}//while loop 

//recursive method
void recursiveMethod(int amount)
{
    //checking if amount is 0, then stop the flow
    if (amount <= 0) return;

    //swapping current current(index based) currency
    int currentCurrency = currencies[index],
        //initializing count of currency to 0
        no = 0;

    //checking if current amount is greater or equal to perticular currency
    if (amount >= currentCurrency)
    {//amount is greater or equal. so,

        //divide amount with current currency to get dividing value (which will be number of times that currency note can be added to reach given amount)
        no = amount / currentCurrency;

        //now remove that number of times amount, so we can easily iterate over remaining amount
        amount -= no * currentCurrency;

        //print 
        Console.WriteLine($"{no} - {currentCurrency} Rupees");
    }
    //decreamnet currencies index length to loop over lowest currency in next turn
    index--;
    
    //recursive call
    recursiveMethod(amount);
}//recursive method
#endregion



#region helping methods
void lineSplit(string topic)
{
    Console.WriteLine("\n");
    for (int i = 0; i <= 20; i++)
        Console.Write("*");

    Console.Write($" {topic} ");

    for (int i = 0; i <= 20; i++)
        Console.Write("*");
    Console.WriteLine("\n");
}//line splitter method

#endregion
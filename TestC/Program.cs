
static int throwDice()
{
    Random random = new Random();
    return random.Next(1, 7);
}
static double updateBalance(double b, int r)
{
    if (r == 1)
    {
        b *= 1.1;
    }
    else if (r == 2)
    {
        b *= 1.2;
    }
    else if (r == 3)
    {
        b *= 1.3;
    }
    else if (r == 4)
    {
        b *= 1.4;
    }
    else
    {
        b *= 0.65;
    }
    return b;
}
void draw()
{
    double balance = 10;
    int rolls = 0;
    int count = 1;
    a:
    if ( balance <= 20 && balance >=2 )
    {

        int roll = throwDice();
        balance = updateBalance(balance, roll);
        rolls++;
        Console.WriteLine("No. :" + count);
        Console.WriteLine("Roll result: " + roll);
        Console.WriteLine("Current balance:"  + (int)balance + "$");
        Console.WriteLine("--------------------------------");
        count++;
        goto a;
    }

    Console.WriteLine("Final Balance: " + (int)balance + "$");
    Console.WriteLine("Total dice rolls : " + rolls);
}
draw();

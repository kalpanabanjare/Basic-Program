
int Coin_Head = 1; //Constant
Random random = new Random(); //Computation // to create object
int coinCheck = random.Next(0, 2); // to call the object
if (coinCheck == Coin_Head) // to check condition 
{
    Console.WriteLine("Coin is Head");
}
else
{
    Console.WriteLine("Coin is Tails");
}

int key = 0;
while (key != 2)
{
    Console.WriteLine("For convert currency Please insert 1, for exit from app please insert 2");
    key = Convert.ToInt32(Console.ReadLine());
    CurrencyConverter.CurrencyConverter.ConverterInput(key);
}
Console.ReadLine();


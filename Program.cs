using System.Text;

internal class Program
{    
    private static void Main(string[] args)
    {
        Console.Write("Введите размер начального вклада: ");
        decimal inital_deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество лет: ");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите годовую процентную ставку: ");
        decimal interest_rate = Convert.ToDecimal(Console.ReadLine());

        string output = Interest_calculation(inital_deposit, years, interest_rate);
        Console.WriteLine(output.ToString());
    }
    public static string Interest_calculation(decimal inital_deposit, int years, decimal interest_rate)
    {
        StringBuilder res = new StringBuilder();

        for (int i = 1; i <= years; i++)
        {
            inital_deposit += inital_deposit * (interest_rate / 100);
            res.Append($"Год {i}: {inital_deposit:F2} руб.\n");
        }

        return res.ToString();
    }

}
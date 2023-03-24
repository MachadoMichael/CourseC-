using System;
using System.Globalization;

namespace CourseCSharp
{
    public class CoinConvert
    {
        public double dolar;
        public double amount;
        public double iof = 0.06;

        public double PaymentValue()
        {
            double valueInReal = dolar * amount;
            return valueInReal + (valueInReal * iof);
        }

        public void CoinChat() {
            Console.WriteLine("How's dollar price: ");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("How much dollars do you want?");
            amount = double.Parse(Console.ReadLine());
            double result = PaymentValue();
            Console.WriteLine($"Amout to be paid in real: {result.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(iof);
        }
    }
}


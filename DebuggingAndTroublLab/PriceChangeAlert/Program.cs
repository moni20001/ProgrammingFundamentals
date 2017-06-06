using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double diffrenceInPrices = TakeDiffrences(lastPrice, currentPrice);
            bool isDiffSmall = isThereDif(diffrenceInPrices, threshold);
            string message = Get(currentPrice, lastPrice, diffrenceInPrices, isDiffSmall);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double diffrence, bool isThereDif)
    {
        string message = "";
        if (diffrence == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isThereDif)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffrence * 100);
        }
        else if (isThereDif && (diffrence > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffrence * 100);
        }
        else if (isThereDif && (diffrence < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, diffrence * 100);
        }
            
        return message;
    }
    private static bool isThereDif(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double TakeDiffrences(double lastPrice, double currentPrice)
    {
        double r = (currentPrice - lastPrice) / lastPrice;
        return r;
    }
}

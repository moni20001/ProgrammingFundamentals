using System;

class Program
{
    static void Main(string[] args)
    {
        var peshoDmg = int.Parse(Console.ReadLine());
        var goshoDmg = int.Parse(Console.ReadLine());
        var peshoHp = 100;
        var goshoHp = 100;
        var round = 1;
        bool winner = false;
        while (winner == false)
        {
           
            if (round % 2 == 1 && winner == false)
            {
                
                if (goshoHp - peshoDmg > 0 && winner == false)
                {
                    goshoHp -= peshoDmg;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                    if (round % 3 == 0)
                    {
                        peshoHp = peshoHp + 10;
                        goshoHp = goshoHp + 10;
                    }
                }
                else
                {
                    winner = true;
                    Console.WriteLine($"Pesho won in {round}th round.");
                }
                   

            }
            else if(round % 2 == 0 && winner == false)
            {

                if (peshoHp - goshoDmg > 0 && winner == false)
                {
                    peshoHp -= goshoDmg;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                    if (round % 3 == 0)
                    {
                        peshoHp = peshoHp + 10;
                        goshoHp = goshoHp + 10;
                    }
                }

                else
                {
                    winner = true;
                    Console.WriteLine($"Gosho won in {round}th round.");
                }
                    


            }
            
            round++;
        }
    }
}

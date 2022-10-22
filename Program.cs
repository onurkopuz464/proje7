using System;

namespace c
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int toplamtek = 0;
            int toplamcift = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==1)
                {
                    toplamtek +=i;
                    continue;
                }
                else
                {
                    toplamcift += i;

                }
                if(i== 500)
                {
                    break;
                }
            }
            Console.WriteLine("tek toplam "+ toplamtek);
            Console.WriteLine("çift toplam "+ toplamcift);
        
         
        

        }
        
      
    }
    
}
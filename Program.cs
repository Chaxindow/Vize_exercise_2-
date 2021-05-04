using System;

namespace vize1soru 
{
    class Program
    {
        static void Main(string[] args)
        {
           int number;
           int method;

            Console.WriteLine("Enter number : ");
            number = Convert.ToInt32(Console.ReadLine());

            method =  Hesapla(number);

            if (method == number) 
            {
                Console.WriteLine("Method calisti : {0}", method);
            }
           

           




            
           
          
                        
            
        }

       
        private static int Hesapla( int number )
        {
            int deger=0,i;
            for(i=2;i<=number;i++)
            {
                if(number%i==0)
                {
                    deger = deger + (number / i);
                }
            }
            return deger;
        }








    }
}

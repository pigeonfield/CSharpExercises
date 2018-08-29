using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)     //initialization
        {
            Diary diary = new Diary();      //creating an object of a specific class

            //diary.AddRating(5);             //adding list elements
            //diary.AddRating(8.5f);
            //diary.AddRating(4.5f);
            //diary.AddRating(6.25f);
            //diary.AddRating(2);
            //diary.AddRating(3.75f);

            //float avg = diary.AvCalc();     //asigning values using Diary class methods
            //float max = diary.MaxRate();
            //float min = diary.MinRate();

            for (; ; )                      //infinite loop
            {
                Console.WriteLine("Please, type a rate value (1-10)");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);  //thanks to TryParse we're checking whether an input is a number or not

                if (rating == 11)
                {
                    break;
                }

                if (result) 
                {
                    if (rating > 1 && rating < 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Bad number. Try to change it for 1-10");
                    }
                }

                ;
            }

            Console.WriteLine("Average rating is : " + diary.AvCalc());
            Console.WriteLine("Max rating is : " + diary.MaxRate());
            Console.WriteLine("Min rating is : " + diary.MinRate());
            Console.ReadKey();
        }
    }
}

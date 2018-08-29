using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        //class content
        List<float> ratings = new List<float>(); //initialization

        //actions
        public void AddRating(float rating)
        {
            ratings.Add(rating); //adding new rate for a ratings list
        }

        public float AvCalc()
        {
            float sum = 0, avg = 0;
            foreach (float rate in ratings)
            {
                sum += rate;
            }

            avg = sum / ratings.Count();    //using build-in Count method instead of counting elements by loop

            return avg;
        }

        public float MaxRate()
        {
            return ratings.Max(); 
        }

        public float MinRate()
        {
            return ratings.Min();
        }


    }
}

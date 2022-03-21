using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public static class BmiCalculator
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
            //calc the bmi into a float
            float bmi = heightInInches * heightInInches / weightInPounds * 703;
            //determine the weight category 
            WeightCategory wc;

            if (bmi > 30)
            {
                wc = WeightCategory.OBESE;
            }
            else if (bmi > 24 || bmi < 30)
            {
                wc = WeightCategory.OVERWEIGHT;
            }
            else if (bmi > 19 || bmi < 24)
            {
                wc = WeightCategory.NORMAL;
            }
            else
            {
                wc = WeightCategory.UNDERWEIGHT;
            }

            return new Bmi(weightInPounds, heightInInches, bmi, wc);
        }
    }
}

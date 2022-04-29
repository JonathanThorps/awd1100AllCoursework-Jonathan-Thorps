using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Bmi
    {
        private float _weightInPounds;
        private float _heightInInches;
        private float _bmi;
        private WeightCategory _weightCategory;

        public Bmi()
        {
            _weightCategory = new WeightCategory();
        }
        public Bmi(float weight, float height, float bmi, WeightCategory weightCategory)
        {
            _weightInPounds = weight;
            _heightInInches = height;
            _weightCategory = weightCategory;
            _bmi = bmi;

            if (weight < 70 || weight > 300)
            {
                throw new InvalidWeightException("Invalid Weight");
            }
            if (height < 60 || height > 84)
            {
                throw new InvalidHeightException("Invalid Height");
            }


        }
        public float WeightInPounds { get { return _weightInPounds; } }
        public float HeightInInches { get { return _heightInInches; } }

        public float BMI { get { return _bmi; } }

        public WeightCategory WeightCategory
        {
            get
            {
                return _weightCategory;
            }
        }
    }
}

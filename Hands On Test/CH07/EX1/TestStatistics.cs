using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class TestStatistics
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        public TestStatistics(float sum, float avg, float min, float max)
        {
            _avg = avg;
            _min = min;
            _max = max;
            _sum = sum;
        }
        public TestStatistics AddScore(float score)
        {
            _min = 0;
            _max = 0;
            _count = 0;

            while (_count > 0)
            {
                _sum = _sum + score;
                _avg = _sum / _count;

                if (score < 0 || score > 100)
                {
                    throw new ArgumentException("Score out of range");
                }

                for (int i = 0; i < _count;)
                {
                    if (score < _max)
                    {
                        _min += score;
                    }
                    else if (score > _min)
                    {
                        _max += score;
                    }
                }
                _count++;
            }
        }
        public int Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Average { get { return _avg; } }
        public float Min { get { return _min; } }
        public float Max { get { return _max; } }
    }
}

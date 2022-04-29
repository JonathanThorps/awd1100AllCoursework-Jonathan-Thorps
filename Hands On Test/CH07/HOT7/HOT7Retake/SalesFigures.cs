using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT7Retake
{
    public class SalesFigures
    {
        private int _count;
        private float _sum;
        private float _avg;
        private float _min;
        private float _max;

        public SalesFigures(int count,float sum,float avg,float min, float max)
        {
            _count = count;
            _sum = sum;
            _avg = avg;
            _min = min;
            _max = max;
        }
        public float AddSales(float sales)
        {
            for (int i = 0 ;i <_count; _count++)
            {
                return _sum += sales;

                if (sales < 0 || sales > 1000)
                {
                    throw new ArgumentException("Sales out of Range");
                }
                else
                {
                    return _avg = _sum / _count;
                }
                
                if (sales < _max)
                {
                   return sales = _min;
                }
                else
                {
                   return sales = _max;
                }
                
            }
            return _count;
        }
        public int Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Average { get { return _avg; } }
        public float Min { get { return _min; } }
        public float Max { get { return _max; } }
    }
}

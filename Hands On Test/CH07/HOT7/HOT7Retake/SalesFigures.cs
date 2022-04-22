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

        public SalesFigures()
        {
            _count = 0;
            _sum = 0;
            _avg = 0;
            _min = 0;
            _max = 0;
        }
        public float AddSales(float sales)
        {
            while (_count > 0)
            {
                _count++;

                if (sales < 0 || sales > 1000)
                {
                    throw new ArgumentException("Sales out of Range");
                }
                else
                {
                    _sum += sales;
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
            return _count++;
        }
        public int Count { get { return _count; } }
        public float Sum { get { return _sum; } }
        public float Average { get { return _avg; } }
        public float Min { get { return _min; } }
        public float Max { get { return _max; } }
    }
}

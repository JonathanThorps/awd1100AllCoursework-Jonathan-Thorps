using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Industry
    {
        private string _industryName;
        private Job[] _jobs;

        public Industry(string industry, Job[] jobs)
        {
            _industryName = industry;
            _jobs = jobs;
        }
        public string IndustryName
        {
            get { return _industryName; }
            set { _industryName = value; }
        }
        public Job[] Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }
        public override string ToString()
        {
            return IndustryName;
        }
    }
}

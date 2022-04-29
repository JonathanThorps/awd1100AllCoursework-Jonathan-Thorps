using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Computer
    {
        private string _name;
        private string _ipAddress;
        private string[] _services;

        public Computer(string name, string ipAddress, string[] services)
        {
            _name = name;
            _ipAddress = ipAddress;
            _services = services;
        }
        public string GetComputer(string name, string ipAddress, string[] services)
        {
            return _name;
            return _ipAddress;
            return _services.ToString();
        }
        public string Name { get { return _name; } }
        public string IpAddress { get { return _ipAddress; } }
        public int[] Services => _services[].ToString();
    }
}

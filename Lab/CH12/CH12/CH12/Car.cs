using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Car
    {
        //Attributes - instance fields - variables

        private string _carColor;
        private decimal _carPrice;
        private string _carBrand;

        //With data hiding we can manipulate and access data with public methods
        //Read & Write Operations - Getters and Setters
        
        public void SetCarColor(string carColor)
        {
            if (string.IsNullOrEmpty(carColor))
            {
                //Error Message
            }
            else
            {
                _carColor = carColor;
            }
            
        }
        public void SetCarPrice(decimal price)
        {
            if (price < 10000)
            {
                //Error Message
            }
            else
            {
                _carPrice = price;
            }
            
        }
        public void SetCarbrand(string brand)
        {
            if (brand.ToLower().Contains(_carBrand))
            {

            }
            else
            {

            }
        }
        public string GetCarColor()
        {
            return _carColor;
        }
        public decimal GetCarPrice()
        {
            return _carPrice;
        }
        public string GetCarBrand()
        {
            return _carBrand;
        }
    }
}

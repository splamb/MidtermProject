using System;
using System.Collections.Generic;
using System.IO;


namespace MidtermProject
{
    public class Product
    {
        

        private string _idNumber;

        public string IDNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = value;
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        private string _category;

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        private float _price;

        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
}
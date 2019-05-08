using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PTCData
{
    public class TrainingProductManager
    {
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public bool Validate(TrainingProduct entity)
        {
            ValidationErrors.Clear();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("ProductName", "Product name must not be all lower case"));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Delete(TrainingProduct entity)
        {
            return true;
        }

        public TrainingProduct Get(int productId)
        {
            List<TrainingProduct> list = new List<TrainingProduct>();
            TrainingProduct ret = new TrainingProduct();

            list = CreateMockData();

            ret = list.Find(p => p.ProductId == productId);

            return ret;
        }

        public bool Update (TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);

            if (ret)
            {

            }

            return ret;
        }

        public bool Insert(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if (ret)
            {

            }

            return ret;
        }

        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret = CreateMockData();

            //Do any searching
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(
                  p => p.ProductName.ToLower().
                        StartsWith(entity.ProductName,
                                  StringComparison.CurrentCultureIgnoreCase));
            }

            return ret;
        }

        protected List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSS, JavaScript and jQuery",
                IntroductionDate = Convert.ToDateTime("6/11/2015"),
                Url = "http://bit.ly/1SNzc0i",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Build your own Bootstrap Business Application Template in MVC",
                IntroductionDate = Convert.ToDateTime("11/2/2015"),
                Url = "http://bit.ly/1I8ZqZg",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap, and HTML5",
                IntroductionDate = Convert.ToDateTime("8/8/2014"),
                Url = "http://bit.ly/1J2dcrj",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "How to Start and Run A Consulting Business",
                IntroductionDate = Convert.ToDateTime("9/12/2013"),
                Url = "http://bit.ly/1L8kOwd",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "The Many Approaches to XML Processing in .NET Applications",
                IntroductionDate = Convert.ToDateTime("7/2/2013"),
                Url = "http://bit.ly/1DBfUqd",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF for the Business Programmer",
                IntroductionDate = Convert.ToDateTime("6/1/2009"),
                Url = "http://bit.ly/1UF858z",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "WPF for the Visual Basic Programmer - Part 1",
                IntroductionDate = Convert.ToDateTime("12/1/2014"),
                Url = "http://bit.ly/1uFxS7C",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 8,
                ProductName = "WPF for the Visual Basic Programmer - Part 2",
                IntroductionDate = Convert.ToDateTime("2/11/2014"),
                Url = "http://bit.ly/1MjQ9NG",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }
    }
}

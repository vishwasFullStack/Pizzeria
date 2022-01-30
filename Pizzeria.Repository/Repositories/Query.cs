using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;
using System.Linq;
using System.Xml.Linq;

namespace Pizzeria.Repository.Repositories
{
    public class Query : IQuery
    {
        private readonly IFileStorege _fileStorege;
        string filePath = @"E:\Work\project\Pizza\Pizzeria\Document\Data\pizzaMaster.xml";
        public Query(IFileStorege fileStorege)
        {

            this._fileStorege = fileStorege;
        }

        public Crust GetCrustByID(int crustId)
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                XElement result = xElementDoc.Descendants(typeof(Crust).Name)
                                  .FirstOrDefault(el => el.Element("id") != null && el.Element("id").Value == crustId.ToString());
                if (result != null)
                {
                    return new Crust
                    {
                        CurstId = crustId,
                        name = result.Element("name").Value,
                        price = float.Parse(result.Element("price").Value),
                        isAvailable = bool.Parse(result.Element("isAvailable").Value)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Sauce GetSauceById(int sauceId)
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                XElement result = xElementDoc.Descendants(typeof(Sauce).Name)
                                  .FirstOrDefault(el => el.Element("id") != null && el.Element("id").Value == sauceId.ToString());

                if (result != null)
                {
                    return new Sauce
                    {
                        SauceId = sauceId,
                        name = result.Element("name").Value,
                        price = float.Parse(result.Element("price").Value),
                        isAvailable = bool.Parse(result.Element("isAvailable").Value)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Cheese GetCheaseById(int cheeseId)
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                XElement result = xElementDoc.Descendants(typeof(Cheese).Name)
                                  .FirstOrDefault(el => el.Element("id") != null && el.Element("id").Value == cheeseId.ToString());

                if (result != null)
                {
                    return new Cheese
                    {
                        cheeseId = cheeseId,
                        name = result.Element("name").Value,
                        price = float.Parse(result.Element("price").Value),
                        isAvailable = bool.Parse(result.Element("isAvailable").Value),
                        quantity = Convert.ToInt32(result.Element("quantity").Value)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Toppings GetToppingsById(int toppingId)
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                XElement result = xElementDoc.Descendants(typeof(Toppings).Name)
                                  .FirstOrDefault(el => el.Element("id") != null && el.Element("id").Value == toppingId.ToString());

                if (result != null)
                {
                    return new Toppings
                    {
                        toppingsId = toppingId,
                        name = result.Element("name").Value,
                        price = float.Parse(result.Element("price").Value),
                        isAvailable = bool.Parse(result.Element("isAvailable").Value),
                        quantity = Convert.ToInt32(result.Element("quantity").Value)
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}

using Microsoft.Extensions.Configuration;
using Pizzeria.Common.Model;
using Pizzeria.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Xml.Linq;

namespace Pizzeria.Repository.Repositories
{
    public class Query : IQuery
    {
        private readonly IFileStorege _fileStorege;
        string filePath;
        private readonly IConfiguration _configuration;
        public Query(IFileStorege fileStorege, IConfiguration configuration)
        {
            this._fileStorege = fileStorege;
            this._configuration = configuration;
            filePath = _configuration["PizzaMasterPath"];
        }

        /// <summary>
        /// get Curst by ID
        /// </summary>
        /// <param name="crustId"></param>
        /// <returns></returns>
        public  Crust GetCrustByID(int crustId)
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                XElement result = xElementDoc.Descendants(typeof(Crust).Name)
                                  .FirstOrDefault(el => el.Element("id") != null && el.Element("id").Value == crustId.ToString());
                if (result != null)
                {
                   var item = new Crust
                    {
                        CurstId = crustId,
                        name = result.Element("name").Value,
                        price = float.Parse(result.Element("price").Value),
                        isAvailable = bool.Parse(result.Element("isAvailable").Value)
                    };
                    return item;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /// <summary>
        /// get Sauce by ID
        /// </summary>
        /// <param name="sauceId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// get Cheese by ID
        /// </summary>
        /// <param name="cheeseId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// get Toppings by ID
        /// </summary>
        /// <param name="toppingId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get all Crust in system
        /// </summary>
        /// <param name="crustId"></param>
        /// <returns></returns>
        public IEnumerable<Crust> GetAllCrust()
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                var Crusts = (from element in xElementDoc.Descendants(typeof(Crust).Name)
                              select new Crust
                              {
                                  CurstId = Convert.ToInt32(element.Element("id").Value),
                                  name = element.Element("name").Value,
                                  price = float.Parse(element.Element("price").Value),
                                  isAvailable = bool.Parse(element.Element("isAvailable").Value)
                              }).ToList();
                return Crusts;
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        /// <summary>
        /// Get all Sauce in system
        /// </summary>
        /// <param name="crustId"></param>
        /// <returns></returns>
        public IEnumerable<Sauce> GetAllSauce()
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                var sauces = (from element in xElementDoc.Descendants(typeof(Sauce).Name)
                              select new Sauce
                              {
                                  SauceId = Convert.ToInt32(element.Element("id").Value),
                                  name = element.Element("name").Value,
                                  price = float.Parse(element.Element("price").Value),
                                  isAvailable = bool.Parse(element.Element("isAvailable").Value)
                              }).ToList();
                return sauces;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        /// <summary>
        /// Get all Cheese in system
        /// </summary>
        /// <param name="crustId"></param>
        /// <returns></returns>
        public IEnumerable<Cheese> GetAllCheese()
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                var cheeses = (from element in xElementDoc.Descendants(typeof(Cheese).Name)
                               select new Cheese
                               {
                                   cheeseId = Convert.ToInt32(element.Element("id").Value),
                                   name = element.Element("name").Value,
                                   price = float.Parse(element.Element("price").Value),
                                   quantity = Convert.ToInt32(element.Element("quantity").Value),
                                   isAvailable = bool.Parse(element.Element("isAvailable").Value)
                               }).ToList();
                return cheeses;
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        /// <summary>
        /// Get all Toppings in system
        /// </summary>
        /// <param name="crustId"></param>
        /// <returns></returns>
        public IEnumerable<Toppings> GetAllToppings()
        {
            try
            {
                XElement xElementDoc = _fileStorege.ReadXML(filePath);
                var toppings = (from element in xElementDoc.Descendants(typeof(Toppings).Name)
                                select new Toppings
                                {
                                    toppingsId = Convert.ToInt32(element.Element("id").Value),
                                    name = element.Element("name").Value,
                                    price = float.Parse(element.Element("price").Value),
                                    quantity = Convert.ToInt32(element.Element("quantity").Value),
                                    isAvailable = bool.Parse(element.Element("isAvailable").Value)
                                }).ToList();
                return toppings;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}

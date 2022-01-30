using System;
using System.IO;

using System.Xml.Linq;

namespace Pizzeria.Repository.Repositories
{
    public class FileStorege : IFileStorege
    {
        /// <summary>
        /// Read file 
        /// </summary>
        /// <param name="FilePath">xml file path</param>
        /// <returns></returns>
        public XElement ReadXML(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                XElement xElement = XElement.Load(FilePath);
                return xElement;
            }
            else
                return null;


        }

        /// <summary>
        /// Write xml update node in xml file
        /// </summary>
        /// <param name="xElement"></param>
        /// <param name="filePath"></param>
        public void WriteXML(XElement xElement, string filePath, string RootNode)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StringWriter sw = new StringWriter())
                    {
                        xElement.Save(filePath);
                    }
                }
                else
                {
                    string text = @"<?xml version=""1.0"" encoding=""utf-8""?><data></data>";
                    xElement = XElement.Parse(text);
                    using (StringWriter sw = new StringWriter())
                    {
                        xElement.Save(filePath);
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}

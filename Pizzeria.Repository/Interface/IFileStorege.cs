using System.Xml.Linq;

namespace Pizzeria.Repository.Repositories
{
    public interface IFileStorege
    {
        XElement ReadXML(string FilePath);
        void WriteXML(XElement xElement, string filePath, string RootNode);
    }
}
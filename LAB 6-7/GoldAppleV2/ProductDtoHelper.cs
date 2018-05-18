using System.IO;
using System.Xml.Serialization;

namespace GoldApple
{
    public static class ProductDtoHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(ProductRequestDto));
        public static void WriteToFile(string fileName, ProductRequestDto data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static ProductRequestDto LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (ProductRequestDto)Xs.Deserialize(fileStream);
            }
        }
    }
}
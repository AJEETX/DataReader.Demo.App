using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain.DataContentType.Xml
{
    public interface IXmlDataExtractor
    {
        IEnumerable<HorseDetail> ExtractHorseDetail(string xmlString);
    }
    public class XmlDataExtractor : IXmlDataExtractor
    {
        public IEnumerable<HorseDetail> ExtractHorseDetail(string xmlString)
        {
            //TO-DO//format/restructure the data i.e in custom structure
            return new List<HorseDetail>();

        }
    }
}

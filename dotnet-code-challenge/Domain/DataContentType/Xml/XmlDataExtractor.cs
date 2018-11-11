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
            if (xmlString == null) return null;
            IEnumerable<HorseDetail> horseDetails = null;
            try
            {
                horseDetails = ExtractDetail(xmlString);
            }
            catch (Exception)
            {
                //shout // yell // log //
            }
            return horseDetails;
        }
        IEnumerable<HorseDetail> ExtractDetail(string xmlString)
        {
            //TO-DO//format/restructure the data i.e in custom structure
            return new List<HorseDetail>();
        }
    }
}

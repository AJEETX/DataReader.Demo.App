using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain.DataContentType.Json
{
    public interface IJsonDataExtractor
    {
        IEnumerable<HorseDetail> ExtractHorseDetail(string xmlString);
    }
    public class JsonDataExtractor : IJsonDataExtractor
    {
        public IEnumerable<HorseDetail> ExtractHorseDetail(string xmlString)
        {
            //TO-DO//format/restructure the data i.e in custom structure
            return new List<HorseDetail>();
        }
    }
}

using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain.DataContentType.Json
{
    public interface IJsonDataExtractor
    {
        IEnumerable<HorseDetail> ExtractHorseDetail(string jsonString);
    }
    public class JsonDataExtractor : IJsonDataExtractor
    {
        public IEnumerable<HorseDetail> ExtractHorseDetail(string jsonString)
        {
            if (jsonString == null) return null;
            IEnumerable<HorseDetail> horseDetails = null;

            try
            {
                horseDetails = ExtractDetail(jsonString);
            }
            catch (Exception)
            {
                //shout // yell // log //
            }
            return horseDetails;
        }
        IEnumerable<HorseDetail> ExtractDetail(string jsonString)
        {
            //TO-DO//format/restructure the data i.e in custom structure
            return new List<HorseDetail>();
        }
    }
}

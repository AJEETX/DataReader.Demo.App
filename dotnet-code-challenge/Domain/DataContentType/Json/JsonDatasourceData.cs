using dotnet_code_challenge.Domain.DataContentType.Json;
using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IJsonDatasourceData : IDatasourceData { }
    public class JsonDatasourceData : DatasourceDataBase, IJsonDatasourceData
    {
        IJsonDataExtractor _jsonDataExtractor;
        public JsonDatasourceData(IDataContentReader dataContentReader,IJsonDataExtractor jsonDataExtractor) : base(dataContentReader)
        {
            _jsonDataExtractor = jsonDataExtractor;
        }
        List<HorseDetail> horseDetails = new List<HorseDetail>();
        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            if (filesname == null) return null;

            //read the json files
            foreach (var filePath in filesname.FileNames)
            {
                //get content and read each file
                var jsonString = _dataContentReader.GetDataContent(filePath);

                //TO-DO //format/restructure the data i.e in custom structure                
                horseDetails.AddRange(_jsonDataExtractor.ExtractHorseDetail(jsonString));


            }
            return horseDetails;
        }


    }
}

using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDatasourceData
    {
        IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname);
    }


    public interface IJsonDatasourceData : IDatasourceData { }
    public class JsonDatasourceData : IJsonDatasourceData
    {
        IDataContentReader _dataContentReader;
        public JsonDatasourceData(IDataContentReader dataContentReader)
        {
            _dataContentReader = dataContentReader;
        }
        List<HorseDetail> horseDetails = new List<HorseDetail>();
        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            //read the json files
            foreach (var filePath in filesname.FileNames)
            {
                //get content and read each file
                var jsonString = _dataContentReader.GetDataContent(filePath);

                //format/restructure the data i.e in custom structure
            }
            throw new NotImplementedException();
        }


    }


    public interface IXmlDatasourceData : IDatasourceData { }

    public class XmlDatasourceData : IXmlDatasourceData
    {
        IDataContentReader _dataContentReader;
        public XmlDatasourceData(IDataContentReader dataContentReader)
        {
            _dataContentReader = dataContentReader;
        }

        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            //read the xml files
            foreach (var filePath in filesname.FileNames)
            {
                //get content and read each file
                var jsonString = _dataContentReader.GetDataContent(filePath);

                //format/restructure the data i.e in custom structure
            }
            throw new NotImplementedException();
        }
    }
}

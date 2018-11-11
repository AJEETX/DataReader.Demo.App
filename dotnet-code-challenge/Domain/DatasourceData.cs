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
        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            throw new NotImplementedException();
        }
    }


    public interface IXmlDatasourceData : IDatasourceData { }

    public class XmlDatasourceData : IXmlDatasourceData
    {
        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            throw new NotImplementedException();
        }
    }
}

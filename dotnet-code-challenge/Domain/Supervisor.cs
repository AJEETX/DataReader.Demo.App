using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface ISupervisor
    {
        IEnumerable<HorseDetail> GetHorses(DatasourceDetail datasource);
    }
    public class Supervisor : ISupervisor
    {
        Dictionary<FileType, IDatasourceData> DatasourceDictionary = new Dictionary<FileType, IDatasourceData>();
        IJsonDatasourceData _jsonDatasourceData;
        IXmlDatasourceData _xmlDatasourceData;
        public Supervisor(IJsonDatasourceData jsonDatasourceData,IXmlDatasourceData xmlDatasourceData)
        {
            _jsonDatasourceData = jsonDatasourceData;
            _xmlDatasourceData = xmlDatasourceData;
        }
        public IEnumerable<HorseDetail> GetHorses(DatasourceDetail datasource)
        {
            if (datasource == null) return null;

            IEnumerable<HorseDetail> horsesDetailList = null;
            try
            {
                Get();
                return horsesDetailList= DatasourceDictionary[datasource.FileType].ReadHorseDetail(datasource.FilesName);
            }
            catch (Exception e)
            {
                //shout // yell // log //
            }
            return null;
        }


        void Get()
        {
            DatasourceDictionary.Add(FileType.JSON, _jsonDatasourceData);
            DatasourceDictionary.Add(FileType.XML, _xmlDatasourceData);
        }
    }
}

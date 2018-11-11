using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IXmlDatasourceData : IDatasourceData { }

    public class XmlDatasourceData : DatasourceDataBase, IXmlDatasourceData
    {
        public XmlDatasourceData(IDataContentReader dataContentReader) : base(dataContentReader)
        {
        }

        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            //read the xml files
            foreach (var filePath in filesname.FileNames)
            {
                //get content and read each file
                var jsonString = _dataContentReader.GetDataContent(filePath);

                //TO-DO//format/restructure the data i.e in custom structure
            }
            return new List<HorseDetail>();
        }
    }
}

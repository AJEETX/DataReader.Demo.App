using dotnet_code_challenge.Domain.DataContentType.Xml;
using dotnet_code_challenge.Models;
using System.Collections.Generic;

namespace dotnet_code_challenge.Domain
{
    public interface IXmlDatasourceData : IDatasourceData { }

    public class XmlDatasourceData : DatasourceDataBase, IXmlDatasourceData
    {
        IXmlDataExtractor _xmlDataExtractor;
        List<HorseDetail> horseDetails = new List<HorseDetail>();
        public XmlDatasourceData(IDataContentReader dataContentReader, IXmlDataExtractor xmlDataExtractor) : base(dataContentReader)
        {
            _xmlDataExtractor = xmlDataExtractor;
        }

        public IEnumerable<HorseDetail> ReadHorseDetail(FileNameList filesname)
        {
            //read the xml files
            foreach (var filePath in filesname.FileNames)
            {
                //get content and read each file
                var xmlString = _dataContentReader.GetDataContent(filePath);

                horseDetails.AddRange(_xmlDataExtractor.ExtractHorseDetail(xmlString));

            }
            return horseDetails;
        }
    }
}

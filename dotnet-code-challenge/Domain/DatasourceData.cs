using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDatasourceData
    {
        IEnumerable<HorseDetail> ReadHorseDetail(IEnumerable<string> filesname);
    }
    public class XmlDatasourceData : IDatasourceData
    {
        public IEnumerable<HorseDetail> ReadHorseDetail(IEnumerable<string> filesname)
        {
            throw new NotImplementedException();
        }
    }
}

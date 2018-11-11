using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDatasourceManager
    {
        IEnumerable<DatasourceDetail> GetDatasources();
    }
    public class DatasourceManager : IDatasourceManager
    {
        public IEnumerable<DatasourceDetail> GetDatasources()
        {
            throw new NotImplementedException();
        }
    }
}

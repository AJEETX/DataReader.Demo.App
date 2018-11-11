using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Helper
{
    public interface IDatasourceDetailsProvider
    {
        List<DatasourceDetail> GetDatasourceDetails();
    }
    class DatasourceDetailsProvider
    {
        List<DatasourceDetail> Datasources = new List<DatasourceDetail>();

    }
}

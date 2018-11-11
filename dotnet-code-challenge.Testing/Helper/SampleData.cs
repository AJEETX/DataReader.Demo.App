using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Testing.Helper
{
    class SampleData
    {
        public static DatasourceDetail GetListOfDatasourceDetail()
        {
            var list = new List<string>();
            var input = new DatasourceDetail(FileType.JSON, new FileNameList(list));
            return input;
        }
    }
}

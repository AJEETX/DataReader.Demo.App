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

    public abstract class DatasourceDataBase
    {
        protected IDataContentReader _dataContentReader;
        public DatasourceDataBase(IDataContentReader dataContentReader)
        {
            _dataContentReader = dataContentReader;
        }
    }
}

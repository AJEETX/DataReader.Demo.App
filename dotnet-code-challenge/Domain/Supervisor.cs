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
        public IEnumerable<HorseDetail> GetHorses(DatasourceDetail datasource)
        {
            throw new NotImplementedException();
        }
    }
}

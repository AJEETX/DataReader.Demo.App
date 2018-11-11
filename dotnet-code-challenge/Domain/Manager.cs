using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_code_challenge.Domain
{
    public interface IManager
    {
        IEnumerable<HorseDetail> GetHorses();
    }
    public class Manager : IManager
    {
        IDatasourceManager _datasourceManager;
        ISupervisor _supervisor;
        List<HorseDetail> _horseDetails = new List<HorseDetail>();
        public Manager(IDatasourceManager datasourceManager,ISupervisor supervisor)
        {
            _datasourceManager = datasourceManager;
            _supervisor = supervisor;
        }
        public IEnumerable<HorseDetail> GetHorses()
        {
            try
            {
                var datasources = GetDatasources();
                if (datasources == null) return null;
                GetHorseDetails(datasources).OrderBy(h=>h.Price);
            }
            catch(Exception e)
            {
                //shout // yell // log //
            }
            return _horseDetails;
        }

        IEnumerable<DatasourceDetail> GetDatasources()
        {
            return _datasourceManager.GetDatasourcesDetails();
        }
        IEnumerable<HorseDetail> GetHorseDetails(IEnumerable<DatasourceDetail> datasourceDetails)
        {
            foreach (var datasourceDetail in datasourceDetails)
            {
                _horseDetails.AddRange(_supervisor.GetHorses(datasourceDetail));
            }
            return _horseDetails;
        }
    }
}

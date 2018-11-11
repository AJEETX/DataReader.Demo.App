using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            var datasources = GetDatasources();
            return GetHorseDetails(datasources);
        }

        IEnumerable<DatasourceDetail> GetDatasources()
        {
            return _datasourceManager.GetDatasources();
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

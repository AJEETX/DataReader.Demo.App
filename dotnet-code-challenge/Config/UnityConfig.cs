using dotnet_code_challenge.Domain;
using dotnet_code_challenge.Domain.DataContentType.Json;
using dotnet_code_challenge.Domain.DataContentType.Xml;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace dotnet_code_challenge.Config
{
    public class UnityConfig
    {
        public static IManager GetManager()
        {
            var container = new UnityContainer();

            container.RegisterType<IManager, Manager>();
            container.RegisterType<IDatasourceManager, DatasourceManager>();
            container.RegisterType<ISupervisor, Supervisor>();
            container.RegisterType<IXmlDatasourceData, XmlDatasourceData>();
            container.RegisterType<IXmlDataExtractor, XmlDataExtractor>();
            container.RegisterType<IJsonDatasourceData, JsonDatasourceData>();
            container.RegisterType<IJsonDataExtractor, JsonDataExtractor>();
            container.RegisterType<IDataContentReader, DataContentReader>();
            return container.Resolve<IManager>();
        }

    }
}

using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDatasourceManager
    {
        IEnumerable<DatasourceDetail> GetDatasources();
    }
    public class DatasourceManager : IDatasourceManager
    {
        List<DatasourceDetail> Datasources = new List<DatasourceDetail>();

        public DatasourceManager()
        {
            Datasources.Add(new DatasourceDetail(FileType.JSON, Getfile("*.json")));
            Datasources.Add(new DatasourceDetail(FileType.XML, Getfile("*.xml")));
        }
        public IEnumerable<DatasourceDetail> GetDatasources()
        {
            return Datasources;
        }

        IEnumerable<string> Getfile(string regex)
        {
            var filePath = Environment.CurrentDirectory + @"\FeedData";
            var files = Directory.Exists(filePath) ? Directory.EnumerateFiles(filePath, regex) : null;
            return files;
        }
    }
}

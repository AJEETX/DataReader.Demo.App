using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDatasourceManager
    {
        IEnumerable<DatasourceDetail> GetDatasourcesDetails();
    }
    public class DatasourceManager : IDatasourceManager
    {
        List<DatasourceDetail> Datasources=new List<DatasourceDetail>();
        string filePath = Environment.CurrentDirectory + @"\FeedData";

        public IEnumerable<DatasourceDetail> GetDatasourcesDetails()
        {
            return Datasources;
        }
        void GetDatasources()
        {
            Datasources.Add(new DatasourceDetail(FileType.JSON, Getfile("*.json")));

            Datasources.Add(new DatasourceDetail(FileType.XML, Getfile("*.json")));
        }
        FileNameList Getfile(string regex)
        {
            var files = Directory.Exists(filePath) ? Directory.EnumerateFiles(filePath, regex) : null;

            if( files == null) return null;

            return new FileNameList(files);
        }
    }
}

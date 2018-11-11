using dotnet_code_challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using System.IO;

namespace dotnet_code_challenge.Testing.Helper
{
    class SampleData
    {
        static string filePath = Environment.CurrentDirectory + @"\FeedData";

        public static DatasourceDetail GetListOfDatasourceDetail()
        {
            var input = new DatasourceDetail(FileType.JSON, Getfile("*.json"));
            return input;
        }
        static FileNameList Getfile(string regex)
        {
            var files = Directory.Exists(filePath) ? Directory.EnumerateFiles(filePath, regex) : null;

            if (files == null) return null;

            return new FileNameList(files);
        }
    }
}

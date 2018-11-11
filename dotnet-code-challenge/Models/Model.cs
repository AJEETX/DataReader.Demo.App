using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Models
{
    public class HorseDetail
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public enum FileType
    {
        JSON,
        XML
    }
    public class DatasourceDetail
    {
        public FileType FileType { get; set; }
        public IEnumerable<string> FilesName { get; set; }
        public DatasourceDetail(FileType fileType,IEnumerable<string> filesName) 
        {
            FileType = fileType;
            FilesName = filesName;
        }
    }
}

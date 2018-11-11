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
        public FileType FileType { get;private set; }
        public FileNameList FilesName { get;private set; }
        public DatasourceDetail(FileType fileType, FileNameList filesName) 
        {
            FileType = fileType;
            FilesName = filesName;
        }
    }
    public class FileNameList
    {
        public IEnumerable<string> FileNames { get; set; }
        public FileNameList(IEnumerable<string> fileNames)
        {
            FileNames = fileNames;
        }
    }
}

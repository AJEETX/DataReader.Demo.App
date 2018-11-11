using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dotnet_code_challenge.Domain
{
    public interface IDataContentReader
    {
        string GetDataContent(string filepath);
    }
    class DataContentReader : IDataContentReader
    {
        public string GetDataContent(string filepath)
        {
            return File.ReadAllText(filepath);
        }
    }
}

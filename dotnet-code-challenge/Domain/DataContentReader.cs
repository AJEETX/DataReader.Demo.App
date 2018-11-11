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
            if (filepath == null) return null;
            string fileData = null;
            try
            {
                fileData= File.ReadAllText(filepath); 
            }
            catch (Exception)
            {
                //shout // yell // log //
            }
            return fileData;
        }
    }
}

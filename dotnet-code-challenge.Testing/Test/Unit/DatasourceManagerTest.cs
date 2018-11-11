using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Domain;
using dotnet_code_challenge.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_code_challenge.Testing.Test.Unit
{
    [TestClass]
    public class DatasourceManagerTest
    {
        [TestMethod]
        public void get_datasources_returns_list_of_defined_files_with_types_and_filenames_succesfully()
        {

            //gievn
            var sut = new DatasourceManager();

            //when
            var result = sut.GetDatasources();

            //then
            Assert.IsInstanceOfType(result, typeof(IEnumerable<DatasourceDetail>));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Testing.Helper;

namespace dotnet_code_challenge.Testing.Test.Unit
{
    [TestClass]
    public class SupervisorTest
    {
        [TestMethod]
        public void get_horses_with_given_datasour_list_returns_list_of_horses_in_ascending_successfully()
        {
            //given
            var input = SampleData.GetListOfDatasourceDetail();
            var sut = new Supervisor();

            //when
            var result = sut.GetHorses(input);

            //then
            Assert.IsInstanceOfType(result, typeof(IEnumerable<HorseDetail>));


        }
    }
}

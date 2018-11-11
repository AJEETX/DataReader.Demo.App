using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Testing.Helper;
using Moq;

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

            var moqJsonsourceData = new Mock<IJsonDatasourceData>();
            moqJsonsourceData.Setup(m => m.ReadHorseDetail(It.IsAny<FileNameList>())).Returns(new List<HorseDetail>());

            var moqXmlJsonsourceData = new Mock<IXmlDatasourceData>();
            moqXmlJsonsourceData.Setup(m => m.ReadHorseDetail(It.IsAny<FileNameList>())).Returns(new List<HorseDetail>());

            var sut = new Supervisor(moqJsonsourceData.Object,moqXmlJsonsourceData.Object);

            //when
            var result = sut.GetHorses(input);

            //then
            Assert.IsInstanceOfType(result, typeof(IEnumerable<HorseDetail>));


        }
    }
}

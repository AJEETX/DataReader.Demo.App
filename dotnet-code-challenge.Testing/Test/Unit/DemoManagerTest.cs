using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_code_challenge.Domain;
using dotnet_code_challenge.Models;
using Moq;

namespace dotnet_code_challenge.Testing.Test.Unit
{
    [TestClass]
    public class DemoManagerTest
    {
        [TestMethod]
        public void get_horse_displays_list_of_horses_name_with_price()
        {
            //given
            var moqDatasourceManager = new Mock<IDatasourceManager>();
            moqDatasourceManager.Setup(m => m.GetDatasourcesDetails()).Returns(new List<DatasourceDetail>());

            var moqSupervisor = new Mock<ISupervisor>();
            moqSupervisor.Setup(m => m.GetHorses(It.IsAny<DatasourceDetail>())).Returns(new List<HorseDetail>());

            var sut = new Manager(moqDatasourceManager.Object, moqSupervisor.Object);

            //when
            var result = sut.GetHorses();

            //then
            Assert.IsInstanceOfType(result, typeof(IEnumerable<HorseDetail>));
        }
    }
}

using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineOfBands.Common.Test
{
    [TestClass]
    public class PalletTest
    {
        private Line _line;

        [TestInitialize]
        public void InicializarConexionBd()
        {
            SqlServer.ConnectionString = "Server=localhost;Database=LineOfBands;User Id=sa;Password=1234;";
            _line = new Line { Id = 1, Code = 1 };
        }

        [TestMethod]
        public void AñadirNuevoPallet()
        {
            var newPallet = new Pallet
            {
                Code = 3,
                Line = _line
            };

            newPallet = PalletRepository.SaveOrUpdate(newPallet);
            Assert.AreEqual(newPallet.Code, 1);         
        }

        [TestMethod]
        public void ActualizarPallet()
        {
            //var pallet3 = PalletRepository.GetByCode(4, _line);
            //pallet3.Code = 3;
            //pallet3 = PalletRepository.SaveOrUpdate(pallet3);
            //Assert.AreEqual(pallet3.Code, 3);
        }

        [TestMethod]
        public void ObtenerPallet1DeLaLinea1()
        {
            //var pallet1 = PalletRepository.GetByCode(1, _line);
            //Assert.AreEqual(pallet1.Code, 1);
        }
    }
}

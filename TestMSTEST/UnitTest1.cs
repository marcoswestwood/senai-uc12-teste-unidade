using Projeto_teste;

namespace TestMSTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(400, 30, 430)]
        [DataRow(872, 6, 878)]
        [DataRow(10, 23, 33)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [TestMethod]
        public void SubtrairDoisNumeros()
        {
            //Arrange = preparação
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;

            //Act
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(500, 200, 300)]
        [DataRow(250, 52, 198)]
        [DataRow(1540, 40, 1500)]
        [DataRow(444, 34, 410)]
        [DataRow(100, 102, -2)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert - verificacao
            Assert.AreEqual(rNum, resultado);
        }


    }
}
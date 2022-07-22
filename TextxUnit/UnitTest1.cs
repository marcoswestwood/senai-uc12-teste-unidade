using Projeto_teste;

namespace TextxUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;


            //Act - Açao
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(82, 1, 83)]
        [InlineData(1000, 400, 1400)]
        [InlineData(2300, 150, 2450)]
        [InlineData(4678, 4300, 8978)]
        [InlineData(150, 180, 330)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
        [Fact]
        public void SubtrairDoisNumeros()
        {
            //Arrange
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;

            // Act
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
        [Theory]
        [InlineData(180, 80, 100)]
        [InlineData(198, 90, 108)]
        [InlineData(562, 3, 559)]
        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = Operacoes.Subtrair(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);
        }
    }
}
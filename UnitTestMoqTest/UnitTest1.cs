using UnitTestMoq;

namespace UnitTestMoqTest
{
    public class UnitTest1
    {
        [Fact]
        public void Somar_doisNumeros()
        {
            //Arrange
            Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
            mock.Setup(x => x.Calcular("somar", 1, 2)).Returns(("somar", 3));

            MaquinaCalculadora maquina = new MaquinaCalculadora(mock.Object);

            //Act
            var resultado = maquina.Calcular("somar", 1, 2);

            //Assert
            Assert.Equal(("somar", 3), resultado);
            Assert.Equal(3, resultado.resultado);
        }
    }
}
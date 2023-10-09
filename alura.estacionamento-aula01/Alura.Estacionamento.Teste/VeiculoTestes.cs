using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Teste
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaVeiculoAcelerar()
        {
            //Arrange: preparação do cénario, por exemplo, para acelerar preciso de um veiculo
            var veiculo = new Veiculo();
            //Act:metodo que eu quero testar, no caso, acelerar ou frear
            veiculo.Acelerar(10);
            //Assert: Verificação do resultado obtido daquele metodo com o esperado
;            Assert.Equal(100, veiculo.VelocidadeAtual);   
        }
        [Fact]

        public void TestaVeiculoFrear()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Frear(10);
            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaTipoVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act            
            //Assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
        }

    }
}
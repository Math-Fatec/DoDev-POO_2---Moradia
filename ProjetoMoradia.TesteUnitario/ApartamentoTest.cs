using Xunit;
using ProjetoMoradia.Models;

namespace ProjetoMoradia.TesteUnitario
{
    public class ApartamentoTest
    {
        [Fact]
        public void ApartamentoDeveriaSerDoSegundoAndar(){
            //Arrange - Preparação
            var andarEsperado = 2;
            var apto = new Apartamento("teste", 2222, 43, 2, 1, andarEsperado, 500);
            //Act - Agir
            var andarApto = apto.GetAndar();
            //Assert - Verficiar
            Assert.Equal(andarEsperado, andarApto);
        }

        [Fact]
        public void ApartamentoPodeTerAte3Banheiros(){
            //Arrange - Preparação
            var tresBanheiros = 3;
            var apto = new Apartamento("teste", 3 tresBanheiros);
            //Act - Agir
            var tresBanheiros = apto.GetBanheiro();
            //Assert - Verficiar
            Assert.True(tresBanheiros, apto);
        }

        [Fact]
        public void ApartamentoAte60m(){
            //Arrange - Preparação
            var TamanhoEmMetros = 60;
            var apto = new Apartamento("teste", TamanhoEmMetros, 60, metros);
            //Act - Agir
            var TamanhoEmMetros = apto.GetMetros();
            //Assert - Verficiar
            Assert.True(TamanhoEmMetros, apto);
        }

        [Fact]
        public void ApartamentoAteNoMax10Andar(){
            //Arrange - Preparação
            var andarMax10 = 10;
            var apto = new Apartamento("teste", 10, andarMax10);
            //Act - Agir
            var andarMax10 = apto.GetAndar();
            //Assert - Verficiar
            Assert.Equal(andarMax10, apto);
        }

        [Fact]
        public void KitnetPodeTerAte2Banheiros(){
            //Arrange - Preparação
            var doisBanheiros = 2;
            var kitnet = new Kitnet("teste", 2);
            //Act - Agir
            var doisBanheiros = kitnet.GetBanheiro();
            //Assert - Verficiar
            Assert.True(doisBanheiros, kitnet);
        }
        
        [Fact]
        public void KitnetAte50m(){
            //Arrange - Preparação
            var TamanhoEmMetros = 50;
            var kitnet = new Kitnet("teste", TamanhoEmMetros, 50, metros);
            //Act - Agir
            var TamanhoEmMetros = kitnet.GetMetros();
            //Assert - Verficiar
            Assert.True(TamanhoEmMetros, kitnet);
        }

        [Fact]
        public void CasaPodeTerAte5Banheiros(){
            //Arrange - Preparação
            var cincoBanheiros = 5;
            var casa = new Casa("teste", 5, cincoBanheiros);
            //Act - Agir
            var cincoBanheiros = casa.GetBanheiro();
            //Assert - Verficiar
            Assert.True(cincoBanheiros, casa);
    }

        [Fact]
        public void CasaAte100m(){
            //Arrange - Preparação
            var TamanhoEmMetros = 100;
            var casa = new Casa("teste", TamanhoEmMetros, 100, metros);
            //Act - Agir
            var TamanhoEmMetros = casa.Get();
            //Assert - Verficiar
            Assert.True(TamanhoEmMetros, casa);
        }

        [Fact]
        public void CEPComSomente8Digitos(){
            //Arrange - Preparação
            var CEP = "XXXXX-XXX";
            var CEP = new Endereço("XXXXX-XXX", CEP);
            //Act - Agir
            var CEP = endereço.GetCEP();
            //Assert - Verficiar
            Assert.False(CEP, endereço);
        }
}
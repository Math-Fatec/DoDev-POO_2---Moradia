using Xunit;
using ProjetoMoradia.Models;
using System;

namespace ProjetoMoradia.TesteUnitario;

public class MoradorTest
{
     [Fact]
    public void MoradorDeveTerDataNascimentoEsperada()
    {
        //Preparando - Arrange
        var dataNascimentoEsperada = "04/04/2004";
        var morador = new Morador("Giovanni", "44455566678", dataNascimentoEsperada);
        //DataNascimento - Act
        var dataNascimento = morador.GetDataDeNascimento();
        //Assert
        Assert.Equal(dataNascimentoEsperada, dataNascimento.ToString("dd/MM/yyyy"));
    }

     [Fact]
    public void MoradorNaoDeveTerDataNascimentoMaiorQueADataAtual()
    {
        //Preparando - Arrange
        var dataNascimento = "04/04/2023";
        var morador = new Morador("Giovanni", "44455566678", dataNascimento);
        //DataNascimento - Act
        var dataNascimentoAtual = morador.GetDataDeNascimento();
        //Assert
        Assert.Equal(DateTime.MinValue, dataNascimentoAtual);
    }

     [Fact]
    public void NomeMorador(string nome)
        {
            //Nome = nome;
        //Preparando - Arrange
        var nomeEsperado = "Lucas";
        var morador = new Morador("Lucas", nomeEsperado);
        //DataNascimento - Act
        var nome = morador.GetNome();
        //Assert
        Assert.Equal(nomeEsperado, nome.ToString("Lucas"));
        }

     [Fact]
    public string Nome()
        {
            //return Nome;
        //Preparando - Arrange
        var nome = "Lucas";
        var morador = new Morador("Lucas", nome);
        //DataNascimento - Act
        var nome = morador.GetNome();
        //Assert
        Assert.Equal(nomeEsperado, nome.ToString("Lucas"));
        }

     [Fact]
    public void SetCpfValidaçao11Digitos(string cpf)
    {
      //Cpf = cpf;
     //Preparando - Arrange
     var cpfEsperado = "XXX.XXX.XXX-XX";
     var morador = new Morador("Lucas", "XXX.XXX.XXX-XX", cpfEsperado);
     //DataNascimento - Act
     var cpf = morador.GetCpf();
     //Assert
     Assert.Equal(SetCpfValidaçao11Digitos, cpf.ToString("XXX.XXX.XXX-XX"));
    }

     [Fact]
    public void GetTesteVerificandoCPFInvalidoPraTesterSeSalvaEm11Digitos()
    {
      //return Cpf;
      //Cpf invalido
     //Preparando - Arrange
     var cpf = "XXX.XXX.XXX-XX";
     var morador = new Morador("Lucas", "XXX.XXX.XXX-XX", cpf);
     //DataNascimento - Act
     var cpfAtual = morador.GetCpf();
     //Assert
     Assert.True(cpfEsperado, cpfAtual);
    }
}

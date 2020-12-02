using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Models.Robos;

namespace Robo.Tests.Robos
{
    [TestClass]
    public class CabecaTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var cabeca = Cabeca.Criar();

            Assert.IsNotNull(cabeca);
            Assert.AreEqual(cabeca.Posicao, Cabeca.EmRepouco);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoEmRepouso);
        }

        [TestMethod]
        public void DeveRotacionar()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao(Cabeca.RotacaoQuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoQuarentaECincoGraus);

            cabeca.SetarRotacao(Cabeca.RotacaoNoventaGraus);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoNoventaGraus);

            cabeca.SetarRotacao(Cabeca.RotacaoQuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoQuarentaECincoGraus);

            cabeca.SetarRotacao(Cabeca.RotacaoEmRepouso);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoEmRepouso);

            cabeca.SetarRotacao(Cabeca.RotacaoQuarentaECincoGrausNegativo);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoQuarentaECincoGrausNegativo);

            cabeca.SetarRotacao(Cabeca.RotacaoNoventaGrausNegativo);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoNoventaGrausNegativo);
        }

        [TestMethod]
        public void NaoDeveRotacionarComPosicaoParaBaixo()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarPosicao(Cabeca.ParaBaixo);

            cabeca.SetarRotacao(Cabeca.RotacaoQuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoEmRepouso);
        }

        [TestMethod]
        public void NaoDeveRotacionarComOpcaoInexistente()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao(10);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoEmRepouso);
        }

        [TestMethod]
        public void NaoDeveRotacionarComOpcaoInvalida()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao(Cabeca.RotacaoNoventaGraus);
            Assert.AreEqual(cabeca.Rotacao, Cabeca.RotacaoEmRepouso);
        }

        [TestMethod]
        public void DeveInclinar()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarPosicao(Cabeca.ParaBaixo);
            Assert.AreEqual(cabeca.Posicao, Cabeca.ParaBaixo);

            cabeca.SetarPosicao(Cabeca.EmRepouco);
            Assert.AreEqual(cabeca.Posicao, Cabeca.EmRepouco);

            cabeca.SetarPosicao(Cabeca.ParaCima);
            Assert.AreEqual(cabeca.Posicao, Cabeca.ParaCima);
        }

        [TestMethod]
        public void NaoDeveInclinarComOpcaoInexistente()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarPosicao(5);
            Assert.AreEqual(cabeca.Posicao, Cabeca.EmRepouco);
        }

        [TestMethod]
        public void NaoDeveInclinarComOpcaoInvalida()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarPosicao(Cabeca.ParaBaixo);
            Assert.AreEqual(cabeca.Posicao, Cabeca.ParaBaixo);

            cabeca.SetarPosicao(Cabeca.ParaCima);
            Assert.AreEqual(cabeca.Posicao, Cabeca.ParaBaixo);
        }
    }
}
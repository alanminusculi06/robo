using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Infraestrutura.Enums.Cabecas;
using Robo.Models;

namespace Robo.Tests
{
    [TestClass]
    public class CabecaTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var cabeca = Cabeca.Criar();

            Assert.IsNotNull(cabeca);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.EmRepouso);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);
        }

        [TestMethod]
        public void DeveRotacionar()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao(CabecaRotacao.QuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.QuarentaECincoGraus);

            cabeca.SetarRotacao(CabecaRotacao.NoventaGraus);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.NoventaGraus);

            cabeca.SetarRotacao(CabecaRotacao.QuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.QuarentaECincoGraus);

            cabeca.SetarRotacao(CabecaRotacao.EmRepouso);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);

            cabeca.SetarRotacao(CabecaRotacao.QuarentaECincoGrausNegativo);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.QuarentaECincoGrausNegativo);

            cabeca.SetarRotacao(CabecaRotacao.NoventaGrausNegativo);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.NoventaGrausNegativo);
        }

        [TestMethod]
        public void NaoDeveRotacionarComPosicaoParaBaixo()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarInclinacao(CabecaInclinacao.ParaBaixo);

            cabeca.SetarRotacao(CabecaRotacao.QuarentaECincoGraus);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveRotacionarComOpcaoInexistente()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao((CabecaRotacao)10);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveRotacionarComOpcaoInvalida()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarRotacao(CabecaRotacao.NoventaGraus);
            Assert.AreEqual(cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);
        }

        [TestMethod]
        public void DeveInclinar()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarInclinacao(CabecaInclinacao.ParaBaixo);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.ParaBaixo);

            cabeca.SetarInclinacao(CabecaInclinacao.EmRepouso);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.EmRepouso);

            cabeca.SetarInclinacao(CabecaInclinacao.ParaCima);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.ParaCima);
        }

        [TestMethod]
        public void NaoDeveInclinarComOpcaoInexistente()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarInclinacao((CabecaInclinacao)5);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveInclinarComOpcaoInvalida()
        {
            var cabeca = Cabeca.Criar();

            cabeca.SetarInclinacao(CabecaInclinacao.ParaBaixo);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.ParaBaixo);

            cabeca.SetarInclinacao(CabecaInclinacao.ParaCima);
            Assert.AreEqual(cabeca.Posicao, (int)CabecaInclinacao.ParaBaixo);
        }
    }
}
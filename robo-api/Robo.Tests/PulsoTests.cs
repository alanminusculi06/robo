using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Infraestrutura.Enums.Bracos;
using Robo.Models;

namespace Robo.Tests
{
    [TestClass]
    public class PulsoTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }

        [TestMethod]
        public void DeveAlterarPosicao()
        {
            var pulso = Pulso.Criar();

            pulso.SetarPosicao(PulsoRotacao.QuarentaECincoGrausNegativo);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.QuarentaECincoGrausNegativo);

            pulso.SetarPosicao(PulsoRotacao.NoventaGrausNegativo);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.NoventaGrausNegativo);

            pulso.SetarPosicao(PulsoRotacao.QuarentaECincoGrausNegativo);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.QuarentaECincoGrausNegativo);

            pulso.SetarPosicao(PulsoRotacao.EmRepouso);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);

            pulso.SetarPosicao(PulsoRotacao.QuarentaECincoGraus);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.QuarentaECincoGraus);

            pulso.SetarPosicao(PulsoRotacao.NoventaGraus);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.NoventaGraus);

            pulso.SetarPosicao(PulsoRotacao.CentoETrintaECincoGraus);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.CentoETrintaECincoGraus);

            pulso.SetarPosicao(PulsoRotacao.CentoEOitentaGraus);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.CentoEOitentaGraus);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInexistente()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.IsNotNull(pulso.Posicao);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);

            pulso.SetarPosicao((PulsoRotacao)10);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInvalida()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.IsNotNull(pulso.Posicao);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);

            pulso.SetarPosicao((PulsoRotacao)3);
            Assert.AreEqual(pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }
    }
}
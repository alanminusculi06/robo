using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Models.Robos;

namespace Robo.Tests.Robos
{
    [TestClass]
    public class PulsoTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void DeveAlterarPosicao()
        {
            var pulso = Pulso.Criar();

            pulso.SetarPosicao(2);
            Assert.AreEqual(pulso.Posicao, Pulso.QuarentaECincoGrausNegativo);

            pulso.SetarPosicao(1);
            Assert.AreEqual(pulso.Posicao, Pulso.NoventaGrausNegativo);

            pulso.SetarPosicao(2);
            Assert.AreEqual(pulso.Posicao, Pulso.QuarentaECincoGrausNegativo);

            pulso.SetarPosicao(3);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);

            pulso.SetarPosicao(4);
            Assert.AreEqual(pulso.Posicao, Pulso.QuarentaECincoGraus);

            pulso.SetarPosicao(5);
            Assert.AreEqual(pulso.Posicao, Pulso.NoventaGraus);

            pulso.SetarPosicao(6);
            Assert.AreEqual(pulso.Posicao, Pulso.CentoETrintaECincoGraus);

            pulso.SetarPosicao(7);
            Assert.AreEqual(pulso.Posicao, Pulso.CentoEOitentaGraus);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInexistente()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.IsNotNull(pulso.Posicao);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);

            pulso.SetarPosicao(10);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInvalida()
        {
            var pulso = Pulso.Criar();

            Assert.IsNotNull(pulso);
            Assert.IsNotNull(pulso.Posicao);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);

            pulso.SetarPosicao(3);
            Assert.AreEqual(pulso.Posicao, Pulso.EmRepouso);
        }
    }
}
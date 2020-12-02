using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Models;

namespace Robo.Tests
{
    [TestClass]
    public class CotoveloTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var cotovelo = Cotovelo.Criar();

            Assert.IsNotNull(cotovelo);
            Assert.IsNotNull(cotovelo.Posicao);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.EmRepouso);
        }

        [TestMethod]
        public void DeveAlterarPosicao()
        {
            var cotovelo = Cotovelo.Criar();

            cotovelo.SetarPosicao(2);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.LevementeContraido);

            cotovelo.SetarPosicao(3);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.Contraido);

            cotovelo.SetarPosicao(4);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.FortementeContraido);

            cotovelo.SetarPosicao(3);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.Contraido);

            cotovelo.SetarPosicao(2);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.LevementeContraido);

            cotovelo.SetarPosicao(1);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInexistente()
        {
            var cotovelo = Cotovelo.Criar();

            cotovelo.SetarPosicao(5);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInvalida()
        {
            var cotovelo = Cotovelo.Criar();

            Assert.IsNotNull(cotovelo);
            Assert.IsNotNull(cotovelo.Posicao);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.EmRepouso);

            cotovelo.SetarPosicao(3);
            Assert.AreEqual(cotovelo.Posicao, Cotovelo.EmRepouso);
        }
    }
}
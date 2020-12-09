using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Infraestrutura.Enums.Bracos;
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
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
        }

        [TestMethod]
        public void DeveAlterarPosicao()
        {
            var cotovelo = Cotovelo.Criar();

            cotovelo.SetarPosicao(CotoveloPosicao.LevementeContraido);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.LevementeContraido);

            cotovelo.SetarPosicao(CotoveloPosicao.Contraido);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.Contraido);

            cotovelo.SetarPosicao(CotoveloPosicao.FortementeContraido);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.FortementeContraido);

            cotovelo.SetarPosicao(CotoveloPosicao.Contraido);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.Contraido);

            cotovelo.SetarPosicao(CotoveloPosicao.LevementeContraido);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.LevementeContraido);

            cotovelo.SetarPosicao(CotoveloPosicao.EmRepouso);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInexistente()
        {
            var cotovelo = Cotovelo.Criar();

            cotovelo.SetarPosicao((CotoveloPosicao)5);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveAlterarPosicaoComOpcaoInvalida()
        {
            var cotovelo = Cotovelo.Criar();

            Assert.IsNotNull(cotovelo);
            Assert.IsNotNull(cotovelo.Posicao);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);

            cotovelo.SetarPosicao((CotoveloPosicao)3);
            Assert.AreEqual(cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Infraestrutura.Enums.Bracos;
using Robo.Models;

namespace Robo.Tests
{
    [TestClass]
    public class BracoTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var braco = Braco.Criar();

            Assert.IsNotNull(braco);
            Assert.IsNotNull(braco.Pulso);
            Assert.IsNotNull(braco.Cotovelo);
            Assert.AreEqual(braco.Cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
            Assert.AreEqual(braco.Pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveMovimentarPulsoComPosicaoCotoveloDiferenteDeFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarPulso(PulsoRotacao.QuarentaECincoGraus);
            Assert.AreEqual(braco.Pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }

        [TestMethod]
        public void DeveMovimentarPulsoComPosicaoCotoveloFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarCotovelo(CotoveloPosicao.LevementeContraido);
            braco.MovimentarCotovelo(CotoveloPosicao.Contraido);
            braco.MovimentarCotovelo(CotoveloPosicao.FortementeContraido);

            braco.MovimentarPulso(PulsoRotacao.QuarentaECincoGraus);
            Assert.AreEqual(braco.Pulso.Posicao, (int)PulsoRotacao.QuarentaECincoGraus);
        }
    }
}
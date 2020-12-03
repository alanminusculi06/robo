using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(braco.Cotovelo.Posicao, Cotovelo.EmRepouso);
            Assert.AreEqual(braco.Pulso.Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveMovimentarPulsoComPosicaoCotoveloDiferenteDeFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarPulso(Pulso.QuarentaECincoGraus);
            Assert.AreEqual(braco.Pulso.Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void DeveMovimentarPulsoComPosicaoCotoveloFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarCotovelo(Cotovelo.LevementeContraido);
            braco.MovimentarCotovelo(Cotovelo.Contraido);
            braco.MovimentarCotovelo(Cotovelo.FortementeContraido);

            braco.MovimentarPulso(Pulso.QuarentaECincoGraus);
            Assert.AreEqual(braco.Pulso.Posicao, Pulso.QuarentaECincoGraus);
        }
    }
}
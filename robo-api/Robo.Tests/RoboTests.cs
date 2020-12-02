using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Models;

namespace Robo.Tests
{
    [TestClass]
    public class RoboTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var robo = Models.Robo.Criar();

            Assert.IsNotNull(robo);
            Assert.IsNotNull(robo.Cabeca);
            Assert.AreEqual(robo.Cabeca.Posicao, Cabeca.EmRepouco);
            Assert.AreEqual(robo.Cabeca.Rotacao, Cabeca.RotacaoEmRepouso);
            Assert.IsNotNull(robo.BracoEsquerdo);
            Assert.IsNotNull(robo.BracoEsquerdo.GetCotovelo());
            Assert.AreEqual(robo.BracoEsquerdo.GetCotovelo().Posicao, Cotovelo.EmRepouso);
            Assert.IsNotNull(robo.BracoEsquerdo.GetPulso());
            Assert.AreEqual(robo.BracoEsquerdo.GetPulso().Posicao, Pulso.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito);
            Assert.IsNotNull(robo.BracoDireito.GetCotovelo());
            Assert.AreEqual(robo.BracoDireito.GetCotovelo().Posicao, Cotovelo.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito.GetPulso());
            Assert.AreEqual(robo.BracoDireito.GetPulso().Posicao, Pulso.EmRepouso);
        }
    }
}
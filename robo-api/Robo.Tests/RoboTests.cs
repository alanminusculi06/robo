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
            Assert.IsNotNull(robo.BracoEsquerdo.Cotovelo);
            Assert.AreEqual(robo.BracoEsquerdo.Cotovelo.Posicao, Cotovelo.EmRepouso);
            Assert.IsNotNull(robo.BracoEsquerdo.Pulso);
            Assert.AreEqual(robo.BracoEsquerdo.Pulso.Posicao, Pulso.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito);
            Assert.IsNotNull(robo.BracoDireito.Cotovelo);
            Assert.AreEqual(robo.BracoDireito.Cotovelo.Posicao, Cotovelo.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito.Pulso);
            Assert.AreEqual(robo.BracoDireito.Pulso.Posicao, Pulso.EmRepouso);
        }
    }
}
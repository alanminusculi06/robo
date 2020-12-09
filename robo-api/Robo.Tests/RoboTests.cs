using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Infraestrutura.Enums.Bracos;
using Robo.Infraestrutura.Enums.Cabecas;

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
            Assert.AreEqual(robo.Cabeca.Posicao, (int)CabecaInclinacao.EmRepouso);
            Assert.AreEqual(robo.Cabeca.Rotacao, (int)CabecaRotacao.EmRepouso);
            Assert.IsNotNull(robo.BracoEsquerdo);
            Assert.IsNotNull(robo.BracoEsquerdo.Cotovelo);
            Assert.AreEqual(robo.BracoEsquerdo.Cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
            Assert.IsNotNull(robo.BracoEsquerdo.Pulso);
            Assert.AreEqual(robo.BracoEsquerdo.Pulso.Posicao, (int)PulsoRotacao.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito);
            Assert.IsNotNull(robo.BracoDireito.Cotovelo);
            Assert.AreEqual(robo.BracoDireito.Cotovelo.Posicao, (int)CotoveloPosicao.EmRepouso);
            Assert.IsNotNull(robo.BracoDireito.Pulso);
            Assert.AreEqual(robo.BracoDireito.Pulso.Posicao, (int)PulsoRotacao.EmRepouso);
        }
    }
}
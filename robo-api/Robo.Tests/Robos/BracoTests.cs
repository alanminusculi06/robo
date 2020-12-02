﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robo.Models.Robos;

namespace Robo.Tests.Robos
{
    [TestClass]
    public class BracoTests
    {
        [TestMethod]
        public void DeveCriar()
        {
            var braco = Braco.Criar();

            Assert.IsNotNull(braco);
            Assert.IsNotNull(braco.GetPulso());
            Assert.IsNotNull(braco.GetCotovelo());
            Assert.AreEqual(braco.GetCotovelo().Posicao, Cotovelo.EmRepouso);
            Assert.AreEqual(braco.GetPulso().Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void NaoDeveMovimentarPulsoComPosicaoCotoveloDiferenteDeFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarPulso(Pulso.QuarentaECincoGraus);
            Assert.AreEqual(braco.GetPulso().Posicao, Pulso.EmRepouso);
        }

        [TestMethod]
        public void DeveMovimentarPulsoComPosicaoCotoveloFortementeContraido()
        {
            var braco = Braco.Criar();

            braco.MovimentarCotovelo(Cotovelo.LevementeContraido);
            braco.MovimentarCotovelo(Cotovelo.Contraido);
            braco.MovimentarCotovelo(Cotovelo.FortementeContraido);

            braco.MovimentarPulso(Pulso.QuarentaECincoGraus);
            Assert.AreEqual(braco.GetPulso().Posicao, Pulso.QuarentaECincoGraus);
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using Robo.Infraestrutura.Enums.Bracos;
using Robo.Infraestrutura.Enums.Cabecas;
using System.Collections.Generic;
using System.Linq;

namespace Robo.Controllers
{
    [Route("api/robo")]
    public class RobosController : Controller
    {
        private static readonly IList<Models.Robo> _robos = new List<Models.Robo>();

        [HttpGet]
        public Models.Robo Get()
        {
            var robo = Models.Robo.Criar();
            _robos.Add(robo);
            return robo;
        }

        [HttpGet("{id}")]
        public Models.Robo Get(string id)
        {
            var robo = _robos.FirstOrDefault(r => r.Id.Equals(id));
            if (robo == null)
                Response.StatusCode = 404;
            return robo;
        }

        [HttpPut("{id}")]
        public Models.Robo Put(string id, [FromBody]Models.Robo value)
        {
            var robo = _robos.FirstOrDefault(r => r.Id.Equals(id));
            if (robo == null)
                Response.StatusCode = 404;

            AtualizarCabeca(robo, value);
            AtualizarBracoDireito(robo, value);
            AtualizarBracoEsquerdo(robo, value);

            return robo;
        }

        private void AtualizarCabeca(Models.Robo robo, Models.Robo novo)
        {
            if (robo == null || novo == null) return;
            robo.Cabeca.SetarInclinacao((CabecaInclinacao)novo.Cabeca.Posicao);
            robo.Cabeca.SetarRotacao((CabecaRotacao)novo.Cabeca.Rotacao);
        }

        private void AtualizarBracoDireito(Models.Robo robo, Models.Robo novo)
        {
            if (robo == null || novo == null) return;
            robo.BracoDireito.MovimentarCotovelo((CotoveloPosicao)novo.BracoDireito.Cotovelo.Posicao);
            robo.BracoDireito.MovimentarPulso((PulsoRotacao)novo.BracoDireito.Pulso.Posicao);
        }

        private void AtualizarBracoEsquerdo(Models.Robo robo, Models.Robo novo)
        {
            if (robo == null || novo == null) return;
            robo.BracoEsquerdo.MovimentarCotovelo((CotoveloPosicao)novo.BracoEsquerdo.Cotovelo.Posicao);
            robo.BracoEsquerdo.MovimentarPulso((PulsoRotacao)novo.BracoEsquerdo.Pulso.Posicao);
        }
    }
}

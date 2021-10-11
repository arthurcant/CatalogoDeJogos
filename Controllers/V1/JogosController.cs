using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CatalogoDeJogos.InputModel;
using CatalogoDeJogos.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoDeJogos.Controllers.V1
{

    [Microsoft.AspNetCore.Components.Route("api/V1/controlle]")]
    [ApiController]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {
            return Ok();
        }

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> IniserirJogo(JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogom, JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> atualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        // [HttpDelete("{idJogo:guid}")]
        // public async Task<AcceptedResult> ApagarJogo(Guid idJogo)
        // {
        //     return Ok();
        // }







    }
}






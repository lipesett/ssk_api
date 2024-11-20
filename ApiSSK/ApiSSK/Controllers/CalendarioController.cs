﻿using ApiSSK.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiSSK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarioController : ControllerBase
    {
        private readonly ICalendarioRepository _calendarioRepository;

        public CalendarioController(ICalendarioRepository calendarioRepository)
        {
            _calendarioRepository = calendarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CalendarioModel>>> GetAllCalendarios()
        {
            List<CalendarioModel> calendario = await _calendarioRepository.GetAllCalendarios();

            return Ok(calendario);
        }
    }
}

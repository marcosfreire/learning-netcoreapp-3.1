using LearningNetCoreApp3_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace LearningNetCoreApp3_1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly ILogger<PessoasController> _logger;

        public PessoasController(ILogger<PessoasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rng = new Random();

            var pessoas = Enumerable.Range(1, 5).Select(index => new PessoaModel
            {
                DataNascimento = DateTime.Now.AddDays(index),
                Nome = $"Pessoa {rng.Next(10) }",
                Id = index
            });

            return Ok(pessoas);
        }
    }
}
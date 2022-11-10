using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace module6.Controllers
{
    [ApiController] //Indica que ela é uma API Controller
    [Route("[controller]")] //Caminho
    public class UserController : ControllerBase
    {
        [HttpGet("GetCurrentDateHour")] //Rota da API
        public IActionResult GetDateHour()
        {
            //cria um obj anônimo com duas funções
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Hour = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Present/{name}")]
        //Criação de um método para apresentação
        public IActionResult Present(string name)
        {
            var mensage = $"Hi, {name}. You're welcome!";
            //retorna um objeto anônimo
            return Ok(new { mensage });
        }
    }
}
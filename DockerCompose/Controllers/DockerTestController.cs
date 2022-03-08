using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DockerCompose.Controllers
{
    [ApiController]
    public class DockerTestController : ControllerBase
    {
        private readonly IHttpService _httpService;

        public DockerTestController(IHttpService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet("get-all-todos")]
        public async Task<ActionResult<IEnumerable<Todo>>> GetAllTodos()
        {
            try
            {
                var result = await _httpService.GetDataFromAPIAsync<IEnumerable<Todo>>("https://jsonplaceholder.typicode.com/todos");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
using AyzMuhasebeServer.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace AyzMuhasebeServer.Presentation.Controllers
{
    public sealed class TestController :ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("İşlem Başarılı");
        }
    }
}

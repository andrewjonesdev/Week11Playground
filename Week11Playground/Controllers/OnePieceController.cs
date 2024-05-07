using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Week11Playground.Models;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Controllers
{
    [ApiController]
    [Route("api/onepiece")]
    public class OnePieceController : ControllerBase
    {


        private readonly ILogger<OnePieceController> _logger;
        private readonly IOnePieceService _onePieceService;

        public OnePieceController(ILogger<OnePieceController> logger, IOnePieceService onePieceService)
        {
            _logger = logger;
            _onePieceService = onePieceService;
        }

        [HttpPost]
        [Route("/addmember")]
        public async Task AddMember(HttpRequest req)
        {
            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var memberRequest = JsonConvert.DeserializeObject <MemberRequest> (requestBody);
            await _onePieceService.AddMember(memberRequest);
        }

    }
}

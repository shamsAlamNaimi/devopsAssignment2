using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WcmtController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "song1", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WcmtController> _logger;

        public WcmtController(ILogger<WcmtController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return "<p>[Verse 1]<br> You were the one that I found<br> Solla Vantha sollai te po<br> Why didn't you tell me enough<br> Solla Vantha sollai te po<br> <br> I ponder, In closure, Remember<br> The world that is out there for me to find<br> <br> [Chorus]<br> Let me go passing by<br> Let me go come back in time<br> Let me be who I am<br> All through this time<br> <br> Let me go passing by<br> Let me go come back in time<br> Walk in the dark<br> Barefoot in the night<br> <br> [Verse 2]<br> Walking down the way that I found<br> Intha ulakam naan suthavendum<br> Faces with smiles all around<br> Antha vaanam naan parka vendum<br> <br> I’ll run free<br> Into the sea<br> The world and me<br> I don't even know what I will find<br> <br> [Chorus]<br> Let me go passing by<br> Let me go come back in time<br> Let me be who I am<br> All through this time<br> <br> Let me go passing by<br> Let me go come back in time<br> Walk in the dark<br> Barefoot in the night<br> <br> [Outro]<br> Dil Mera khoya, jahaan<br> Dil Mera soya, wahan!<br> Dil Mera khoya, jahaan<br> Dil Mera soya, wahan!</p>";
        }
        
    }
}
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
    public class BeatlesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "song1", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BeatlesController> _logger;

        public BeatlesController(ILogger<BeatlesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Song Get()
        {
            return new Song{ songName="Hey Jude",data = " Hey Jude, don't make it bad<br> Take a sad song and make it better<br> Remember to let her into your heart<br> Then you can start to make it better<br> <br> Hey Jude, don't be afraid<br> You were made to go out and get her<br> The minute you let her under your skin<br> Then you begin to make it better<br> <br> And anytime you feel the pain, hey Jude, refrain<br> Don't carry the world upon your shoulders<br></div> For well you know that it's a fool who plays it cool<br> By making his world a little colder<br> <br> Hey Jude, don't let me down<br> You have found her, now go and get her<br> Remember to let her into your heart<br> Then you can start to make it better<br> <br> So let it out and let it in, hey Jude, begin<br> You're waiting for someone to perform with<br> And don't you know that it's just you, hey Jude, you'll do<br> The movement you need is on your shoulder<br> <br> Hey Jude, don't make it bad<br> Take a sad song and make it better<br> Remember to let her under your skin<br> Then you'll begin to make it<br> Better better better better better better, oh<br> <br> Na na na nananana, nannana, hey Jude"};
        }
        
    }
}
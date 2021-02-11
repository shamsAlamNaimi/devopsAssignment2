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
    public class BillyJoelController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "song1", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BillyJoelController> _logger;

        public BillyJoelController(ILogger<BillyJoelController> logger) 
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            return " <!-- Usage of azlyrics.com content by any third-party lyrics provider is prohibited by our licensing agreement. Sorry about that. --> Harry Truman, Doris Day, Red China, Johnnie Ray<br> South Pacific, Walter Winchell, Joe DiMaggio<br> Joe McCarthy, Richard Nixon, Studebaker, Television<br> North Korea, South Korea, Marilyn Monroe<br> <br> Rosenbergs, H-Bomb, Sugar Ray, Panmunjom<br> Brando, The King And I, and The Catcher In The Rye<br> Eisenhower, Vaccine, England's got a new queen<br> Marciano, Liberace, Santayana goodbye<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> Joseph Stalin, Malenkov, Nasser and Prokofiev<br> Rockefeller, Campanella, Communist Bloc<br> Roy Cohn, Juan Peron, Toscanini, Dacron<br> Dien Bien Phu Falls, Rock Around the Clock<br> Einstein, James Dean, Brooklyn's got a winning team<br> Davy Crockett, Peter Pan, Elvis Presley, Disneyland<br> Bardot, Budapest, Alabama, Khrushchev<br> Princess Grace, Peyton Place, Trouble in the Suez<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> Little Rock, Pasternak, Mickey Mantle, Kerouac<br> Sputnik, Chou En-Lai, Bridge On The River Kwai<br> Lebanon, Charles de Gaulle, California baseball<br> Starkweather Homicide, Children of Thalidomide...<br> <br> Buddy Holly, Ben-Hur, Space Monkey, Mafia<br> Hula Hoops, Castro, Edsel is a no-go<br> U-2, Syngman Rhee, payola and Kennedy<br> Chubby Checker, Psycho, Belgians in the Congo<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> Hemingway, Eichmann, Stranger in a Strange Land<br> Dylan, Berlin, Bay of Pigs invasion<br> Lawrence of Arabia, British Beatlemania<br> Ole Miss, John Glenn, Liston beats Patterson<br> <br> Pope Paul, Malcolm X, British Politician Sex<br> J.F.K. blown away, what els do I have to say?<br> <br> We didn't start the fire <br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> Birth control, Ho Chi Minh, Richard Nixon back again<br> Moonshot, Woodstock, Watergate, punk rock<br> Begin, Reagan, Palestine, Terror on the airline<br> Ayatollah's in Iran, Russians in Afghanistan<br> Wheel of Fortune, Sally Ride, heavy metal, suicide<br> Foreign debts, homeless Vets, AIDS, Crack, Bernie Goetz<br> Hypodermics on the shores, China's under martial law<br> Rock and Roller Cola wars, I can't take it anymore<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> But when we are gone<br> It will still burn on and on and on and on<br> And on and on and on and on...<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it<br> <br> We didn't start the fire<br> It was always burning<br> Since the world's been turning<br> We didn't start the fire<br> No, we didn't light it<br> But we tried to fight it";
        }
        
    }
}

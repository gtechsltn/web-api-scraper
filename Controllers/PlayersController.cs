using Microsoft.AspNetCore.Mvc;
using WebApiScraper.Core.Models;
using WebApiScraper.Infrastructure.Repositories;

namespace WebApiScraper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
       private readonly PlayerRepository _playerRepository;

        public PlayersController(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;    
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <param name="id">dfdfd</param>
        /// <returns>A newly created TodoItem</returns>
        [HttpGet(Name = "GetPlayer")]
        public async Task<Player?> Get(int id)
        {
            return await _playerRepository.GetById(id);
        }
    }
}

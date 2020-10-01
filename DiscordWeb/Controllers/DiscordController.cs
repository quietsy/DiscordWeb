using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscordWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DiscordWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscordController : ControllerBase
    {
        private readonly ILogger<DiscordController> _logger;
        private DiscordDAL _discordDAL;

        public DiscordController(ILogger<DiscordController> logger, DiscordDAL discordDAL)
        {
            _logger = logger;
            _discordDAL = discordDAL;
        }

        [HttpGet]
        public IEnumerable<DiscordEntry> Index()
        {
            return _discordDAL.GetDiscordEntriesAsync().Result;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] DiscordEntry entry)
        {
            if (ModelState.IsValid)
            {
                await _discordDAL.AddDiscordEntryAsync(entry);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DiscordEntry>> GetById(int id)
        {
            return await _discordDAL.GetDiscordEntryAsync(id);
        }

        [HttpGet("getbymessage")]
        public async Task<ActionResult<DiscordEntry>> GetByMessage([FromBody] string message)
        {
            return await _discordDAL.GetDiscordEntryByMessageAsync(message);
        }

        [HttpPut]
        public void Edit([FromBody] DiscordEntry entry)
        {
            if (ModelState.IsValid)
                Task.Run(() => _discordDAL.UpdateDiscordEntryAsync(entry));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _discordDAL.DeleteDiscordEntryAsync(id);
            return Ok();
        }
    }
}

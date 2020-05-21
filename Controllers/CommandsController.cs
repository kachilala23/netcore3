using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeCommand.Data;
using PracticeCommand.Models;

namespace PracticeCommand.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;

        public CommandsController(ICommanderRepo repo)
        {
            _repo = repo;
        }
        //private readonly MockCommandRepo _mockCommandRepo = new MockCommandRepo();
        
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repo.GetAllCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandById = _repo.GetCommandById(id);
            return Ok(commandById);
        }
    }
}
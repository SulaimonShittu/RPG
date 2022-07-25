using Microsoft.AspNetCore.Mvc;
using RPG.Services;

namespace RPG.Controllers;

[ApiController]
[Route("api/[Controller]/")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<Character>>>Get()
    {
        return Ok( await _characterService.getAllCharacters());
    }
                                                                            
    [HttpGet("id")]
    public async Task<ActionResult<Character>> GetSingle(int id)
    {
        return Ok(await _characterService.GetCharacterByid(id));
    }
    
    [HttpPost]
    public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
    {
        return Ok(await _characterService.AddCharacter(newCharacter));
    }
}


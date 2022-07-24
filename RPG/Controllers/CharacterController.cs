using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers;

[ApiController]
[Route("api/[Controller]/")]
public class CharacterController : ControllerBase
{
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character{Id = 1, Name = "Sam"}
    };
    
    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }
                                                                            
    [HttpGet]
    public ActionResult<Character> GetSingle(int id)
    {
        return Ok(characters.FirstOrDefault(c => c.Id == id ));
    }
}
namespace RPG.Services;

public class CharacterService : ICharacterService
{
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character{Id = 1, Name = "Sam"}
    };
    public async Task<List<Character>> getAllCharacters()
    {
        return characters;
    }

    public async Task<Character> GetCharacterByid(int id)
    { 
        return characters.FirstOrDefault(c => c.Id == id);
    }

    public async Task<List<Character>> AddCharacter(Character newCharacter)
    {
        characters.Add(newCharacter);
        return characters;
    }
}
namespace RPG.Services;

public interface ICharacterService
{
    Task<List<Character>> getAllCharacters();
    Task<Character> GetCharacterByid(int id);
    Task<List<Character>> AddCharacter(Character newCharacter);
}
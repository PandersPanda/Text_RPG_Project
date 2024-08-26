using Text_RPG_Project.Spells;

namespace Text_RPG_Project.IRaces
{
    public interface IRace
    {
        string Name { get; set; }
        string Description { get; set; }
        Dictionary<Stats, int> StatModifiers { get; set; }
        List<ISpell> Spells { get; set; }

    }
}

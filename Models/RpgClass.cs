using System.Text.Json.Serialization;

namespace RPG_Roster.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Soldier = 4,
        Fighter = 5,
        Assassin = 6,
    }
}
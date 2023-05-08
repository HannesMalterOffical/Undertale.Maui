using Undertale.Maui.Models;

namespace Undertale.Maui.Services
{
    public class BossMonsterServices
    {
        public static List<BossMonsters> bossmonsters = new()
        {
            new()
            {
                BossName = "  Sans",
                BossQuote = "i'm sans.sans the skeleton.",
                CharacterImage = "Sans.png",
                Description = "The easiest enemy. Can only deal 1 damage.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "  Papyrus",
                BossQuote = "I WILL BE THE ONE! I MUST BE THE ONE! I WILL CAPTURE A HUMAN! THEN, I, THE GREAT PAPYRUS... WILL GET ALL THE THINGS I UTTERLY DESERVE!",
                CharacterImage = "Papyrus.png",
                Description = "He likes to say: Nyeh heh heh!",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "  Undyne",
                BossQuote = "SCREW IT! WHY SHOULD I TELL THAT STORY WHEN YOU'RE ABOUT TO DIE!?! NGAAAAAHHHHHHHHHHHHHHHH!",
                CharacterImage = "Undyne.png",
                Description = "The heroine that NEVER gives up.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "  Asgore",
                BossQuote = "Human... It was nice to meet you. Goodbye.",
                CharacterImage = "Asgore.png",
                Description = "The king of the underground.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "  Toriel",
                BossQuote = "I am TORIEL, caretaker of the RUINS.",
                CharacterImage = "Toriel.png",
                Description = "Knows best for you.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

        };

        public static List<BossMonsters> GetAllBossMonsters()
            => bossmonsters;
    }
}

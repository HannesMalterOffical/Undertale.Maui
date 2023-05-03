namespace Undertale.Maui.Services
{
    public class MonsterServices
    {
        public static List<Monsters> monsters = new()
        {
            new()
            {
                Name = "Froggit",
                Quote = "Ribbit, ribbit.",
                CharacterImage = "Froggit.png",
                Description = "Life is difficult for this enemy.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
               Name = "Whimsun",
                Quote = "Forgive me...",
                CharacterImage = "Whimsun.png",
                Description = "This monster is too sensitive to fight...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
                Name = "Moldsmal",
                Quote = "*Sexy wiggle*",
                CharacterImage = "Moldsmal.png",
                Description = "Stereotypical: Curvaceously attractive, but no brains...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = "Loox",
                Quote = "Please don't pick on me...",
                CharacterImage = "Loox.png",
                Description = "Don't pick on him. Family name: Eyewalker.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = "Vegetoid",
                Quote = "Farmed Locally, Very Locally",
                CharacterImage = "Vegetoid.png",
                Description = "Serving Size: 1 Monster. Not monitored by the USDA.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

        };
        public static List<Monsters> GetAllMonsters()
            => monsters;

    }
}

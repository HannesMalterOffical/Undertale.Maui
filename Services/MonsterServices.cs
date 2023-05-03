namespace Undertale.Maui.Services
{
    public class MonsterServices
    {
        public static List<Monsters> monsters = new()
        {
            new()
            {
                Name = " Froggit",
                Quote = "Ribbit, ribbit.",
                CharacterImage = "Froggit.png",
                Description = "Life is difficult for this enemy. " +
                "\r\n\r\nAppearance\r\nFroggit's overall appearance is that of a white frog. Only its two front feet are visible, with three black dots on its chest. Between its two front feet is what appears to be some small creature with eyes that excessively blink and a rounded mouth. It is unknown what this creature is, as it is never mentioned in flavor text or by any Froggits.\r\n\r\nPersonality\r\nFroggit is overall a weak monster, attempting to run away from the protagonist when at low health, shivering when threatened and leaving after Toriel glares at it for attacking the protagonist. It is influenced easily by the protagonist's comments, despite not being able to understand them. However, it is also somewhat informed, telling the protagonist about functions in the game and foreshadowing sparing techniques.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
               Name = " Whimsun",
                Quote = "Forgive me...",
                CharacterImage = "Whimsun.png",
                Description = "This monster is too sensitive to fight...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
                Name = " Moldsmal",
                Quote = "*Sexy wiggle*",
                CharacterImage = "Moldsmal.png",
                Description = "Stereotypical: Curvaceously attractive, but no brains...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = " Loox",
                Quote = "Please don't pick on me...",
                CharacterImage = "Loox.png",
                Description = "Don't pick on him. Family name: Eyewalker.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = " Vegetoid",
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

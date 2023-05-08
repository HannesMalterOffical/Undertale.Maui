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
                Description = "This monster is too sensitive to fight..." +
                "\r\n\r\nAppearance\r\nWhimsun's appearance takes on that of a moth-like monster with two drooping antennae, two small wings, and two little arms and legs. Its body shape resembles that of a ghost. Its facial expression is sad, with an open frowning mouth, and two mostly-closed eyes with dots under them.\r\n\r\nPersonality\r\nWhimsun is extremely sensitive, as suggested by its flavor text. It runs away if the protagonist consoles it and is terrorized by a small finger wiggle. It can be spared immediately and is extremely apologetic. Its attacks do not target or intentionally hit the SOUL but rather limit the SOUL's Bullet Board.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
                Name = " Moldsmal",
                Quote = "*Sexy wiggle*",
                CharacterImage = "Moldsmal.png",
                Description = "Stereotypical: Curvaceously attractive, but no brains..." +
                "\r\n\r\nAppearance\r\nMoldsmal bears a resemblance to and is described as lime gelatin, specifically lime gelatin mold. While it has no overworld sprite and therefore no confirmed color, one can guess from the mention of lime gelatin that Moldsmal is a light green color. In Waterfall, it is described as having a different color, but the color is unknown. One Moldsmal also appears as pink in the Mt. Ebott tarot card.\r\n\r\nPersonality\r\nMoldsmal does not actually say anything in its dialogue; it only makes noises comparable to a slime. In its Check, Moldsmal is described as being \"Curvaceously attractive, but [with] no brains.\" In its flavor text, Moldsmal acts patient and pensive, as it is willing to rest on the floor for a while and is described as ruminating.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = " Loox",
                Quote = "Please don't pick on me...",
                CharacterImage = "Loox.png",
                Description = "Don't pick on him. Family name: Eyewalker." + "\r\n\r\nAppearance\r\nLoox is bipedal and has two horns on the top of his head, a large eye on his face, and teeth under his eye.\r\n\r\nPersonality\r\nLoox does not like it when people pick on him, though is also a bit hypocritical in that he also picks on other people (as suggested by flavor text when encountering a Loox and another enemy.) His description in the True Pacifist Ending Credits implies that he is less of a bully, and a \"reformed bully\" if the protagonist does not pick on him.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),

            },

            new()
            {
               Name = " Vegetoid",
                Quote = "Farmed Locally, Very Locally",
                CharacterImage = "Vegetoid.png",
                Description = "Serving Size: 1 Monster. Not monitored by the USDA." + "\r\n\r\nAppearance\r\nVegetoid appears to be a large carrot with a face that covers its entire front. Apparent by its overworld sprite, its color is also consistent to that of a carrot. Its expression is always that of a wide smile with overjoyed eyes.\r\n\r\nPersonality\r\nVegetoid's main purpose is to encourage the protagonist to eat their vegetables. It often says things supporting this, mainly \"Eat Your Greens.\"",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

        };
        public static List<Monsters> GetAllMonsters()
            => monsters;

    }
}

using Undertale.Maui.Models;

namespace Undertale.Maui.Services
{
    public class BossMonsterServices
    {
        public static List<BossMonsters> bossmonsters = new()
        {
            new()
            {
                BossName = "Sans",
                BossQuote = "I'm sans, sans the skeleton.",
                CharacterImage = "Sans.png",
                Description = "The easiest enemy. Can only deal 1 damage." +
                "\r\n\r\nAppearance\r\nSans appears as a relatively short and paunchy skeleton, with mitten-like hands. Sans is always seen with a wide, toothy-grin on his face. Sans wears a blue hoodie, a white t-shirt underneath, black shorts with white stripes, and a pair of slippers. He has white dots in black eye sockets that disappear when he is serious or angered. When Sans uses telekinesis, his left eye flashes light blue and yellow (the colors for patience and justice) while his right pupil vanishes.\r\n\r\nPersonality\r\nSans is lazy, often sleeping on the job and taking breaks. His laziness is a combination of fatalism and apathy, as he is aware of timeline resets. Conversely, he suggests that this knowledge could be \"a poor excuse for being lazy.\"",

                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "Papyrus",
                BossQuote = "I WILL BE THE ONE! I MUST BE THE ONE! I WILL CAPTURE A HUMAN! THEN, I, THE GREAT PAPYRUS... WILL GET ALL THE THINGS I UTTERLY DESERVE!" +
                "\r\n\r\nAppearance\r\nPapyrus is a tall, perhaps anatomically inaccurate skeleton, with a skull more vertical and geometric than his brother. Being skeletal, many of his expressions incorporate a toothy grin. His eyes resemble vertical slits; his skeletal pseudo-brows form most of his expressions, as well as the corners of his mouth. He has eyeballs which show at times when he is experiencing strong emotions. Papyrus is relatively taller and slightly slimmer than his brother.\r\n\r\nPersonality\r\nPapyrus is a flamboyant skeleton who presents a confident, charismatic image of himself. He is thought to have an egotistical personality, referring to himself as \"THE GREAT PAPYRUS,\" possibly as a way to feel as prestigious as his brother. He works hard and, despite his brash personality, is kind at heart.",
                CharacterImage = "Papyrus.png",
                Description = "He likes to say: Nyeh heh heh!",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "Undyne",
                BossQuote = "SCREW IT! WHY SHOULD I TELL THAT STORY WHEN YOU'RE ABOUT TO DIE!?! NGAAAAAHHHHHHHHHHHHHHHH!" + "\r\n\r\nAppearance\r\nUndyne is a piscine, anthropomorphic monster. She has blue scales and a long red ponytail. She has red and blue fins on the sides of her head, and a pair of sharp, yellow, protruding teeth. She wears a red eyeshadow and has an eyepatch over her left eye. She also wears a black tank top and blue jeans, but debuts in armor varying in light and dark shades of gray. Her eyes have black vertical pupils and yellow sclera. Undyne has no nose.\r\n\r\nPersonality\r\nUndyne is passionate about everything that she does. She acts quickly on her ideas and is steadfast in her beliefs.[2] Though she wants to defeat the protagonist, she also tries to be fair and offers an explanation of how Green Mode works. Asgore taught her the value of pacifism,[3] which is why Undyne sees the protagonist as \"a wimpy loser with a big heart.\" When the protagonist first encounters her, she fights to further Asgore's plan of collecting seven human SOULs but, if the protagonist shows mercy, Undyne just as quickly defends them from Asgore.",
                CharacterImage = "Undyne.png",
                Description = "The heroine that NEVER gives up.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "Asgore",
                BossQuote = "Human... It was nice to meet you. Goodbye." + "\r\n\r\nAppearance\r\nAsgore is a Boss Monster with an intimidating stature. He has broad shoulders, a golden-blond mane, two large curved horns, and a beard. He wears a suit of armor that accentuates his upper body, a purple cape with golden pauldrons - with its edge dragging along the ground slightly - and a small crown on top of his head. The weapon he uses in battle is a long, red trident adorned with a flower. Asgore is shown to be the largest main character (whether human or monster) in the entire game.\r\n\r\nDuring the credits of True Pacifist route, Asgore wears a pink Hawaiian T-shirt adorned with white floral patterns alongside a pair of long blue pants. His midsection is noticeably round and soft. His thick, white furry arms appear to sport blonde hair or fur, reminiscent of human body hair.\r\n\r\nPersonality\r\nAsgore is a kind and often quiet yet upbeat monster that enjoys gardening, Golden Flower Tea,[2] and Toriel's Butterscotch Pie. Like his son, he speaks in southern slang (most notably \"howdy\" and \"golly\"). Before his battle, he offers the protagonist many opportunities to explore the Underground and is reluctant to fight them at all; he even suggests that Toriel, the protagonist and himself live as a family if the protagonist spares him.[3]\r\n\r\nAs evidence of his role as a powerful leader, most characters in the game refer to him in ALL CAPS and sometimes in red text,[4] yellow text,[5] or a combination of both.[6] Monsters in the Underground look to Asgore for hope, and his plan to collect seven human SOULs is one of the few things that keep them going. However, Asgore does not want to kill anybody[7] and feels so guilty that he offers the protagonist his SOUL to \"leave this cursed place.\"[8] Though he is miserable because he has killed humans, he feels that it is his duty to his people to battle the protagonist.",
                CharacterImage = "Asgore.png",
                Description = "The king of the underground.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
            },

            new()
            {
                BossName = "Toriel",
                BossQuote = "I am TORIEL, caretaker of the RUINS." + "\r\n\r\nAppearance\r\nToriel is a Boss Monster whose head resembles a white-furred Nubian Goat, structured with floppy ears and tiny horns. She has a pair of visible fangs and long eyelashes, and her irises have a dark red tint. She has an anthropomorphic body, with paws at the end of her limbs. She wears a long purple robe with white sleeves and the Delta Rune on the chest. Toriel can also be seen with reading glasses, one instance being in her house when reading a book on snail facts.\r\n\r\nPersonality\r\nToriel is a kind monster that acts as a protective mother figure for the protagonist. She employs tough love on the protagonist as well as Asgore. She cares for children and was excited to become a mother.",
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

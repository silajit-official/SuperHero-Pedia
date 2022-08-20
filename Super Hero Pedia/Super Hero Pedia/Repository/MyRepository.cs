using Super_Hero_Pedia.Models;

namespace Super_Hero_Pedia.Repository
{
    public class MyRepository : IMyRepository
    {
        Heros heros = null;
        public MyRepository()
        {
            heros = new Heros();
        }

        public List<Heros> GetHeros()
        {
            return new List<Heros>()
            {
            new Heros()
            {
                Id = 1,
                Name="Ironman",
                Description= "Anthony Edward \"Tony\" Stark was a billionaire industrialist, a founding member of the Avengers, and the former CEO of Stark Industries. A brash but brilliant inventor, Stark was self-described as a genius, billionaire, playboy, and philanthropist. With his great wealth and exceptional technical knowledge,",
                DateofBirth= DateTime.Now,
                UniverseId = 1
            },
            new Heros()
            {
                Id = 2,
                Name = "Batman",
                Description = "DC has featured Batman in many comic books, including comics published under its imprints such as Vertigo and Black Label. The longest-running Batman comic, Detective Comics, is the longest-running comic book in the United States. Batman is frequently depicted alongside other DC superheroes, such as Superman and Wonder Woman, as a member of organizations such as the Justice League and the Outsiders.",
                DateofBirth = DateTime.Now,
                UniverseId = 2
            },
            new Heros()
            {
                Id = 3,
                Name = "Goku",
                Description = "Goku was originally was sent to Earth as an infant, Kakarot would be adopted by Grandpa Gohan who named him Son Goku. A head injury at an early age alters Goku's memory, ridding him of his initial destructive nature and allowing him to grow up to become one of Earth's greatest defenders. He constantly strives and trains to be the greatest warrior possible, which has kept the Earth and the universe safe from destruction many times.",
                DateofBirth = DateTime.Now,
                UniverseId = 3
            },
            new Heros()
            {
                Id = 4,
                Name = "Venom",
                Description = "The Venom symbiote's first human host was Spider-Man himself, who eventually discovered its true nefarious nature and separated himself from the creature in The Amazing Spider-Man #258 (November 1984)[2]—with a brief rejoining five months later in Web of Spider-Man. The symbiote went on to merge with other hosts, beginning with Eddie Brock",
                DateofBirth = DateTime.Now,
                UniverseId = 1
            },
            new Heros()
            {
                Id = 5,
                Name = "Vegeta",
                Description = "Vegeta is the prince of the fallen Saiyan race. He is the eldest son of King Vegeta, the older brother of Tarble, the husband of Bulma, the father of Trunks and Bulla, and the ancestor of Vegeta Jr.",
                DateofBirth = DateTime.Now,
                UniverseId = 3
            }

           };

        }
    }
}

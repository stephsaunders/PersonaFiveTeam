using System;
using System.Linq;
using PersonaFiveTeam.Data;

namespace PersonaFiveTeam.Models
{
    //mwilliams: Part 2 -  Create the Data Model
    //Add code to initialize the database with test data

    // Code will cause a database to be created when needed and loads test data into the new database
    public static class DbInitializer
    {
        public static void Initialize(PersonaContext context)
        {

            //================================================== Confidants ============================================//
            // Look for any confidants.
            if (context.Confidants.Any())
            {
                return;   // DB has been seeded
            }

            var confidants = new Confidant[]
            {
                //new Confidant{FirstName="",LastName="",Arcana="", UnlockDay="", BestGift="", ProfilePhoto="profile#.png", LevelUpAnswers=" ", Location="", Requiremnts= ""},
                //new Confidant{FirstName="Akira",LastName="Kurusu",Arcana="Fool",UnlockDay="April 12th", BestGift="", ProfilePhoto="profile2.png", LevelUpAnswers=" " ),
                new Confidant{FirstName="Ryūji",LastName="Takamaki",Arcana="The Chariot", UnlockDay="April 12th", BestGift="NA", ProfilePhoto="profile2.png", LevelUpAnswers=" ", Location="top of the stairs outside your classroom, Yongenjaya Arcade", Requiremnts= "" },
                new Confidant{FirstName="Ann",LastName="Sakamoto",Arcana="The Lovers", UnlockDay="June 15th", BestGift="Chocolates, cake, pudding, lipstick, perfume", ProfilePhoto="profile3.png", LevelUpAnswers=" ", Location="Classroom, Shibuya Underground Mall", Requiremnts= "Guts II" },
                new Confidant{FirstName="Yusuke",LastName="Kitagawa",Arcana="The Emperor", UnlockDay="June 14th", BestGift="", ProfilePhoto="profile#.png", LevelUpAnswers="", Location="Shibuya Underground Walkway", Requiremnts= ""},
                new Confidant{FirstName="Makoto",LastName="Niijima",Arcana="", UnlockDay="", BestGift="", ProfilePhoto="profile#.png", LevelUpAnswers=" ", Location="", Requiremnts= ""},
                new Confidant{FirstName="",LastName="",Arcana="", UnlockDay="", BestGift="", ProfilePhoto="profile#.png", LevelUpAnswers=" ", Location="", Requiremnts= ""}
                new Confidant{FirstName="",LastName="",Arcana="", UnlockDay="", BestGift="", ProfilePhoto="profile#.png", LevelUpAnswers=" ", Location="", Requiremnts= ""}

            };
            foreach (Confidant c in confidants)
            {
                context.Confidants.Add(c);
            }
            context.SaveChanges();

            //================================================== Skills  ============================================//
            var skills = new Skill[]
            {
                new Skill {SkillName="Charm",SkillLevelOne=0,SkillLevelTwo=0,SkillLevelThree=0,SkillLevelFour=0,SkillLevelFive=0, LevelUpOption=" "}
            };

            foreach (Skill i in skills)
            {
                context.Skills.Add(i);
            }
            context.SaveChanges();

           
        }
    }
}
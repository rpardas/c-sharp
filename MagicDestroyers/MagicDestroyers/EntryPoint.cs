using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Random rng = new Random();

            //int currentMelee = 0;
            //int currentSpellcaster = 0;
            Melee currentMelee;
            Spellcaster currentSpellcaster;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                // 1. Take a random melee
                // 2. Take a random spellcaster
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                // 3. Melee attacks spellcaster
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                // 3.1 Check if the character died and remove him from the team.
                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    // 3.2 If dead, get another character from the team
                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                    }
                }                             
                

                // 4. Spellcaster attacks melee
                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());

                // 4.1 Check if the character died and remove him from the team.
                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    // 4.2 If dead, get another character from the team
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcasters win!");
                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }              
                                
            }

        }   

    }
}

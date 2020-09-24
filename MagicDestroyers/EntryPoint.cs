using System;
using System.Collections.Generic;
using MagicDestroyers;
using MagicDestroyers.Armors.Cloth;
using MagicDestroyers.Armors.Leather;
using MagicDestroyers.Armors.Mail;
using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melees;
using MagicDestroyers.Characters.Spellcasters;

using MagicDestroyers.Weapons.Blunt;
using MagicDestroyers.Weapons.Sharp;

public class EntryPoint
{
    static void Main()
    {
        Random rng = new Random();

        int currentMelee = 0;
        int currentSpellcaster = 0;

        List<Melee> meleeTeam = new List<Melee>();
        List<Spellcaster> spellTeam = new List<Spellcaster>();

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

        PlayersInformation.Initialize(characters);

        while (!gameOver)
        {
            //1. Take a random Melee
            currentMelee = rng.Next(0, meleeTeam.Count);
            //2. Take random spellcaster
            currentSpellcaster = rng.Next(0, spellTeam.Count);
            //this is what 1 & 2 should look like : meleeTeam[0].Attack(spellTeam[0]);
            //issue with above is it's coupling so as soon as anything changes in Character, Speelcaster or Melee Classes this might not work

            //3. Melee attacks Spellcaster
            spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name, meleeTeam[currentMelee].GetType().ToString());
            //3.1 Check if character is dead and remove if they are
            if (!spellTeam[currentSpellcaster].IsAlive)
            {
                //we need to attribute a win if the opponent died
                meleeTeam[currentMelee].WonBattle();
                //if dead remove spellcaster from team
                spellTeam.Remove(spellTeam[currentSpellcaster]);
                //and now add a new spellcatser member to continue battle, trick here is we need an exception if this was the last player
                if (spellTeam.Count == 0)
                {
                    Tools.ColorfulWriteLine("\nCongrats, the MELEE TEAM WIN!", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentSpellcaster = rng.Next(0, spellTeam.Count);
                }
            }
            //3.2 If character is dad and removed, get another character from the relevant team

            //4. Spellcaster attacks Melee
            meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), spellTeam[currentSpellcaster].Name, spellTeam[currentSpellcaster].GetType().ToString());
            //4.1 Check if character is dead and remove if they are
            if (!meleeTeam[currentMelee].IsAlive)
            {
                //we need to attribute a win if the opponent died
                spellTeam[currentSpellcaster].WonBattle();
                //if dead remove melee from team
                meleeTeam.Remove(meleeTeam[currentMelee]);

                //and now add new meleeTeam member to continue battle, trick again is we need exception incase this was the last meleeTeamm player
                if (meleeTeam.Count == 0)//so if no more members then...
                {
                    Tools.ColorfulWriteLine("\nCongrats, the SPELLCASTERS WIN!", ConsoleColor.Red);
                    break;
                }
                else //else pick a new meber
                {
                    currentMelee = rng.Next(0, meleeTeam.Count);
                }
            }
            //4.2 If character is dad and removed, get another character from the relevant team

            //5. If no character is alive from either team the game is over => gameOver = true
        }

        PlayersInformation.UpdateFullInfo(characters);
        PlayersInformation.Save(characters);
        PlayersInformation.PrintFullInfo();
    }
}

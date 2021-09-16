using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Destination
{
    class Program
    {
        //╭━━━┳━━━╮╭╮╭━━━╮
        //┃╭━╮┃╭━╮┣╯┃┃╭━━╯
        //╰╯╭╯┃┃┃┃┣╮┃┃╰━━╮
        //╭━╯╭┫┃┃┃┃┃┃┃╭━╮┃
        //┃┃╰━┫╰━╯┣╯╰┫╰━╯┃
        //╰━━━┻━━━┻━━┻━━━╯


        // This game is, for now, the finished product.
        // The code is made so that It can still be developed further in case you want to.

        // Destination uses a username system. The username system is made so that you have a name.
        // The code in the game may or may not use your username in any sentence. It is made for further development of the game.
        // Due to the short time frame the Username system could not be developed further in a right way right at this moment.
        // There were other things much more important than the username system due to it's simplicity.

        // Variables
        static string text; // Just text
        static string username; // Username
        static string decision; // A variable for your decisions.
        static int sword; // Sword
        static int swordDmg = 23; // Sword Damage
        static int swordCrit = 3; // The value for the sword damage times the crit.
        static int wBottle; // Water bottle.
        static int knife; // Knife
        static int knifeDmg = 14; // Knife Damage
        static int knifeCrit = 8; // The value for the knife damage times the crit.
        static int fistDmg = 11; // Fist damage.
        static int fistCrit = 4; // The value for the fist damage times the crit.
        static int bow; // Bow
        static int bowDmg = 0; // Bow Damage which is purely zero due to it being a useless weapon.
        static int inv = 15; // Inventory size
        static int txtSpeed = 15; // The Text Speed
        static int water = 100; // Amount of water.
        static int hp = 100; // Health.
        static int x = 37; // X position
        static int y = 4; // Y position
        static int x2 = 5; // X2 position
        static int x3 = 17; // X3 position
        static int ctrl = 0; // Made for easier navigation throughout the code.
        static int adv = 0; // Made for easier navigation throughout the code.
        static int dFo = 0; // Made for easier navigation throughout the code.
        static int choice = 0; // A form of navigation throughout the code.
        static int enmyHealth = 250; // Enemy Spider Health.
        static Random rand = new Random();

        // Variables for the health and water system
        static int xx = 0; // Position
        static int yy = 1; // Position
        static int yyy = 1; // Position
        static int A = 0; // Position
        static int B = 0; // Position 
        static int C = 0; // Position

        // Metoder
        static void Main(string[] args)
        {
            MainMenu();
        }

        // Game Beginning
        static void MainMenu()
        {
            while (true)
            {
                VariableReset();
                var bAware = "NOTICE:\n" + "As you play this game you have to take in account that there are pauses in it.\n" + // Notice for pauses.
                    "Be Aware; The game never pauses for more than 5 seconds.\n" +
                    "Be patient and don't press 'ENTER' unless it ask you to.";

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DESTINATION"); //Game Name
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n"+"The numbers and/or letters inside of the [Square Brackets] is a part of the navigation system.\n"+ // An explanation on how the navigation system works
                    "Write the letters and/or the numbers to continue throughout the game."); // Further explanation.
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                foreach (var character in bAware)
                {
                    Console.Write(character);
                    Thread.Sleep(1);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n" + "\n" + "It is currently writing out one text character every "); // Telling you how fast the automatic text is writing out
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(txtSpeed + "ms.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + //Main Menu
                    "[ST] Start\n" +
                    "[CR] Credits\n" +
                    "[TS] Text Speed\n" +
                    "[EX] Exit\n" +
                    "");
                Console.ForegroundColor = ConsoleColor.White;
                decision = Console.ReadLine();

                if (decision == "ST" || decision == "st" || decision == "St" || decision == "start" || decision == "Start") //If they choose to start the game..
                {
                    beginning();
                }
                if (decision == "CR" || decision == "Cr" || decision == "cr" || decision == "Credits" || decision == "credits") // Watch the credits
                {
                    credits();
                }
                if (decision == "TS" || decision == "Ts" || decision == "ts" || decision == "text speed") // Change the Text Speed
                {
                    textS();
                }
                if (decision == "EX" || decision == "Ex" || decision == "ex" || decision == "Exit" || decision == "exit") // Close the game
                {
                    Environment.Exit(0);
                }
                if (decision == "CheatX")
                {
                }
            }
        } // The Main Menu...
        static void beginning()
        {
            Console.Clear();
            introduction(); // Just navigates to the username introduction part.
        } //This method is made purely for the simplicity of adding a story if I felt like it.
        static void introduction()
        {

            Console.Clear();
            Console.WriteLine("Enter a username of your choice.\n" + // Just the text interface.
                "The username can't be lower than 4 nor higher than 9 characters.");
            Console.WriteLine("");
            Console.Write("Name: ");
            username = Console.ReadLine();


            if (username.Length <= 9 && username.Length >= 4) // As long as 9 is bigger or 4 is lower than the amount of characters written out.
            {
                while (decision != "N" || decision != "n" || decision != "Y" || decision != "y") //Loop with the purpose of containing the "are you sure?" part.
                {
                    Console.Clear();
                    Console.WriteLine("Did I get that right?\n" +
                        "Is your name " + username + "?\n" +
                        "[Y/N]\n" +
                        "");
                    decision = Console.ReadLine();

                    if (decision == "Y" || decision == "y")
                    {
                        var text3 = "Starting up..."; // This is made as a kind of "slow down" so you are not "rushing" straight into the game. Be patient.
                        foreach (var character in text3)
                        {
                            Console.Write(character);
                            Thread.Sleep(75);
                        }
                        Thread.Sleep(750);
                        game();
                    }
                    if (decision == "N" || decision == "n")
                    {
                        Console.Clear();
                        introduction();
                    }
                    else
                    {
                    }
                }
            }
            if (username.Length <= 4) // In case the character count inserted are below 4.
            {
                Console.WriteLine("Your name is too short, try again...");
                Thread.Sleep(750);
                introduction();
            }
            else if (username.Length >= 9) // In case the character count inserted are above 9.
            {
                Console.WriteLine("Your name is too long, try again...");
                Thread.Sleep(750);
                introduction();
            }


        } // The Username introduction.

        // Parts of the game made for easier navigation.
        static void wCache()
        {
            var body = "A body fell out...";

            Console.Clear();

            Console.WriteLine("Objects in the room: ");
            Console.WriteLine("\n" +
                "[CH] Check on top of the Chair\n" +
                "[BO] Check the Bows\n" +
                "[SW] Check the Swords\n" +
                "[CL] Check the Closet");
            Console.WriteLine("Where would you like to look?");
            decision = Console.ReadLine();
            if (decision == "CL" || decision == "cl")
            {
                Console.Clear();
                Console.WriteLine("You slowly opened the closed...");
                foreach (var character in body)
                {
                    Console.Write(character);
                    Thread.Sleep(75);
                }
                Thread.Sleep(3000);
                while (decision != "CD" || decision != "Cd" || decision != "cd")
                {
                    Console.Clear();
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("\n" +
                        "[CD] Call for Dexter\n" +
                        "[HB] Hide the body again and hope no one finds it..like..ever..\n" +
                        "[TD] Get rid of the body.");
                    decision = Console.ReadLine();
                    if (decision == "HB" || decision == "hb")
                    {
                        Console.WriteLine("You tried to hide the body...\n" +
                            "Just as you were about to hide it, Dexter entered the room and saw you...");
                        Console.WriteLine("Dexter thought you murdered someone, he shot you.");
                        Thread.Sleep(5000);
                        Lost();

                    }
                    if (decision == "TD" || decision == "td")
                    {
                        Console.WriteLine("You took out your knife and cut the body into pieces.");
                        Console.WriteLine("You ate the pieces");
                        Console.WriteLine("Dexter saw you eating the pieces.\n" +
                            "He shot you.");
                        Thread.Sleep(5000);
                        Lost();
                    }
                    if (decision == "CD" || decision == "cd")
                    {
                        int dRate = rand.Next(0, 3);

                        if (dRate == 2)
                        {
                            Console.WriteLine("You screamed for Dexter but got no answer.\n" +
                                "\n" +
                                "Do you want to check up on him?");
                            Console.WriteLine("[Y/N]");
                            decision = Console.ReadLine();

                            if (decision == "N" || decision == "n")
                            {
                                Console.Clear();
                                Console.WriteLine("You feel a hit to your head.");
                                Lost();
                            }
                            if (decision == "Y" || decision == "y")
                            {
                                var Dex = "Sorry for not answering, I thought I heard something but I guess it was nothing...";

                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("You went into the Ammunition Cache to check up on Dexter.");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Dexter: ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(750);
                                foreach (var character in Dex)
                                {
                                    Console.Write(character);
                                    Thread.Sleep(txtSpeed);
                                }
                                Console.WriteLine();
                                game2();

                            }
                        }
                        if (dRate == 1)
                        {
                            game2();
                        }

                    }
                    else
                    {
                        Console.WriteLine("That's not a valid option...");
                        Thread.Sleep(1250);
                    }
                }
            }
            if (decision == "BO" || decision == "bo" || decision == "Bo")
            {
                int death = rand.Next(0, 10);
                if (death == 1)
                {
                    Console.WriteLine("As the retard you are, you shot yourself in the face...");
                    Lost();
                }
                else
                {
                    Console.WriteLine("You almost shot yourself, be more careful..");
                    Thread.Sleep(1250);
                    wCache();
                }
            }
            if (decision == "CH" || decision == "ch")
            {
                Console.WriteLine("You looked on top of and under the chair...\n" +
                    "You found candy, do you want to eat it?");
                Console.WriteLine("[Y/N]");
                decision = Console.ReadLine();

                if (decision == "Y" || decision == "y")
                {
                    int death2 = rand.Next(0, 2);
                    if (death2 == 1)
                    {
                        Console.WriteLine("You ate the candy...");
                        Console.WriteLine("You literally just ate a candy full of posion...");
                        Lost();
                    }
                    else if (death2 == 0)
                    {
                        Console.WriteLine("You just ate a nasty candy and puked a little...");
                        Thread.Sleep(1250);
                        wCache();
                    }
                }
                if (decision == "N" || decision == "n")
                {
                    int crazy = rand.Next(0, 4);
                    if (crazy > 1 && crazy < 4)
                    {
                        Console.WriteLine("You threw the candy the hardest you could at the chair...for no...reason...");
                        Thread.Sleep(1750);
                        wCache();
                    }
                    if (crazy == 4)
                    {
                        Console.WriteLine("You threw the candy behind the chair so no one else would find it...");
                        Console.WriteLine("In case you want it later on...");
                        Thread.Sleep(1750);
                        wCache();
                    }
                    else
                    {
                        Console.WriteLine("You placed the candy gently on the seat of the chair and continued to look around the room.");
                        Thread.Sleep(1750);
                        wCache();
                    }
                }

            }
            if (decision == "SW" || decision == "Sw" || decision == "sw")
            {
                int uRdead = rand.Next(0, 7);
                if (uRdead == 3)
                {
                    Console.WriteLine("You accidentally shot yourself in the face...");
                    Thread.Sleep(1500);
                    Lost();
                }
                if (uRdead == 2)
                {
                    Console.WriteLine("You looked behind the swords and found a jar of toenails...");
                    Thread.Sleep(1750);
                    wCache();
                }
                if (uRdead == 4)
                {
                    while (decision != "GB" || decision != "gb")
                    {
                        Console.WriteLine("You found a dead body...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("\n" +
                            "[CD] Call for Dexter\n" +
                            "[HB] Hide the body again and hope no one finds it..like..ever..\n" +
                            "[TD] Get rid of the body.\n" +
                            "\n" +
                            "[GB] Go Back");
                        decision = Console.ReadLine();

                        if (decision == "HB" || decision == "hb")
                        {
                            Console.WriteLine("You tried to hide the body...\n" +
                                "Just as you were about to hide it, Dexter entered the room and saw you...");
                            Console.WriteLine("Dexter thought you murdered someone, he shot you.");
                            Thread.Sleep(5000);
                            Lost();

                        }
                        if (decision == "TD" || decision == "td")
                        {

                            Console.WriteLine("You ate the body.");
                            Console.WriteLine("Dexter saw you eating the body\n" +
                                "He shot you.");
                            Thread.Sleep(3000);
                            Lost();
                        }
                        if (decision == "CD" || decision == "cd")
                        {
                            int dRate = rand.Next(0, 4);

                            if (dRate == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("You screamed for Dexter but got no answer.\n" +
                                    "\n" +
                                    "Do you want to check up on him?");
                                Console.WriteLine("[Y/N]");
                                decision = Console.ReadLine();

                                if (decision == "N" || decision == "n")
                                {
                                    Console.Clear();
                                    Console.WriteLine("You felt a hit to your head.");
                                    Lost();
                                }
                                if (decision == "Y" || decision == "y")
                                {
                                    var Dex = "Sorry for not answering, I thought I heard something but I guess it was nothing...";

                                    Thread.Sleep(500);
                                    Console.Clear();
                                    Console.WriteLine("You went into the jail room to check up on Dexter.");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("Dexter: ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    foreach (var character in Dex)
                                    {
                                        Console.Write(character);
                                        Thread.Sleep(txtSpeed);
                                    }
                                    Console.WriteLine();
                                    Thread.Sleep(750);
                                    game2();

                                }
                            }
                            else
                            {
                                Console.WriteLine("You screamed for Dexter");
                                Thread.Sleep(750);
                            }
                        }
                        if (decision == "GB" || decision == "gb")
                        {
                            Console.WriteLine("You went out and got shot in the head...");
                            Thread.Sleep(1250);
                            Lost();
                        }
                        else
                        {
                            Console.WriteLine("That's not a valid option...");
                            Thread.Sleep(1250);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You found some dust...");
                    Thread.Sleep(1500);
                    wCache();
                }
            }
            else
            {
                Console.WriteLine("That is not a valid option...");
                Thread.Sleep(1250);
                wCache();
            }
        } // Weapon Cache
        static void aCache()
        {
            int deathRate = rand.Next(0, 35);

            if (deathRate == 1) // This is purely made for the fun of "trolling" people.
            {
                Console.WriteLine("You tripped on a edge and broke your neck...");
                Thread.Sleep(750);
                Lost();
            }
            if (deathRate == 2) // This is purely made for the fun of "trolling" people.
            {
                Console.WriteLine("You caught the plague and died instantly");
                Thread.Sleep(750);
                Lost();
            }
            else
            {
                while (decision != "SW" || decision != "sw" || decision != "Sw") // As long as the decision is not "GB" which stands for "Go Back"
                {
                    Console.Clear();
                    Console.WriteLine("Objects in the room: ");
                    Console.WriteLine("\n" + "[CL] Check the Locker.\n" +
                        "[CP] Check under Carpet\n" +
                        "[CH] On top of the Chair\n" +
                        "[SW] Check outside of the Window.");
                    Console.WriteLine("What would you like to do??");
                    decision = Console.ReadLine();

                    if (decision == "CL" || decision == "cl" || decision == "Cl")
                    {
                        var AL = "You walked up to the locker and opened it...";
                        Console.Clear();

                        foreach (var character in AL)
                        {
                            Console.Write(character);
                            Thread.Sleep(50);
                        }
                        Thread.Sleep(500);
                        Console.WriteLine("\n"+"You only found a few arrows, what else did you expect to find?");
                        Thread.Sleep(1000);
                        Console.WriteLine("\n" + "Press 'ENTER' to go back.");
                        Console.ReadLine();

                    }
                    if (decision == "CH" || decision == "ch")
                    {
                        Console.WriteLine("You looked under and on top of the chair, you found nothing...");
                        Thread.Sleep(1000);
                        Console.WriteLine("\n" + "Press 'ENTER' to go back.");
                        Console.ReadLine();
                    }
                    if (decision == "CP" || decision == "cp")
                    {
                        Console.WriteLine("You found a dead Nazi...");
                        Console.WriteLine("Do you wanna eat it?\n" +
                            "[Y/N]");
                        decision = Console.ReadLine();
                        if (decision == "Y" || decision == "y")
                        {
                            Console.WriteLine("You ate the Nazi and it was delicious...");
                            Thread.Sleep(1500);
                        }
                        if (decision == "N" || decision == "n")
                        {
                            Console.WriteLine("You hid the Nazi and continued to look around in the room...");
                            Thread.Sleep(1750);
                        }
                    }
                    if (decision == "SW" || decision == "Sw" || decision == "sw")
                    {
                        Console.WriteLine("You checked outside of the Window and found a body");
                        Console.WriteLine("You called for Dexter");
                        Thread.Sleep(1750);
                        game2();
                    }
                }

            }
        } // Locker room
        static void supply()
        {

            while (decision != "F" || decision != "f")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Available Space in your backpack: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(inv);
                if (inv == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You backpack is full.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\n" + "What supplies do you want to take with you?");
                Console.WriteLine("\n" + "[W] Water Bottle (1 Space) \n" +
                    "[S] Sword (4 Spaces)\n" +
                    "[K] Knife (3 Spaces)\n" +
                    "\n" +
                    "Write 'T' to destroy a item in your inventory.\n" +
                    "Write 'I' for information about the weapons." +
                    "\n" + "Write 'F' when you are finished.");
                decision = Console.ReadLine();
                if (inv > 0)
                {
                    if (decision == "S" || decision == "s")
                    {
                        if (inv >= 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You picked up the Sword and placed it in your backpack.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1250);
                            inv = inv - 4;
                            sword = sword + 1;
                            supply();
                        }
                        else
                        {
                            Console.WriteLine("Not enough space.");
                            Thread.Sleep(750);
                            supply();
                        }
                    }
                    if (decision == "K" || decision == "k")
                    {
                        if (inv >= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You picked up the Knife and placed it in your backpack.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1250);
                            inv = inv - 3;
                            knife = knife + 1;
                            supply();
                        }
                        else
                        {
                            Console.WriteLine("Not enough space.");
                            Thread.Sleep(750);
                            supply();
                        }
                    }
                    if (decision == "W" || decision == "w")
                    {
                        if (inv >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You picked up the Water Bottle and placed it in your backpack.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1250);
                            inv = inv - 1;
                            wBottle = wBottle + 1;
                            supply();
                        }
                        else
                        {
                            Console.WriteLine("Not enough space.");
                            Thread.Sleep(750);
                            supply();
                        }
                    }
                }
                if (decision == "F" || decision == "f")
                {
                    while (decision != "Y" || decision != "y")
                    {
                        Console.Clear();
                        Console.WriteLine("Are you sure?\n" + "[Y/N]");
                        decision = Console.ReadLine();

                        if (decision == "Y" || decision == "y")
                        {
                            dexGB();
                            adventure();
                        }
                        if (decision == "N" || decision == "n")
                        {
                            supply();
                        }
                    }

                }
                if (decision == "T" || decision == "t")
                {
                    if (inv <= 15)
                    {
                        while (decision != "GB" || decision != "gb" || decision != "Gb")
                        {

                            Console.Clear();
                            Console.WriteLine("Which one would you like to destroy?\n");
                            if (sword >= 1)
                            {
                                Console.WriteLine("[S] Rusty Sword (" + sword + ")");
                            }
                            if (knife >= 1)
                            {
                                Console.WriteLine("[K] Rusty Knife (" + knife + ")");
                            }
                            if (wBottle >= 1)
                            {
                                Console.WriteLine("[W] Water Bottle (" + wBottle + ")");
                            }
                            Console.WriteLine("\n" + "[GB] To go back");
                            decision = Console.ReadLine();

                            if (decision == "S" || decision == "s")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You destroyed your Sword.");
                                Console.ForegroundColor = ConsoleColor.White;
                                sword = sword - 1;
                                inv = inv + 5;
                                Thread.Sleep(750);
                            }
                            if (decision == "K" || decision == "k")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You destroyed your Knife.");
                                Console.ForegroundColor = ConsoleColor.White;
                                knife = knife - 1;
                                inv = inv + 3;
                                Thread.Sleep(750);
                            }
                            if (decision == "W" || decision == "w")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("You destroyed your Water Bottle.");
                                Console.ForegroundColor = ConsoleColor.White;
                                wBottle = wBottle - 1;
                                inv = inv + 2;
                                Thread.Sleep(750);
                            }
                            if (decision == "GB" || decision == "Gb" || decision == "gb")
                            {
                                supply();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid option...");
                        Thread.Sleep(750);
                        supply();
                    }
                }
                if (decision == "I" || decision == "i")
                {
                    while (decision != "GB" || decision != "Gb" || decision != "gb")
                    {
                        Console.Clear();
                        Console.WriteLine("[S] Rusty Sword\n" +
                            "[K] Rusty Knife");
                        Console.WriteLine("\n" + "[GB] Go Back");
                        decision = Console.ReadLine();

                        if (decision == "S" || decision == "s")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The Rusty Sword\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Damage: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(swordDmg);
                            Console.WriteLine("\n" + "The Rusty Sword is almost a relic.\n" +
                                "It is said to have been worn by the first knight.");
                            Console.WriteLine("\n" + "Press 'ENTER' to go backwards.");
                            Console.ReadLine();
                        }
                        if (decision == "K" || decision == "k")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("The Rusty Knife\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Damage: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(knifeDmg);
                            Console.WriteLine("\n" + "The Rusty knife is said to have killed the first king of Sweden.\n" +
                                "But we all know that is not true...or is it?");
                            Console.WriteLine("\n" + "Press 'ENTER' to go backwards.");
                            Console.ReadLine();
                        }
                        if (decision == "GB" || decision == "Gb" || decision == "gb")
                        {
                            Thread.Sleep(250);
                            supply();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "Your backpack is full.");
                    Thread.Sleep(750);
                    supply();
                }
            }
        } // Supply for the beginning of the adventure
        static void adventure() // The start of the adventure
        {
            Console.Clear();
            HUD();

            Console.WriteLine("You see two roads.\n" + "\n" + "Which one would you like to follow?\n");
            Console.WriteLine("[1] Dark Forest");
            Console.WriteLine("[2] Forest");
            decision = Console.ReadLine();

            if (decision == "E" || decision == "e")
            {
                adv = adv + 1;
                bag();
            }

            if (decision == "1")
            {
                Console.WriteLine("You went into the dark forest...");
                Thread.Sleep(750);
                dForest();
            }
            if (decision == "2")
            {
                Console.WriteLine("You got shot in the head and died immediately");
                Lost();
            }
            else
            {
                adventure();
            }
        }
        static void dForest()
        {
            Console.Clear();
            HUD();
            sHouse();

            Console.WriteLine("\n" + "What do you do?");
            Console.WriteLine("\n" + "[1] Fight\n" + "[2] Run");
            decision = Console.ReadLine();

            if (decision == "2")
            {
                Console.WriteLine("You tried to run but the spider caught you in a net and ate your head.");
                Thread.Sleep(1250);
                Lost();
            }
            if (decision == "E" || decision == "e")
            {
                bag();
                dFo = dFo + 1;
            }
            if (decision == "1")
            {
                Console.WriteLine("You choose to fight.");
                lFight();
                fightStart();
            }
            else
            {
                dForest();
            }
        } // The dark forest
        static void lFight() // The fight
        {
            Console.Clear();
            Console.WriteLine("To be able to fight, you have to choose a weapon.\n");

            if (sword >= 1)
            {
                Console.WriteLine("[S] Sword");
            }
            if (knife >= 1)
            {
                Console.WriteLine("[K] Knife");
            }
            if (knife <= 0 && sword <= 0)
            {
                Console.WriteLine("[F] Fists");
            }
            decision = Console.ReadLine();
            if (decision == "S" || decision == "s")
            {
                if (sword >= 1)
                {
                    Console.Clear();
                    Console.WriteLine("Sword Information:\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Damage: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(swordDmg);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Critical: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Up to " + swordCrit + " times the damage.");
                    Console.WriteLine("\n" + "Are you sure?" + "\n" + "[Y/N]");
                    decision = Console.ReadLine();

                    if (decision == "Y" || decision == "y")
                    {
                        choice = choice + 1;
                        fightStart();
                    }
                    if (decision == "N" || decision == "n")
                    {
                        lFight();
                    }
                }
                if (sword <= 0)
                {
                    lFight();
                }
            }
            if (decision == "K" || decision == "k")
            {
                if (knife >= 1)
                {
                    Console.Clear();
                    Console.WriteLine("Knife Information:\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Damage: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(knifeDmg);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Critical: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Up to " + knifeCrit + " times the damage.");
                    Console.WriteLine("\n" + "Are you sure?" + "\n" + "[Y/N]");
                    decision = Console.ReadLine();

                    if (decision == "Y" || decision == "y")
                    {
                        choice = choice + 2;
                        fightStart();
                    }
                    if (decision == "N" || decision == "n")
                    {
                        lFight();
                    }
                }
                if (knife <= 0)
                {
                    lFight();
                }
            }
            if (decision == "F" || decision == "f")
            {
                if (sword <= 0 && knife <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Fist Information:\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Damage: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(fistDmg);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Critical: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Up to " + fistCrit + " times the damage.");
                    Console.WriteLine("\n" + "Are you sure?" + "\n" + "[Y/N]");
                    decision = Console.ReadLine();

                    if (decision == "Y" || decision == "y")
                    {
                        choice = choice + 3;
                        fightStart();
                    }
                    if (decision == "N" || decision == "n")
                    {
                        lFight();
                    }
                }
                else
                {
                    lFight();
                }
            }
            else
            {
                lFight();
            }
        }
        static void fightStart()
        {
            while (true)
            {
                if (enmyHealth > 0)
                {
                    if (water > 0)
                    {
                        if (hp <= 0)
                        {
                            Console.WriteLine("The Spider killed you.");
                            Thread.Sleep(750);
                            Lost();
                        }
                        else
                        {
                            Console.Clear();
                            healthWater();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("FIGHT\n" + "");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("What do you do?\n" + "[A] Attack\n" + "[D] Drink Water");
                            decision = Console.ReadLine();

                            if (decision == "A" || decision == "a")
                            {
                                int attackRand = rand.Next(1, 6);

                                if (attackRand <= 3)
                                {
                                    fightPlayer();
                                    fightEnemy();
                                }
                                if (attackRand == 1)
                                {
                                    fightPlayer();
                                    fightPlayer();
                                    fightEnemy();
                                }
                                if (attackRand == 2)
                                {
                                    fightPlayer();
                                    fightPlayer();
                                    fightEnemy();
                                    fightEnemy();
                                    fightEnemy();
                                }
                            }
                            if (decision == "D" || decision == "d")
                            {
                                drinkWater();
                                fightEnemy();
                            }
                        }
                    }
                }
                if (enmyHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You successfully killed the Spider!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1250);
                    Console.Clear();
                    enterSpiderHouse();
                }
                else if (water <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You died of thirst.");
                    Thread.Sleep(750);
                    Lost();
                }
            }
        } // Fight Control
        static void enterSpiderHouse()
        {
            var enterHouse = "As you were curious if this monster you just killed was the one to capture Erica, you entered the house.";
            var dead = "You feel a knife to your throat...";
            foreach (var character in enterHouse)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Thread.Sleep(1250);
            Console.Clear();
            Console.WriteLine("You see Erica, she is tied up.");
            Console.WriteLine("\n" + "What do you do?");
            Console.WriteLine("[1] Release her.\n" +
                "[2] Eat her\n" +
                "[3] Kill her\n" +
                "[4] Kill yourself");
            decision = Console.ReadLine();

            if (decision == "1")
            {
                Console.WriteLine("You released Erica.");
                Console.WriteLine("She quickly hit you in the head.");
                Thread.Sleep(750);
                Console.WriteLine("You were set up");
                Thread.Sleep(1250);
                Console.Clear();
                
                foreach (var character in dead)
                {
                    Console.Write(character);
                    Thread.Sleep(txtSpeed);
                }
                Thread.Sleep(1250);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("PLOT TWIST...DUN DUN DUUUUUUN");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1250);
                Lost();
            }
            if (decision == "2")
            {
                Console.WriteLine("You killed Erica and ate her. It was delicious.");
                Thread.Sleep(1250);
                Win();
            }
            if (decision == "3")
            {
                Console.WriteLine("You killed Erica and found a letter explaining the plot against you all");
                Thread.Sleep(1750);
                Win();
            }
            if (decision == "4")
            {
                Console.WriteLine("You killed yourself...you win...");
                Thread.Sleep(1250);
                Console.Clear();
                Console.WriteLine("Just kidding...You lose.");
                Thread.Sleep(750);
                Lost();
            }
        } // The spider house, also the last resort for now.

        // Game Controls
        static void game()
        {
            var Dex1 = "Okey, so we got two room here. We need to take one room each and look for clues.";

            Console.WriteLine("\n" +"Do you want to skip the first part and start the adventure directly?\n" + "[Y/N]"); // This is made so your can skip the first part.
            decision = Console.ReadLine();

            if (decision == "Y" || decision == "y") // If you answer Yes.
            {
                supply();
            }
            if (decision == "N" || decision == "n") // If you answer No.
            {
                mainDialogue();
                Console.WriteLine("You went with Dexter to the Armory...");
                Thread.Sleep(1500);
                while (decision != "1" || decision != "2")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Dexter: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var character in Dex1)
                    {
                        Console.Write(character);
                        Thread.Sleep(txtSpeed);
                    }
                    Console.WriteLine("\n" + 
                        "\n" +
                        "Which Room would you like to look in?\n" + // Ask's where you would like to look.
                        "[1] Weapon Cache\n" +
                        "[2] Locker Room");
                    decision = Console.ReadLine();

                    if (decision == "1") // If you choose to look around inside of the Weapon Cache.
                    {
                        Console.Clear();
                        Console.WriteLine("You choose to look around in the Weapon Cache"); 
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("You walked into the Weapon Cache.");
                        Thread.Sleep(1250);
                        wCache();
                    }
                    if (decision == "2") // If you choose to look around inside of the Locker Room.
                    {
                        Console.Clear();
                        Console.WriteLine("You choose to look around in the Locker Room");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("You walked into the Locker Room.");
                        Thread.Sleep(1750);
                        aCache();
                    }
                }
            }
        } // Part of the game Controls
        static void game2()
        {
            var Dex = "So what do you think we should do with the body?";
            var Dex2 = "Haha...Funny joke, no but seriously?";

            while (decision != "TE" || decision != "Te" || decision != "te")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Dexter: ");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var character in Dex)
                {
                    Console.Write(character);
                    Thread.Sleep(txtSpeed);
                }

                Console.WriteLine("\n" + "\n" + "[TE] Tell Erica\n" + "[HD] Hide the body"); // Giving you a different set of options.
                decision = Console.ReadLine();

                if (decision == "HD" || decision == "hd") // If you choose to hide the body.
                {
                    Console.Write("Dexter: ");
                    foreach (var character in Dex2)
                    {
                        Console.Write(character);
                        Thread.Sleep(txtSpeed);
                    }
                    Thread.Sleep(2000);
                    game2();
                }
                if (decision == "TE" || decision == "te") // If you choose to tell Erica.
                {
                    while (decision != "AV" || decision != "Av" || decision != "av") // This will keep looping as long as you don't choose the right answer.
                    {
                        Console.Clear();
                        Console.WriteLine("Dexter picked up the body and both of you walked out and looked for Erica\n" +
                        "Erica was nowhere to be found...\n" + "\n" +
                        "What do you want to do?");

                        Console.WriteLine("[AV] Ask the Villagers if they have seen her...");
                        Console.WriteLine("[KS] Kill yourself");
                        decision = Console.ReadLine();

                        if (decision == "KS" || decision == "ks") // If you choose to kill yourself.
                        {
                            int death = rand.Next(0, 999); // A small chance to win by killing yourself. (Just for the lulz)

                            if (death == 0) // A small chance to win by killing yourself. (Just for the lulz)
                            {
                                Win();
                            }
                            else 
                            {
                                Lost();
                            }
                        }
                        if (decision == "AV" || decision == "av")
                        {
                            while (decision != "LE" || decision != "Le" || decision != "le") // Will loop as long as the decision is not LE in any form.
                            {
                                Console.Clear();
                                Console.WriteLine("You tried asking Villagers but no one would help.\n" + "They were all afraid of something...or someone...\n");
                                Console.WriteLine("What do you want to do?\n" + "\n" +
                                    "[LE] Go out and look for Erica.\n" +
                                    "[ST] Stay in the Village.\n\n" +
                                    "[KS] Kill yourself");
                                decision = Console.ReadLine();

                                if (decision == "KS" || decision == "ks") // Gives you the ability to kill yourself.
                                {
                                    int death = rand.Next(0, 999);

                                    if (death == 0) // Small chance to win by killing yourself.
                                    {
                                        Win();
                                    }
                                    else
                                    {
                                        Lost();
                                    }
                                }
                                if (decision == "ST") // In case you want to stay in the village.
                                {
                                    var text = "You stayed in the village for about 20 years until you killed yourself.";
                                    var text2 = "\nYou couldn't handle that you didn't do anything to find Erica.";

                                    foreach (var character in text)
                                    {
                                        Console.Write(character);
                                        Thread.Sleep(txtSpeed);
                                    }
                                    Thread.Sleep(500);
                                    foreach (var character in text2)
                                    {
                                        Console.Write(character);
                                        Thread.Sleep(txtSpeed);
                                    }
                                    Thread.Sleep(600);
                                    Lost();
                                }
                                if (decision == "LE" || decision == "Le" || decision == "le")
                                {
                                    Console.WriteLine("Before you head out you need to get yourself some supplies."); // Message displaying what you need to do.
                                    Thread.Sleep(1500);
                                    supply();
                                }
                            }
                        }
                    }
                }
            }
        } // Part of the game Controls

        // Win - Lose Screens
        static void Win()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YOU WIN"); // A basic win screen. No need for a more advanced win screen.
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1250);
            Console.Clear();
            credits();
        } // When you Win
        static void Lost()
        {
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("You died...somehow...");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU LOSE"); // Basic lose screen. No need for a more advanced lose screen.
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2500);
            credits();
        } // When you Lose
        static void credits()
        {
            Console.Clear();
            Console.WriteLine("▒█▀▄▀█ █▀▀█ █▀▀▄ █▀▀ 　 █▀▀▄ █░░█ 　 ▀▀█▀▀ █░░█ ▀▀█ ▄█░ █▀▀ \n" +
                              "▒█▒█▒█ █▄▄█ █░░█ █▀▀ 　 █▀▀▄ █▄▄█ 　 ░▒█░░ █░░█ ▄▀░ ░█░ █▀▀ \n" +
                              "▒█░░▒█ ▀░░▀ ▀▀▀░ ▀▀▀ 　 ▀▀▀░ ▄▄▄█ 　 ░▒█░░ ░▀▀▀ ▀▀▀ ▄█▄ ▀▀▀ \n");
            Console.WriteLine("Game coded by Pontuz Klasson."); // The programmer
            Console.WriteLine("Graphical Design by Pontuz Klasson."); // The graphical design behind the backpack and HUD systems.
            Console.WriteLine("© Destination, Pontuz Klasson, 2016."); // Just to make it look more "professional".
            Console.WriteLine("\n" +
                "Press 'ENTER' to go back to the Main Menu."); // Navigation help.
            Console.ReadLine();
            MainMenu(); // Redirection to the Main Menu.
        } // Credits

        // Dialogues and text overall
        static void mainDialogue()
        {
            var eL1 = "Hello and Welcome to our Village.";
            var eL2 = "Here you will find everything from farmers to fighters!";
            var dL1 = "Hey, Errie?";
            var eL3 = "yeah..?";
            var dL2 = "Sorry to bother you, introducing the newling and all but I need your help...";
            var eL4 = "Okey?";
            var dL3 = "One of our weapons have disappeared. It was there yesterday.";
            var eL5 = "Okey, Dex, Let me get this newling to work and then I will send someone to help you find it.";
            var eL6 = "Oh, I almost forgot about you, let me introduce Dexter to you.";
            var eL7 = "Here we mostly call him by the name Dex but Dexter works too.";
            var eL8 = "Wait...Why don't you go with Dexter and help him?";
            var eL9 = "It can be your first task.";


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL1)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL2)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unknown: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in dL1)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL3)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unknown: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in dL2)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL4)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Unknown: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in dL3)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL5)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL6)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);

            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL7)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL8)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine();
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Erica: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in eL9)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Thread.Sleep(2000);
            Console.WriteLine("\n" + "\n" +
                "Press ENTER when you are finished reading...");
            Console.ReadLine();
        } // A long Dialogue.
        static void dexGB()
        {
            var txt = "I guess you are ready...";
            var txt2 = "You are even stronger than I thought you would be.";
            var txt3 = "Please, come back as soon as you find Erica.";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Dexter: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in txt)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Dexter: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in txt2)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Dexter: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var character in txt3)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine("\n" + "\n" + "\n" + "Press 'ENTER' when you are ready.");
            Console.ReadLine();
        } // Dexter goodbye w/ adventure start.
        static void sHouse()
        {
            var sH = "You walked and you walked, until you finally reached a house.";
            var sH2 = "You saw alot of spider web.";
            var sH3 = "Then you saw it, the spider...!";
            var sH4 = "It was almost the same size as the house.";

            foreach (var character in sH)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Thread.Sleep(250);
            Console.WriteLine();
            foreach (var character in sH2)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Thread.Sleep(750);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var character in sH3)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(250);
            Console.WriteLine();
            foreach (var character in sH4)
            {
                Console.Write(character);
                Thread.Sleep(txtSpeed);
            }
            Console.WriteLine("\n" + "Press 'ENTER' when you are ready to continue");
            Console.ReadLine();
        } // When you find the spider house.


        // Fight & other Mechanics
        static void fightPlayer()
        {
            int wtr = rand.Next(4, 7);
            int dmgOrCrit = rand.Next(1, 20);

            if (dmgOrCrit >= 1 && dmgOrCrit <= 17)
            {
                if (choice == 1)
                {
                    water = water - wtr;
                    enmyHealth = enmyHealth - swordDmg;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You did " + swordDmg + " Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
                if (choice == 2)
                {
                    water = water - wtr;
                    enmyHealth = enmyHealth - knifeDmg;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You did " + knifeDmg + " Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
                if (choice == 3)
                {
                    water = water - wtr;
                    enmyHealth = enmyHealth - fistDmg;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You did " + fistDmg + " Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
            }
            if (dmgOrCrit >= 18)
            {
                int critSword = rand.Next(2, 3);
                int critKnife = rand.Next(2, 8);
                int critFist = rand.Next(2, 4);

                if (choice == 1)
                {
                    water = water - wtr;
                    swordCrit = 0;
                    swordCrit = swordDmg * critSword;
                    enmyHealth = enmyHealth - swordCrit;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You did a critical hit for " + swordCrit + "Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
                if (choice == 2)
                {
                    water = water - wtr;
                    knifeCrit = 0;
                    knifeCrit = knifeDmg * critKnife;
                    enmyHealth = enmyHealth - knifeCrit;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You did a critical hit for " + knifeCrit + "Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
                if (choice == 3)
                {
                    water = water - wtr;
                    fistCrit = 0;
                    fistCrit = fistDmg * critFist;
                    enmyHealth = enmyHealth - fistCrit;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You did a critical hit for " + fistCrit + "Damage");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(750);
                }
            }
        } // Player fighting mechanics
        static void fightEnemy()
        {
            int enemyDmg = 7;
            int enmyRandDmg = rand.Next(0, 20);

            if (enmyRandDmg >= 0 && enmyRandDmg <= 18)
            {
                hp = hp - enemyDmg;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The spider did " + enemyDmg + " Damage on you...");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(750);
            }
            if (enmyRandDmg >= 19)
            {
                int crit = rand.Next(2, 4);
                int enemyCrit = enemyDmg * crit;
                hp = hp - enemyCrit;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The spider did " + enemyCrit + " Damage on you...");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(750);
            }
        } // Enemy fighting mechanics
        static void drinkWater()
        {
            water = water + 20;

            if (water < 100)
            {
                wBottle = wBottle - 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You picked up your Water Bottle and drank it all up...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+20%");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1250);
            }
            else if (water >= 100)
            {
                water = water - 20;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You are not thirsty enough.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(750);
            }
        } // Drinking whater mechanic.
        static void healthWater()
        {
            yy = yy - A;
            xx = xx - B;
            yyy = yyy - C;
            A = 0;
            B = 0;
            C = 0;

            for (int i = 1; i < 40; i++)
            {
                Console.Write("-");
            }
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(18, yy);
                yy = yy + 1;
                A = A + 1;
                Console.Write("|");
            }
            for (int i = 1; i < 40; i++)
            {
                Console.SetCursorPosition(xx, 6);
                xx = xx + 1;
                B = B + 1;
                Console.Write("-");
            }
            for (int i = 1; i < 6; i++)
            {
                Console.SetCursorPosition(37, yyy);
                yyy = yyy + 1;
                C = C + 1;
                Console.Write("|");
            }

            Console.SetCursorPosition(3, 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Water:");
            if (water <= 100)
            {
                Console.SetCursorPosition(10, 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (water > 35 && water <= 75)
            {
                Console.SetCursorPosition(10, 4);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (water <= 35)
            {
                Console.SetCursorPosition(10, 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Health:");

            if (hp <= 100)
            {
                Console.SetCursorPosition(11, 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (hp > 50 && hp <= 75)
            {
                Console.SetCursorPosition(11, 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (hp <= 25)
            {
                Console.SetCursorPosition(11, 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(21, 2);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enemy Health:");
            Console.ForegroundColor = ConsoleColor.White;

            if (enmyHealth <= 250)
            {
                Console.SetCursorPosition(26, 4);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(enmyHealth);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (enmyHealth > 75 && enmyHealth <= 150)
            {
                Console.SetCursorPosition(26, 4);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(enmyHealth);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (enmyHealth <= 30)
            {
                Console.SetCursorPosition(26, 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(enmyHealth);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.SetCursorPosition(0, 8);
        }// Health and water UI during Fight
        static void bag()
        {
            y = 4;

            Console.Clear();
            Console.WriteLine("|                                            |\n" +
                            "|--------------------------------------------|\n" +
                            "|            |                  |            |\n" +
                            "|--------------------------------------------|\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|            |                  |            |\n" +
                            "|--------------------------------------------|\n" +
                            "|                                            |\n" +
                            "|--------------------------------------------|\n" +
                            "|                                            |\n" +
                            "|--------------------------------------------|\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(17, 0);
            Console.WriteLine("|-Backpack-|");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("Choice");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(21, 2);
            Console.WriteLine("Item");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(36, 2);
            Console.WriteLine("Amount");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(8, 23);
            Console.WriteLine("[D]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(12, 23);
            Console.WriteLine("Destroy    |");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(29, 23);
            Console.WriteLine("[U]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(33, 23);
            Console.WriteLine("Use");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(1, 25);
            Console.WriteLine("[GB] To Exit The Backpack.");
            Console.ForegroundColor = ConsoleColor.White;

            if (inv <= 15 && inv != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(12, 21);
                Console.WriteLine("Backpack Space:");
                Console.ForegroundColor = ConsoleColor.White;
                if (inv <= 15)
                {
                    Console.SetCursorPosition(29, 21);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(inv);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (inv > 7 && inv <= 12)
                {
                    Console.SetCursorPosition(29, 21);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(inv);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (inv <= 4)
                {
                    Console.SetCursorPosition(29, 21);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inv);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if (inv == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(15, 21);
                Console.WriteLine("Backpack is full.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (sword >= 1)
            {
                ctrl = ctrl + 1;
                y = y + 1;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("(" + sword + ")");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(x2, y);
                Console.WriteLine("[S]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x3, y);
                Console.WriteLine("Rusty Sword");
            }
            if (knife >= 1)
            {
                ctrl = ctrl + 1;
                y = y + 1;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("(" + knife + ")");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(x2, y);
                Console.WriteLine("[K]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x3, y);
                Console.WriteLine("Rusty Knife");
            }
            if (bow >= 1)
            {
                ctrl = ctrl + 1;
                y = y + 1;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("(" + bow + ")");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(x2, y);
                Console.WriteLine("[B]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x3, y);
                Console.WriteLine("Damaged Bow");

            }
            if (wBottle >= 1)
            {
                y = y + 1;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("(" + wBottle + ")");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(x2, y);
                Console.WriteLine("[W]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x3, y);
                Console.WriteLine("Water Bottle");
            }
            Console.SetCursorPosition(1, 26);
            decision = Console.ReadLine();

            if (decision == "D" || decision == "d")
            {
                while (decision != "GB" || decision != "Gb" || decision != "gb")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Which Item would you like to destroy?");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (sword >= 1)
                    {
                        Console.WriteLine("[S] Rusty Sword (" + sword + ")");
                    }
                    if (bow >= 1)
                    {
                        Console.WriteLine("[B] Damaged Bow(" + bow + ")");
                    }
                    if (wBottle >= 1)
                    {
                        Console.WriteLine("[W] Water Bottle(" + wBottle + ")");
                    }
                    Console.WriteLine("\n" + "[GB] Go back");
                    decision = Console.ReadLine();

                    if (decision == "S" || decision == "s")
                    {
                        sword = sword - 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You destroyed your Rusty Sword.");
                        Thread.Sleep(750);
                    }
                    if (decision == "B" || decision == "b")
                    {
                        bow = bow - 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You destroyed your Damaged Bow.");
                        Thread.Sleep(750);
                    }
                    if (decision == "W" || decision == "w")
                    {
                        wBottle = wBottle - 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You destroyed your Water Bottle.");
                        Thread.Sleep(750);
                    }
                    if (decision == "GB" || decision == "Gb" || decision == "gb")
                    {
                        bag();
                    }
                }
            }
            if (decision == "U" || decision == "u")
            {
                while (decision != "GB" || decision != "Gb" || decision != "gb")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Which Item would you like to Use?\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (wBottle >= 1)
                    {
                        Console.WriteLine("[W] Water Bottle(" + wBottle + ")");
                    }
                    Console.WriteLine("\n" + "[GB] Go back");
                    decision = Console.ReadLine();

                    if (decision == "W" || decision == "w")
                    {
                        if (water < 100)
                        {
                            wBottle = wBottle - 1;
                            water = water + 20;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You picked up your Water Bottle and drank it all up...");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("+20%");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(1250);
                        }
                        if (water >= 100)
                        {
                            water = water - 20;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("You are not thirsty");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(750);
                        }
                    }
                    if (decision == "GB" || decision == "Gb" || decision == "gb")
                    {
                        bag();
                    }
                }
            }
            if (decision == "S" || decision == "s")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The Rusty Sword\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Damage: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(swordDmg);
                Console.WriteLine("\n" + "The Rusty Sword is almost a relic.\n" +
                    "It is said to have been worn by the first knight.");
                Console.WriteLine("\n" + "Press 'ENTER' to go backwards.");
                Console.ReadLine();
            }
            if (decision == "K" || decision == "k")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The Rusty Knife\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Damage: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(knifeDmg);
                Console.WriteLine("\n" + "The Rusty knife is said to have killed the first king of Sweden.\n" +
                    "But we all know that is not true...or is it?");
                Console.WriteLine("\n" + "Press 'ENTER' to go backwards.");
                Console.ReadLine();
            }
            if (decision == "B" || decision == "b")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The Damaged Bow\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Damage: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(bowDmg);
                Console.WriteLine("\n" + "This bow is really damaged, like really...\n" +
                    "Using this bow you will do literally nothing since it is really damaged?");
                Console.WriteLine("\n" + "Press 'ENTER' to go backwards.");
                Console.ReadLine();
            }
            if (decision == "GB" || decision == "Gb" || decision == "gb" || decision == "gB")
            {
                Thread.Sleep(250);
                if (adv >= 1)
                {
                    adv = adv - 1;
                    adventure();
                }
                if (dFo >= 1)
                {
                    dFo = dFo - 1;
                    dForest();
                }
            }
            else
            {
                Console.WriteLine();
                bag();
            }
        } // Backpack System
        static void HUD()
        {
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("|                                                                      |");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.SetCursorPosition(27, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-| Interface |-");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Water:");
            if (water <= 100)
            {
                Console.SetCursorPosition(12, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (water > 35 && water <= 75)
            {
                Console.SetCursorPosition(12, 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (water <= 35)
            {
                Console.SetCursorPosition(12, 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(water + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Health:");

            if (hp <= 100)
            {
                Console.SetCursorPosition(13, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (hp > 35 && hp <= 75)
            {
                Console.SetCursorPosition(13, 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (hp <= 34)
            {
                Console.SetCursorPosition(13, 3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(hp + "%");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(21, 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("[E] Backpack");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(21, 3);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Available Space:");
            Console.ForegroundColor = ConsoleColor.White;
            if (inv <= 15)
            {
                Console.SetCursorPosition(38, 3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(inv);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (inv > 7 && inv <= 12)
            {
                Console.SetCursorPosition(38, 3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(inv);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (inv <= 4)
            {
                Console.SetCursorPosition(38, 3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(inv);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.SetCursorPosition(46, 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Username: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(username);
            Console.SetCursorPosition(0, 7);
            Console.WriteLine();

        } // Interface System
        static void textS()
        {

            Console.Clear();
            Console.WriteLine("The higher the value, the slower the text will write out...");
            Console.Write("It is currently writing out one character every ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(txtSpeed + "ms.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'ENTER' to go back to the Main Menu.\n" +
                "\n");
            Console.WriteLine("Text Speed: 0-5");
            Console.Write("Speed: ");
            text = Console.ReadLine();

            int temp = 0;
            bool canConvert = int.TryParse(text, out temp);
            if (canConvert)
            {
                int txt = int.Parse(text);

                if (txt >= 0 && txt <= 5)
                {
                    txtSpeed = txt * 15;
                }
                else
                {
                    Console.WriteLine("That doesn't work, try again...");
                    Thread.Sleep(500);
                    textS();
                }
                Console.WriteLine("You successfully choose " + txt);
                Console.WriteLine("Going back to the Main Menu...");
                Thread.Sleep(1000);
                MainMenu();
            }
            else
            {
                Console.WriteLine("That doesn't work, try again...");
                Thread.Sleep(500);
                textS();
            }
        } // Text Speed configuration
        static void VariableReset()
        {
            sword = 0; ; // Sword
            swordDmg = 23; // Sword Damage
            swordCrit = 3; // The value for the sword damage times the crit.
            wBottle = 0; // Water bottle.
            knife = 0; // Knife
            knifeDmg = 14; // Knife Damage
            knifeCrit = 8; // The value for the knife damage times the crit.
            fistDmg = 11; // Fist damage.
            fistCrit = 4; // The value for the fist damage times the crit.
            bow = 0; // Bow
            bowDmg = 0; // Bow Damage which is purely zero due to it being a useless weapon.
            inv = 15; // Inventory size
            water = 100; // Amount of water.
            hp = 100; // Health.
            x = 37; // X position
            y = 4; // Y position
            x2 = 5; // X2 position
            x3 = 17; // X3 position
            ctrl = 0; // Made for easier navigation throughout the code.
            adv = 0; // Made for easier navigation throughout the code.
            dFo = 0; // Made for easier navigation throughout the code.
            choice = 0; // A form of navigation throughout the code.
            enmyHealth = 250; // Enemy Spider Health.
        }
    }
}

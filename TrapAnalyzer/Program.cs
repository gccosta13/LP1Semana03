using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trp = Enum.Parse<TrapType>(args[0]);
            PlayerGear gr = ParseGear(args);
            bool sv = CanSurviveTrap(trp, gr);
            DisplayResult(trp, sv);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear grParsed = new PlayerGear();

            for (int x = 0; x < args.Length; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    grParsed ^= Enum.Parse<PlayerGear>(args[x]);
                }
            }

            return grParsed;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trp">The trap the player falls into.</param>
        /// <param name="gr">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trp, PlayerGear gr)
        {
            bool canSurvive = false;

            switch (trp)
            {
                case TrapType.FallingRocks:

                    if ((gr & PlayerGear.Helmet) == PlayerGear.Helmet)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.SpinningBlades:

                    if ((gr & PlayerGear.Shield) == PlayerGear.Shield)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.PoisonGas:

                    if ((gr & PlayerGear.Helmet) == PlayerGear.Helmet ||
                        (gr & PlayerGear.Shield) == PlayerGear.Shield)
                    {
                        canSurvive = true;
                    }
                    break;

                case TrapType.LavaPit:

                    if ((gr & PlayerGear.Boots) == PlayerGear.Boots)
                    {
                        canSurvive = true;
                    }
                    break;
            }

            return canSurvive;

        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trp">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trp, bool svs)
        {
            if (svs)
            {
                Console.WriteLine($"Player survives {trp.ToString()}");
            }
            else
            {
                Console.WriteLine($"Player dies due to {trp.ToString()}");
            }

        }
    }
}
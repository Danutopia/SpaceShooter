using System;
using System.Collections.Generic;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.Projectile;
using SpaceShooter.Object.SpaceStone;
using SpaceShooter.Object.Star;

namespace SpaceShooter.Utils
{
    public static class GameManager
    {

        public static Boolean isRunning { get; set; } = false;
        public static Boolean gameOver { get; set; } = false;
        public static int points { get; set; } = 0;
        public static int difficulty { get; set; } = 250;


        public static String direction { get; set; } = "";

        public static List<NormalProjectile> normalProjectilesContainer = new List<NormalProjectile>();
        
        //SpaceShip Container
        public static List<PlayerShip> playerContainer = new List<PlayerShip>();

        //Stone Container
        public static List<Type1Stone> type1StoneContainer = new List<Type1Stone>();
        public static List<Type2Stone> type2StoneContainer = new List<Type2Stone>();

        //Star Container
        public static List<NormalStar> normalStarContainer = new List<NormalStar>();
        public static List<SuperStar> superStarContainer = new List<SuperStar>();


        //
        public static List<int> possibleXpos = new List<int>();
        public static List<int> possibleYpos = new List<int>();

        private static Boolean possiblePosGenerated = false;
        public static void generatePossiblePosition()
        {
            if (!possiblePosGenerated)
            {
                possiblePosGenerated = true;

                for (int i = 10; i <= 1090;)
                {

                    possibleXpos.Add(i);
                    i += 10;
                }

                for (int i = 10; i <= 560;)
                {
                    possibleYpos.Add(i);
                    i += 10;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.PowerUP;
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

        //PowerUP Container
        public static List<HealPowerUP> healPowerUPContainer = new List<HealPowerUP>();
        public static List<ShieldPowerUP> shieldPowerUPContainer = new List<ShieldPowerUP>();
        public static List<SpeedPowerUP> speedPowerUPContainer = new List<SpeedPowerUP>();
        public static List<StrengthPowerUP> strengthPowerUPContainer = new List<StrengthPowerUP>();

        //Projectile Container
        public static List<BurstProjectile> burstProjectilesContainer = new List<BurstProjectile>();
        public static List<FireProjectile> fireProjectilesContainer = new List<FireProjectile>();
        public static List<LaserProjectile> laserProjectilesContainer = new List<LaserProjectile>();
        public static List<NormalProjectile> normalProjectilesContainer = new List<NormalProjectile>();
        
        //SpaceShip Container
        public static List<EnemyShip> enemyContainer = new List<EnemyShip>();
        public static List<PlayerShip> playerContainer = new List<PlayerShip>();

        //Stone Container
        public static List<Type1Stone> type1StoneContainer = new List<Type1Stone>();
        public static List<Type2Stone> type2StoneContainer = new List<Type2Stone>();
        public static List<Type3Stone> type3StoneContainer = new List<Type3Stone>();

        //Star Container
        public static List<NormalStar> normalStarContainer = new List<NormalStar>();
        public static List<SuperStar> superStarContainer = new List<SuperStar>();

    }
}

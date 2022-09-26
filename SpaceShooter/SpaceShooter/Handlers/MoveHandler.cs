using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using SpaceShooter.Utils;
using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.SpaceStone;
using System.Windows.Controls;

namespace SpaceShooter
{
    class MoveHandler
    {

        public static void callMoveEvent(Canvas feld)
        {
            clearCanvas(feld);

            for (int i = 0; i < GameManager.playerContainer.Count; i++)
            {
                GameManager.playerContainer[i].Draw(feld);
            }

            for (int i = 0; i < GameManager.type1StoneContainer.Count; i++)
            {
                GameManager.type1StoneContainer[i].Draw(feld);
            }
        }


        private static void checkCollision(Canvas feld)
        {
            
        }
        private static void clearCanvas(Canvas feld)
        {
            feld.Children.Clear();
        }


    }
}

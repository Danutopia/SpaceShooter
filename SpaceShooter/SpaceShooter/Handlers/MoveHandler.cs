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
        Random random = new Random();
        public void stoneDrop()
        {
            List<Type1Stone> stoneContainer = GameManager.type1StoneContainer;

            for (int i = 0; i < stoneContainer.Count; i++)
            {
                Type1Stone targetStone = stoneContainer[i];

                int downSprayLeft = targetStone.spray / 2;
                int downSpray = targetStone.spray / 2;
                

                if(targetStone.sprayDirection == "up")
                {
                    targetStone.pos_x += downSprayLeft;
                    targetStone.pos_y += downSpray;
                }
                else if(targetStone.sprayDirection == "down")
                {
                    targetStone.pos_x -= downSprayLeft;
                    targetStone.pos_y -= downSpray;
                }

            }
        }

        public void callMoveEvent(Canvas feld)
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


        private void clearCanvas(Canvas feld)
        {
            feld.Children.Clear();
        }


    }
}

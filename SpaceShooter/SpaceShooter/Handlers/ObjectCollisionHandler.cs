using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.SpaceStone;
using SpaceShooter.Exceptions;
using SpaceShooter.Utils;

namespace SpaceShooter.Handlers
{
    class ObjectCollisionHandler
    {

        int canvasBorderXN = -10;
        int canvasBorderXP = 1110;
         
        int canvasBorderYN = -10;           // YN = Ypos Negativ
        int canvasBorderYP = 570;           // YP = Ypos Positiv
        public void checkPlayerCollision()
        {
            List<PlayerShip> playerContainer = GameManager.playerContainer;
            List<Type1Stone> stoneContainer = GameManager.type1StoneContainer;

            Boolean x_collision = false;
            Boolean y_collision = false;

            for (int playerCounter = 0; playerCounter < playerContainer.Count; playerCounter++)
            {
                for (int stoneCounter = 0; stoneCounter < stoneContainer.Count; stoneCounter++)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        if (playerContainer[playerCounter].pos_x == stoneContainer[stoneCounter].pos_x || (playerContainer[playerCounter].pos_x + (10 * i)) == stoneContainer[stoneCounter].pos_x || (playerContainer[playerCounter].pos_x - (10 * i)) == stoneContainer[stoneCounter].pos_x) {
                            x_collision = true;
                        }

                        if (playerContainer[playerCounter].pos_y == stoneContainer[stoneCounter].pos_y || (playerContainer[playerCounter].pos_y + (10 * i)) == stoneContainer[stoneCounter].pos_y || (playerContainer[playerCounter].pos_y - (10 * i)) == stoneContainer[stoneCounter].pos_y)
                        {
                            y_collision = true;
                        }

                    }

                }

            }

            if(x_collision && y_collision)
            {
                throw new StoneHitException("HIT");
            }

        }


        public void checkPlayerBorderCollision()
        {
            List<PlayerShip> container = GameManager.playerContainer;

            for (int i = 0; i < GameManager.playerContainer.Count; i++)
            {
                if (container[i].pos_x <= canvasBorderXN)
                {
                }
                else if (container[i].pos_x >= canvasBorderXP)
                {
                }

                if (container[i].pos_y <= canvasBorderYN)
                {
                }
                else if (container[i].pos_y >= canvasBorderYP)
                {
                }
            }
        }
        public void checkStone1BorderCollision()
        {
            List<Type1Stone> container = GameManager.type1StoneContainer;

            for (int i = 0; i < container.Count; i++)
            {
                if (container[i].pos_x <= canvasBorderXN)
                {
                    container.RemoveAt(i);
                    throw new StoneHitBorderException("Stone hit box");
                }
                else if (container[i].pos_x >= canvasBorderXP)
                {
                    container.RemoveAt(i);
                    throw new StoneHitBorderException("Stone hit box");
                }

                if (container[i].pos_y <= canvasBorderYN)
                {
                    container.RemoveAt(i);
                    throw new StoneHitBorderException("Stone hit box");
                }
                else if (container[i].pos_y >= canvasBorderYP)
                {
                    container.RemoveAt(i);
                    throw new StoneHitBorderException("Stone hit box");
                }
            }
        }

    }


}

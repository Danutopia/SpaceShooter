using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpaceShooter.Object.SpaceShip;
using SpaceShooter.Object.SpaceStone;
using SpaceShooter.Exceptions;

namespace SpaceShooter.Handlers
{
    class ObjectCollisionHandler
    {
        public void checkPlayerCollision(List<PlayerShip> playerContainer, List<Type1Stone> stoneContainer)
        {
            Boolean x_collision = false;
            Boolean y_collision = false;

            for (int playerCounter = 0; playerCounter < playerContainer.Count; playerCounter++)
            {
                for (int stoneCounter = 0; stoneCounter < stoneContainer.Count; stoneCounter++)
                {
                    for (int i = 1; i < 7; i++)
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


        public void checkPlayerCollision(List<PlayerShip> playerContainer, List<Type2Stone> stoneContainer)
        {

        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter.Interfaces
{
    public interface IMovementController
    {
        public void moveRightDown(int old_posX, int old_posY);
    }
}

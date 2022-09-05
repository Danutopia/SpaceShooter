using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceShooter.Interfaces;
using System.Windows.Controls;

namespace SpaceShooter.Object.Projectile
{
    public class NormalProjectile : DefaultProjectile, IDrawController
    {
        public void Draw(Canvas feld)
        {
            throw new NotImplementedException();
        }
    }
}

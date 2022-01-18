using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorGun
{
    class Pistol : Gun
    {
        public override int DamagePerShot => 1;

        public override float ShotsPerSecond => 1;
    }
}

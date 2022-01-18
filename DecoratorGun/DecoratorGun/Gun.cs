using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorGun
{
    public abstract class Gun
    {
        public abstract int DamagePerShot { get; }
        public abstract float ShotsPerSecond { get; }

        public float DamagePerSecond { get => DamagePerShot * ShotsPerSecond; }
    }
}

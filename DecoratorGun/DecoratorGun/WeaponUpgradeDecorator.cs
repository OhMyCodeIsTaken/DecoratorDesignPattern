using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorGun
{
    public class WeaponUpgradeDecorator : Gun
    {
            protected Gun _gun;

            public WeaponUpgradeDecorator(Gun gun)
            {
                _gun = gun;
            }

            public override int DamagePerShot
            {
                get
                {
                    return _gun.DamagePerShot;
                }
            }

        public override float ShotsPerSecond
            {
                get
                {
                    return _gun.ShotsPerSecond;
                }
            }

    }
}

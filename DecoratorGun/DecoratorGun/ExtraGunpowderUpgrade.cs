using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorGun
{
    class ExtraGunpowderUpgrade : WeaponUpgradeDecorator
    {
        public ExtraGunpowderUpgrade(Gun gun) : base(gun)
        {

        }

        public override int DamagePerShot
        {
            get
            {
                return 1 + base.DamagePerShot;
            }
        }
    }
}

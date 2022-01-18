using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorGun
{
    public class QuickFireUpgrade : WeaponUpgradeDecorator
    {
        public QuickFireUpgrade(Gun gun) : base(gun)
        {

        }

        public override float ShotsPerSecond
        {
            get
            {
                return 0.5f + base.ShotsPerSecond;
            }
        }
    }
}

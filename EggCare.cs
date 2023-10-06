using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeSwarm
{
    public class EggCare : Bee
    {
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }

        private Queen queen;

        public EggCare(Queen queen) : base("Opiekunka jaj")
        {
            this.queen = queen;
        }

        protected override void DoJob()
        {
            queen.CareForEggs(CostPerShift);
        }
    }
}

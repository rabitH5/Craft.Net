using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Craft.Net.Data.Blocks
{
    public class CakeBlock : Block
    {
        public override short Id
        {
            get { return 92; }
        }

        public override double Hardness
        {
            get { return 0.5; }
        }

        public override bool OnBlockRightClicked(Vector3 clickedBlock, Vector3 clickedSide, Vector3 cursorPosition, World world, Entities.Entity usedBy)
        {
            return false;
        }
    }
}

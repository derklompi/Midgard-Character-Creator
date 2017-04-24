using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcreator.Classes
{
    class RangeTest
    {
        // Singe array dual dimentions version

        // @param check 	value to check for
        // @param range		array of range intervals and values
        // @paran defvalue
        public int inrange_single(int check, int[,] range, int defval)
        {
            int rc;
            // range.Length < values.Length ? range.Length-1 : values.Length-1
            // 		get the lovest of the two arrays lengths , subtract 1 since the index is 0 based
            //		search backwards to find the value in range that is lower than the value we are searching for
            //		we do not need to compare with the upper bound since it is implicit ie the upper bound +1
            //		is equal to previous lower bound

            for (rc = range.GetLength(0) - 1; rc >= 0; rc--)
            {
                if (check > range[rc, 0]) return range[rc, 1]; ;
            }
            // not found ? return defval
            return defval;
        }
    }
}

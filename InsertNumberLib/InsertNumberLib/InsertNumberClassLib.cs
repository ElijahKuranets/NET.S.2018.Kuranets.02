using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberLib
{
    #region InsertNumberRealization
    /// <summary>
    /// Class contains algorythm of bit insertion
    /// </summary>
    public static class InsertNumberClassLib
    {
        /// <summary>
        /// Takes bits from <paramref name="numberSource"/> and inserts them into <paramref name="numberln"/> between <paramref name="i"/> and <paramref name="j"/> positions
        /// </summary>
        /// <param name="numberSource">32bit number, accepts insertion</param>
        /// <param name="numberln">32bit number which is being inserted</param>
        /// <param name="i">start position of insertion</param>
        /// <param name="j">end position of insertion</param>
        /// <returns>insertion result </returns>
        public static int InsertNumber(int numberSource, int numberln, int i, int j)
        {
            for (int index = i; index <= j; index++)
            {
                bool bit = numberln.GetNumber(index - i);
                numberSource = numberSource.NumberInsert(bit, index);
            }
            return numberSource;
        }

        public static bool GetNumber(this int value, int bitNumber)
        {
            return (value & (1 << bitNumber)) != 0;
        }

        public static int NumberInsert(this int value, bool bit, int bitNumber)
        {
            if (bit)
            {
                value = value | 1 << bitNumber;
            }
            else
            {
                value = value & ~(1 << bitNumber);
            }

            return value;
        }
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumberLib
{
    public class FNBNClassLib
    {
        #region Public methods
        /// <summary>
        /// Method returns next bigger number that consists of input number digits 
        /// </summary>
        /// <param name="number">
        /// input number</param>
        /// <returns>next bigger number that consists of input number digits. -1 if there is no bigger number variants  </returns>
        public static int FindNextBiggerNumber(int number)
        {

            CheckMethods(number);
            char[] numberIsCharArray = number.ToString().ToCharArray();

            bool OrderByDescending = true;
            for (int i = 0; i < numberIsCharArray.Length - 1; i++)

                if (numberIsCharArray[i] < numberIsCharArray[i + 1])
                {
                    OrderByDescending = false;
                    break;
                }
            if (OrderByDescending)
                return -1;


            for (int i = numberIsCharArray.Length - 1; i > 0; i--)
                if (numberIsCharArray[i] > numberIsCharArray[i - 1])
                {
                    for (int j = numberIsCharArray.Length - 1; j >= i; j--)

                        if (numberIsCharArray[j] > numberIsCharArray[i - 1])
                        {
                            Swap(ref numberIsCharArray[i], ref numberIsCharArray[i - 1]);
                            break;
                        }

                    Array.Reverse(numberIsCharArray, i, numberIsCharArray.Length - i);
                    break;

                }

            Int32.TryParse(new String(numberIsCharArray), out number);
            return number;
        }
        /// <summary>
        /// Method returns next bigger number that consists of input number digits 
        /// </summary>
        /// <param name="number">
        /// input number</param>
        /// <param name="elapsedTime">output parameter to get time of executing code</param>
        /// <returns>next bigger number that consists of input number digits. -1 if there is no bigger number variants  </returns>
        /// <returns></returns>
        public static int FindNextBiggerNumber(int number, out TimeSpan elapsedTime)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int result = FindNextBiggerNumber(number);
            stopWatch.Stop();
            elapsedTime = stopWatch.Elapsed;
            return result;
        }
        #endregion

        #region Private methods
        private static void Swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }

        private static void CheckMethods(int numb)
        {
            if (numb < 0)
            {
                throw new Exception(" The method doesn't process negative numbers.");
            }
        }
        #endregion
    }
}

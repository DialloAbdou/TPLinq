using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq
{
    public static class MonExtension
    {
        /// <summary>
        /// Elle permet de compte 
        /// les nombre pairs 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int CompterPair(this int[] data)
        {
            int cpte = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] %2== 0)
                {
                    cpte++;
                }
            }
            return cpte;
        }

   
    }
}

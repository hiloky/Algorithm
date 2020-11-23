using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Common
{
    public abstract class Utls
    {
        /// <summary>
        /// 尝试转化为int类型
        /// </summary>
        /// <param name="str"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public static int ParseInt(string str, int defaultVal)
        {
            if (string.IsNullOrWhiteSpace(str))
                return defaultVal;

            int val;
            if (!int.TryParse(str, out val))
                val = defaultVal;
            return val;
        }
    }
}

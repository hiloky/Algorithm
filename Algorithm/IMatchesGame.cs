using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public interface IMatchesGame
    {
        /// <summary>
        /// 扣减火柴数
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="row"></param>
        /// <param name="num"></param>
        void Algorithm(List<int> tag, int row,int num);

        /// <summary>
        /// 打印当前剩余结果数
        /// </summary>
        /// <param name="tag"></param>
        void PrintMatches(List<int> tag);

        /// <summary>
        /// 检查输入的行是否正确
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="executor"></param>
        /// <returns></returns>
        int CheckRow(List<int> tag, string executor);
        /// <summary>
        /// 取的数量
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="row"></param>
        /// <param name="executor"></param>
        /// <returns></returns>
        int CheckAccess(List<int> tag, int row, string executor);
    }
}

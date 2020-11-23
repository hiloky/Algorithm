using Algorithm.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Imp
{
    public class MatchesGame : IMatchesGame
    {
        public MatchesGame()
        {

        }

        /// <summary>
        /// 扣减火柴数
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="row"></param>
        /// <param name="num"></param>
        public void Algorithm(List<int> tag, int row, int num)
        {
            tag[row - 1] = tag[row - 1] - num;
        }

        /// <summary>
        /// 打印当前剩余结果数
        /// </summary>
        /// <param name="tag"></param>
        public void PrintMatches(List<int> tag)
        {
            Console.WriteLine("当前结果数为：");
            tag.ForEach(t =>
            {
                Console.Write("第一行：");
                if (t > 0)
                {
                    for (var i = 0;i < t; i++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            });
        }

        /// <summary>
        /// 检查输入的行是否正确
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="row"></param>
        public int CheckRow(List<int> tag,string executor)
        {
            var rowCheck = true;
            var rowRes = 0;
            while (rowCheck)
            {
                Console.WriteLine("请用户【" + executor + "】输入获取第几行火柴：");
                var row = Console.ReadLine();
                rowRes = Utls.ParseInt(row, -1);
                if (rowRes < 1 || rowRes > tag.Count)
                {
                    Console.WriteLine("输入行数有误!");
                    continue;
                }
                if(tag[rowRes-1] <= 0)
                {
                    Console.WriteLine("该行已无火柴可取!");
                    continue;
                }
                rowCheck = false;
            }
            return rowRes;   
        }

        /// <summary>
        /// 取的数量
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="row"></param>
        /// <param name="executor"></param>
        /// <returns></returns>
        public int CheckAccess(List<int> tag,int row,string executor)
        {
            var rowCheck = true;
            var rowRes = 0;
            while (rowCheck)
            {
                Console.WriteLine("请用户【" + executor + "】输入获取火柴数量：");
                var num = Console.ReadLine();
                rowRes = Utls.ParseInt(num, -1);
                if (rowRes < 1)
                {
                    Console.WriteLine("输入数量必须大于0的整数!");
                    continue;
                }
                if (tag[row -1] < rowRes)
                {
                    Console.WriteLine("该行火柴数不足!");
                    continue;
                }
                rowCheck = false;
            }
            return rowRes;
        }
    }
}

using Algorithm.Imp;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Algorithm
{
    /// <summary>
    /// 将15根牙签
    /// 分成三行
    /// 每行自上而下（其实方向不限）分别是3、5、7根
    /// 安排两个玩家，每人可以在一轮内，在任意行拿任意根牙签，但不能跨行
    /// 拿最后一根牙签的人即为输家
    /// </summary>
    class Program
    {
        private static List<int> tag = new List<int>{3, 5, 7};

        /// <summary>
        /// 数组内分别为3，5，7跟火柴
        /// 初始共有三种执行策略，拿3根中的、5根中的、7根中的
        /// 行为人为甲、乙
        /// </summary>
        static void Main(string[] args)
        {
            var msg = string.Empty;
            tag.ForEach(t =>
            {
                msg += t.ToString() + "根、";
            });

            Console.WriteLine("初始火柴有【" + tag.Count + "】排，每排分别为【" + msg.TrimEnd('、') + "】");
            Console.Write("请输入玩家一名称：");
            var str1 = Console.ReadLine();

            Console.Write("请输入玩家二名称：");
            var str2 = Console.ReadLine();

            //注入
            var serviceProvider = new ServiceCollection()
              .AddTransient<IMatchesGame, MatchesGame>()
              .AddTransient<IGameFactory, GameFactory>()
              .BuildServiceProvider();

            var result = serviceProvider.GetService<IGameFactory>().MatchesGame(str1, str2, tag);

            Console.WriteLine("获胜者为：" + result.ToString());
        }

        
    }
}

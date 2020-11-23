using Algorithm.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm
{
    /// <summary>
    /// 当前游戏一种运行模式，此处故工厂模式
    /// </summary>
    public class GameFactory : IGameFactory
    {
        private readonly IMatchesGame _matchesGame;

        public GameFactory(IMatchesGame _matchesGame)
        {
            this._matchesGame = _matchesGame;
        }
        
        /// <summary>
        /// 火柴游戏
        /// </summary>
        public string MatchesGame(string str1,string str2,List<int> tag)
        {
            var condition = true;
            var executor = str1;
            Console.WriteLine("#########################################");
            while (condition)
            {
                //打印信息
                _matchesGame.PrintMatches(tag);
                //输入行数
                var row = _matchesGame.CheckRow(tag, executor);
                //输入取的数量
                var num = _matchesGame.CheckAccess(tag,row, executor);
                //计算
                _matchesGame.Algorithm(tag, row, num);

                if(executor == str1)
                    executor = str2;
                else if(executor == str2)
                    executor = str1;
                //无火柴，最后拿的人输
                if (!tag.Where(t => t > 0).Any())
                {
                    condition = false;
                }
            }

            Console.WriteLine("#########################################");
            return executor;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public interface IGameFactory
    {
        string MatchesGame(string str1, string str2, List<int> tag);
    }
}

using System;
using Cocos.Crypto.Algorithms;
using Cocos.Crypto.Enums;
using Cocos.Crypto.Interfaces;

namespace Cocos.Crypto.Factories
{
    public static class AlgoFactory
    {
        public static IAlgorithm Create(EAlgorithm algo)
        {
            return algo switch
            {
                EAlgorithm.Xxtea => new Xxtea(),
                _ => throw new ArgumentOutOfRangeException(nameof(algo), algo, null)
            };
        }
    }
}
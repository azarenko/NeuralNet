using System;
using System.Security.Cryptography;

namespace NeuralNet.NeuralNet
{
    public class CryptoRandom
    {
        public double RandomValue { get; set; }

        public CryptoRandom()
        {
            RNGCryptoServiceProvider p = new RNGCryptoServiceProvider();
            Random r = new Random(p.GetHashCode());
            this.RandomValue = r.NextDouble();
        }
    }
}

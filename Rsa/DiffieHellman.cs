using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rsa
{
    public class DiffieHellman
    {
        public int P { get; set; }
        public int G { get; set; }
        public int ASecret { get; set; }
        public int BSecret { get; set; }
        public int APublic { get; set; }
        public int BPublic { get; set; }

        private List<int> _simpleNumbers;

        public DiffieHellman()
        {
            Gr.GMath.MaxVal = 40000;
            _simpleNumbers = Gr.GMath.SimpleNumbers();
        }

        #region Decrypt side operations

        public void GeneratePGaA()
        {
            P = Gr.GMath.RandomNumber(_simpleNumbers);
            for (G = 2; G < Gr.GMath.MaxVal; G++)
            {
                if(BigInteger.Pow(G, P - 1) % P == 1) break;
            }

            Random rnd = new Random();
            ASecret = rnd.Next(Gr.GMath.MaxVal / 4, Gr.GMath.MaxVal);
            APublic = (int) (BigInteger.Pow(G, ASecret) % P);
        }

        public void SetBPublic(int bPublic)
        {
            BPublic = bPublic;
        }

        public int GetSecretKeyDecrypt()
        {
            int k = (int) (BigInteger.Pow(BPublic, ASecret) % P);
            return k;
        }

        #endregion


        #region Encrypt side operations

        public void GenerateBb()
        {
            Random rnd = new Random();
            BSecret = rnd.Next(Gr.GMath.MaxVal / 4, Gr.GMath.MaxVal);
            BPublic = (int)(BigInteger.Pow(G, BSecret) % P);
        }

        public void SetAPublic(int aPublic)
        {
            APublic = aPublic;
        }

        public int GetSecretKeyEncrypt()
        {
            int k = (int)(BigInteger.Pow(APublic, BSecret) % P);
            return k;
        }

        #endregion
    }
}

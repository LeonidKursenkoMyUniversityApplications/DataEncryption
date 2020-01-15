using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Gr;

namespace Encrypt
{
    public class Rsa
    {
        public int P { get; set; }
        public int Q { get; set; }
        public int N { get; set; }
        public int Fn { get; set; }
        public int E { get; set; }
        public int K { get; set; }
        public int D { get; set; }

        private List<int> _simpleNumbers;

        public Rsa()
        {
            _simpleNumbers = Gr.GMath.SimpleNumbers();
        }

        public void GenerateAll()
        {
            do
            {
                P = Gr.GMath.RandomNumber(_simpleNumbers);
                Q = Gr.GMath.RandomNearNumber(_simpleNumbers, P);
                N = P * Q;
            } while (N < 12000 || N > 16000);
            Fn = (P - 1) * (Q - 1);
            GetE();
            GetD();
        }

        private void GetE()
        {
            for (E = 10; E < Fn; E++)
            {
                if (E % 2 == 1)
                {
                    var eDivisors = Gr.GMath.GetDivisors(E);
                    for (int i = 0; i < eDivisors.Count; i++)
                    {
                        if(Fn % eDivisors[i] == 0) break;
                        if (i == eDivisors.Count - 1) return;
                    }
                }
            }
            throw new Exception("Невдалося підібрати е");
        }

        private void GetD()
        {
            double d;
            for (K = 1; K < GMath.MaxVal; K++)
            {
                d = (K * Fn + 1d) / E;
                if(d < 0) continue;
                if (d - (int) d < 1E-10)
                {
                    D = (int) d;
                    return;
                }
            }
            throw new Exception("Невдалося підібрати d");
        }

        public string Encrypt(string sourceMessage)
        {
            var encryptMessage = new StringBuilder();
            int m, c;
            foreach (char symbol in sourceMessage)
            {
                m = (int) symbol;
                c = (int)(BigInteger.Pow(m, E) % N);
                encryptMessage.Append((char)c);
            }

            return encryptMessage.ToString();
        }

        public string Decrypt(string encryptedMessage)
        {
            var decryptedMessage = new StringBuilder();
            int m, c;
            foreach (char symbol in encryptedMessage)
            {
                c = (int)symbol;
                m = (int)(BigInteger.Pow(c, D) % N);
                decryptedMessage.Append((char)m);
                Console.WriteLine(m);
            }

            return decryptedMessage.ToString();
        }

    }
}

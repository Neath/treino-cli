
using System;
using System.Collections.Generic;
using System.IO;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> candidato = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] aux = sr.ReadLine().Split(',');
                        string name = aux[0];
                        int votes = int.Parse(aux[1]);

                        if (candidato.ContainsKey(name))
                            candidato[name] += votes;
                        else
                            candidato.Add(name, votes);
                    }
                }
                foreach(KeyValuePair<string, int> cand in candidato)
                {
                    Console.WriteLine(cand.Key + ": " + cand.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

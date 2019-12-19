using System;
using System.IO;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            Stream s = new MemoryStream();
            using (StreamWriter sw = new StreamWriter(s, Encoding.ASCII, 200, true))
            {
                sw.WriteLine("Frohe Weihnachten");
                sw.WriteLine(42);
                sw.WriteLine(false);
                sw.Flush();
            }

            s.Position = 0;

            return s;
        }

        public object Method2(object obj)
        {
            string xmas = string.Empty;
            int num;
            bool falstrue;
            Stream str = (Stream)obj;
            using (StreamReader streamReader = new StreamReader(str))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (int.TryParse(line, out int numVal))
                    {
                        num = numVal;
                    }
                    else if (bool.TryParse(line, out bool boolVal))
                    {
                        falstrue = boolVal;
                    }
                    else
                    {
                        xmas = line;
                    }
                }
            }

            return xmas;
        }
    }
}
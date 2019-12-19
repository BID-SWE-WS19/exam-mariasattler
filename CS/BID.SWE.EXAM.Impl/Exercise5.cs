using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> rows = new List<string>();
            var tcpClient = new TcpClient();
            tcpClient.Connect(str, i);

            var cstream = tcpClient.GetStream();
            using (StreamReader streamReader = new StreamReader(cstream))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    rows.Add(line);
                }
            }
            tcpClient.Close();
            return rows;
        }
    }
}
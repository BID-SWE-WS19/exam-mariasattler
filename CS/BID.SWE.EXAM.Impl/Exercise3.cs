using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MyMap();
        }

        public object Method2()
        {
            Bewegung[] bew = new Bewegung[] { new Springen(), new Laufen() };
            return bew;
        }

    }
}
using BID.SWE1.Exam.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace BID.SWE.EXAM.Impl
{
    public class MyMap : Map
    {
        public override int AddNewCells(int year)
        {
            return year;
        }

        public override string GetMapName()
        {
            return "BID-Map";
        }

        public override float GetMapSize(float amount)
        {
            return amount * amount;
        }
    }
}

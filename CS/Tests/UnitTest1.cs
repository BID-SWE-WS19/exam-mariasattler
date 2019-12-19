using BID.SWE.EXAM.Impl;
using System;
using System.IO;
using Xunit;

namespace CS
{
    public class UnitTest1
    {
        [Fact]
        public void Ex1Methd1_true()
        {
            Exercise1 ex1 = new Exercise1();
            CellPrinter cp = (CellPrinter)ex1.Method1();

            Assert.Equal($"Cell red born on {System.DateTime.Now} is alive", cp.PrintState(true, System.DateTime.Now, "red"));
        }
        [Fact]
        public void Ex1Methd1_notalive()
        {
            Exercise1 ex1 = new Exercise1();
            CellPrinter cp = (CellPrinter)ex1.Method1();

            Assert.Equal($"Cell red born on {System.DateTime.Now} is not alive", cp.PrintState(false, System.DateTime.Now, "red"));
        }
        [Fact]
        public void Ex1Methd1_position()
        {
            Exercise1 ex1 = new Exercise1();
            CellPrinter cp = (CellPrinter)ex1.Method1();
            Assert.Equal("Cell is on Position X:1 Y:1",cp.PrintPostion(1, 1));
        }

        [Fact]
        public void Exercise2Method2_Method2_2()
        {
            Exercise2 e2 = new Exercise2();
            Assert.Equal(2, e2.Method2());
        }
        [Fact]
        public void Excercise2Method3_3_false()
        {
            Exercise2 e2 = new Exercise2();
            Assert.False(e2.Method3(3));
        }
        [Fact]
        public void Excercise2Method3_4_true()
        {
            Exercise2 e2 = new Exercise2();
            Assert.True(e2.Method3(4));
        }
        [Fact]
        public void Excercise3Method1_MapName_true()
        {
            Exercise3 e3 = new Exercise3();
            MyMap mymap = (MyMap)e3.Method1();
            Assert.Equal("BID-Map", mymap.GetMapName());
        }
        [Fact]
        public void Excercise3Method1_MapName_false()
        {
            Exercise3 e3 = new Exercise3();
            MyMap mymap = (MyMap)e3.Method1();
            Assert.NotEqual("BID-Mapt", mymap.GetMapName());
        }
        [Fact]
        public void Excercise3Method1_MapSize_1()
        {
            Exercise3 e3 = new Exercise3();
            MyMap mymap = (MyMap)e3.Method1();
            Assert.Equal(1, mymap.GetMapSize(1));
        }
        [Fact]
        public void Excercise3Method1_AddCell_1()
        {
            Exercise3 e3 = new Exercise3();
            MyMap mymap = (MyMap)e3.Method1();
            Assert.Equal(1, mymap.AddNewCells(1));
        }
        [Fact]
        public void Ex3Method2_Method2_true()
        {
            Exercise3 ex3 = new Exercise3();
            Bewegung[] bew = (Bewegung[])ex3.Method2();

            Assert.Equal(2, bew.Length);
        }
        [Fact]
        public void Ex4Method2_Read_true()
        {
            Exercise4 ex4 = new Exercise4();
            Assert.Equal("Frohe Weihnachten", (string)ex4.Method2(ex4.Method1()));
        }
        [Fact]
        public void Ex4_Method1()
        {
            Exercise4 ex4 = new Exercise4();
            Assert.Equal(typeof(MemoryStream), ex4.Method1().GetType());
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lines.GameEngine.Scoring;

namespace Lines.GameEngine.Test.Scoring
{
    [TestClass]
    public class CheckLinesTest
    {
        [TestMethod]
        public void TestHorizontalLine()
        {
            Field Field = new Field(10, 10);
            int length;
            Cell from;
            Cell to;

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[1, 2].Contain = BubbleSize.Big;
            Field.Cells[1, 2].Color = BubbleColor.Red;
            Field.Cells[1, 3].Contain = BubbleSize.Big;
            Field.Cells[1, 3].Color = BubbleColor.Red;
            Field.Cells[1, 4].Contain = BubbleSize.Big;
            Field.Cells[1, 4].Color = BubbleColor.Red;
            Field.Cells[1, 5].Contain = BubbleSize.Big;
            Field.Cells[1, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[1, 3]);

            Assert.IsTrue(_checkLines.CheckLine_Horizontal(out length, out from, out to));
            Assert.AreEqual(length, 5);
            Assert.AreSame(from, Field.Cells[1, 1]);
            Assert.AreSame(to, Field.Cells[1, 5]);
        }
        
        [TestMethod]
        public void TestVerticalLine()
        {
            Field Field = new Field(10, 10);
            int length;
            Cell from;
            Cell to;

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[2, 1].Contain = BubbleSize.Big;
            Field.Cells[2, 1].Color = BubbleColor.Red;
            Field.Cells[3, 1].Contain = BubbleSize.Big;
            Field.Cells[3, 1].Color = BubbleColor.Red;
            Field.Cells[4, 1].Contain = BubbleSize.Big;
            Field.Cells[4, 1].Color = BubbleColor.Red;
            Field.Cells[5, 1].Contain = BubbleSize.Big;
            Field.Cells[5, 1].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[2, 1]);

            Assert.IsTrue(_checkLines.CheckLine_Vertical(out length, out from, out to));
            Assert.AreEqual(length, 5);
            Assert.AreSame(from, Field.Cells[1, 1]);
            Assert.AreSame(to, Field.Cells[5, 1]);
        }

        [TestMethod]
        public void TestLeftDiagonallLine()
        {
            Field Field = new Field(10, 10);
            int length;
            Cell from;
            Cell to;

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[2, 2].Contain = BubbleSize.Big;
            Field.Cells[2, 2].Color = BubbleColor.Red;
            Field.Cells[3, 3].Contain = BubbleSize.Big;
            Field.Cells[3, 3].Color = BubbleColor.Red;
            Field.Cells[4, 4].Contain = BubbleSize.Big;
            Field.Cells[4, 4].Color = BubbleColor.Red;
            Field.Cells[5, 5].Contain = BubbleSize.Big;
            Field.Cells[5, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[3, 3]);

            Assert.IsTrue(_checkLines.CheckLine_LeftDiagonal(out length, out from, out to));
            Assert.AreEqual(length, 5);
            Assert.AreSame(from, Field.Cells[1, 1]);
            Assert.AreSame(to, Field.Cells[5, 5]);
        }

        [TestMethod]
        public void TestRightDiagonalLine()
        {
            Field Field = new Field(10, 10);
            int length;
            Cell from;
            Cell to;

            Field.Cells[5, 1].Contain = BubbleSize.Big;
            Field.Cells[5, 1].Color = BubbleColor.Red;
            Field.Cells[4, 2].Contain = BubbleSize.Big;
            Field.Cells[4, 2].Color = BubbleColor.Red;
            Field.Cells[3, 3].Contain = BubbleSize.Big;
            Field.Cells[3, 3].Color = BubbleColor.Red;
            Field.Cells[2, 4].Contain = BubbleSize.Big;
            Field.Cells[2, 4].Color = BubbleColor.Red;
            Field.Cells[1, 5].Contain = BubbleSize.Big;
            Field.Cells[1, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[2, 4]);

            Assert.IsTrue(_checkLines.CheckLine_RightDiagonal(out length, out from, out to));
            Assert.AreEqual(length, 5);
            Assert.AreSame(from, Field.Cells[1, 5]);
            Assert.AreSame(to, Field.Cells[5, 1]);
        }

        [TestMethod]
        public void TestDoubleLine()
        {
            Field Field = new Field(10, 10);
            int line1Length;
            Cell line1From;
            Cell line1To;
            int line2Length;
            Cell line2From;
            Cell line2To;

            //left diagonal line
            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[2, 2].Contain = BubbleSize.Big;
            Field.Cells[2, 2].Color = BubbleColor.Red;
            Field.Cells[3, 3].Contain = BubbleSize.Big;
            Field.Cells[3, 3].Color = BubbleColor.Red;
            Field.Cells[4, 4].Contain = BubbleSize.Big;
            Field.Cells[4, 4].Color = BubbleColor.Red;
            Field.Cells[5, 5].Contain = BubbleSize.Big;
            Field.Cells[5, 5].Color = BubbleColor.Red;
            //+ vertical line
            Field.Cells[2, 1].Contain = BubbleSize.Big;
            Field.Cells[2, 1].Color = BubbleColor.Red;
            Field.Cells[3, 1].Contain = BubbleSize.Big;
            Field.Cells[3, 1].Color = BubbleColor.Red;
            Field.Cells[4, 1].Contain = BubbleSize.Big;
            Field.Cells[4, 1].Color = BubbleColor.Red;
            Field.Cells[5, 1].Contain = BubbleSize.Big;
            Field.Cells[5, 1].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[1, 1]);

            Assert.IsTrue(_checkLines.CheckLine_LeftDiagonal(out line1Length, out line1From, out line1To));
            Assert.AreEqual(line1Length, 5);
            Assert.AreSame(line1From, Field.Cells[1, 1]);
            Assert.AreSame(line1To, Field.Cells[5, 5]);

            Assert.IsTrue(_checkLines.CheckLine_Vertical(out line2Length, out line2From, out line2To));
            Assert.AreEqual(line2Length, 5);
            Assert.AreSame(line2From, Field.Cells[1, 1]);
            Assert.AreSame(line2To, Field.Cells[5, 1]);
        }

        [TestMethod]
        public void TestCheckMethod_HorizontalLine()
        {
            Field Field = new Field(10, 10);

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[1, 2].Contain = BubbleSize.Big;
            Field.Cells[1, 2].Color = BubbleColor.Red;
            Field.Cells[1, 3].Contain = BubbleSize.Big;
            Field.Cells[1, 3].Color = BubbleColor.Red;
            Field.Cells[1, 4].Contain = BubbleSize.Big;
            Field.Cells[1, 4].Color = BubbleColor.Red;
            Field.Cells[1, 5].Contain = BubbleSize.Big;
            Field.Cells[1, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[1, 3]);

            Assert.IsTrue(_checkLines.Check());
        }

        [TestMethod]
        public void TestCheckMethod_VerticalLine()
        {
            Field Field = new Field(10, 10);

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[2, 1].Contain = BubbleSize.Big;
            Field.Cells[2, 1].Color = BubbleColor.Red;
            Field.Cells[3, 1].Contain = BubbleSize.Big;
            Field.Cells[3, 1].Color = BubbleColor.Red;
            Field.Cells[4, 1].Contain = BubbleSize.Big;
            Field.Cells[4, 1].Color = BubbleColor.Red;
            Field.Cells[5, 1].Contain = BubbleSize.Big;
            Field.Cells[5, 1].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[2, 1]);

            Assert.IsTrue(_checkLines.Check());
        }

        [TestMethod]
        public void TestCheckMethod_LeftDiagonallLine()
        {
            Field Field = new Field(10, 10);

            Field.Cells[1, 1].Contain = BubbleSize.Big;
            Field.Cells[1, 1].Color = BubbleColor.Red;
            Field.Cells[2, 2].Contain = BubbleSize.Big;
            Field.Cells[2, 2].Color = BubbleColor.Red;
            Field.Cells[3, 3].Contain = BubbleSize.Big;
            Field.Cells[3, 3].Color = BubbleColor.Red;
            Field.Cells[4, 4].Contain = BubbleSize.Big;
            Field.Cells[4, 4].Color = BubbleColor.Red;
            Field.Cells[5, 5].Contain = BubbleSize.Big;
            Field.Cells[5, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[3, 3]);

            Assert.IsTrue(_checkLines.Check());
        }

        [TestMethod]
        public void TestCheckMethod_RightDiagonalLine()
        {
            Field Field = new Field(10, 10);

            Field.Cells[5, 1].Contain = BubbleSize.Big;
            Field.Cells[5, 1].Color = BubbleColor.Red;
            Field.Cells[4, 2].Contain = BubbleSize.Big;
            Field.Cells[4, 2].Color = BubbleColor.Red;
            Field.Cells[3, 3].Contain = BubbleSize.Big;
            Field.Cells[3, 3].Color = BubbleColor.Red;
            Field.Cells[2, 4].Contain = BubbleSize.Big;
            Field.Cells[2, 4].Color = BubbleColor.Red;
            Field.Cells[1, 5].Contain = BubbleSize.Big;
            Field.Cells[1, 5].Color = BubbleColor.Red;

            CheckLines _checkLines = new CheckLines(Field, Field.Cells[2, 4]);

            Assert.IsTrue(_checkLines.Check());
        }

    }
}

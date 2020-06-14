using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility___Dominator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codility___Dominator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void solutionTest()
        {
            Program p = new Program();
            int[] A = new int[8];
            A[0] = 3; 
            A[1] = 4;    
            A[2] = 3;
            A[3] = 2;
            A[4] = 3; 
            A[5] = -1;
            A[6] = 3;
            A[7] = 3;
            int output = p.solution(A);
            Assert.IsTrue(output == 0 || output == 2 || output == 4 || output == 6 || output == 7);
        }
    }
}
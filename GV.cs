﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL
{
    class GV
    {
        public static int M = 100, MR = 50, MF = 20;
        public static int nv, nr, nc, nl, itun, itut, inun, inut, bpt, ypt, oa, tr, ioa, itr;
        public static int[,] in_r = new int[MR + 1, 2];
        public static float[] z_r = new float[MR + 1];
        public static int[,] in_c = new int[MR + 1, 2];
        public static float[] z_c = new float[MR + 1];
        public static int[,] in_l = new int[MR + 1, 2];
        public static float[] z_l = new float[MR + 1];
    }
}

﻿using System;
using System.Collections.Generic;

namespace TicTacToeGeneral
{

    public class VictoryConditionEnum
    {

        public List<int[]> ConditionList;

        public readonly int[] Vertical1 = { 1, 4, 7 };
        public readonly int[] Vertical2 = { 2, 5, 8 };
        public readonly int[] Vertical3 = { 3, 6, 9 };

        public readonly int[] Horizontal1 = { 1, 2, 3 };
        public readonly int[] Horizontal2 = { 4, 5, 6 };
        public readonly int[] Horizontal3 = { 7, 8, 9 };

        public readonly int[] DiagonalPrincipal = { 1, 5, 9 };
        public readonly int[] DiagonalSecundaria = { 3, 5, 7 };

        public VictoryConditionEnum()
        {
            ConditionList = new List<int[]>
            {
                Vertical1,
                Vertical2,
                Vertical3,

                Horizontal1,
                Horizontal2,
                Horizontal3,

                DiagonalPrincipal,
                DiagonalSecundaria
            };
        }
    }
}
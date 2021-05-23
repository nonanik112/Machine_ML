﻿using Microsoft.ML.Data;

namespace Machine_ML
{
    public class RankingData
    {
        [LoadColumn(0)]
        public float Label { get; set; }

        [LoadColumn(1)]
        public float GroupId { get; set; }

        [LoadColumn(2, 133)]
        [VectorType(133)]
        public float[] Features { get; set; }
    }
}
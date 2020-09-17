using System;

namespace BKIT_LAB5
{
    public class Distance
    {
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public bool IsOptimized { get; set; }

        private int[,] knownValues;
       
        public Distance()
        {
            Str1 = "";
            Str2 = "";
            IsOptimized = false;
        }

        public Distance(string s1, string s2, bool _isOptimized)
        {
            Str1 = s1;
            Str2 = s2;
            IsOptimized = _isOptimized;
        }

        public int GetLevenDist()
        {
            if (IsOptimized)
            {
                InitValues();
                return CalcOptimizedLevenFor(Str1.Length, Str2.Length);
            }
            else
                return CalcLevenFor(Str1.Length, Str2.Length);
        }

        public int GetDamerLevenDist()
        {
            if (IsOptimized)
            {
                InitValues();
                return CalcOptimizedDamerLevenFor(Str1.Length, Str2.Length);
            }
            else
                return CalcDamerLevenFor(Str1.Length, Str2.Length);
        }

        private void InitValues()
        {
            knownValues = new int[Str1.Length + 1, Str2.Length + 1];
            for (int i = 0; i < Str1.Length + 1; ++i)
            {
                for (int j = 0; j < Str2.Length + 1; ++j)
                {
                    if (i == 0)
                        knownValues[i, j] = j;
                    else if (j == 0)
                        knownValues[i, j] = i;
                    else
                        knownValues[i, j] = int.MaxValue;
                }
            }
        }

        private int CalcLevenFor(int i, int j)
        {
            if (Math.Min(i, j) == 0)
                return Math.Max(i, j);
            return Math.Min(Math.Min(CalcLevenFor(i, j - 1), CalcLevenFor(i - 1, j)) + 1, CalcLevenFor(i - 1, j - 1) + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0));
        }

        private int CalcDamerLevenFor(int i, int j)
        {
            if (Math.Min(i, j) == 0)
                return Math.Max(i, j);
            if (i > 1 && j > 1 && (Str1[i - 1] == Str2[j - 2]) && (Str1[i - 2] == Str2[j - 1]))
                return Math.Min(Math.Min(CalcDamerLevenFor(i, j - 1), CalcDamerLevenFor(i - 1, j)) + 1, Math.Min(CalcDamerLevenFor(i - 1, j - 1) + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0), CalcDamerLevenFor(i - 2, j - 2) + 1));
            return Math.Min(Math.Min(CalcDamerLevenFor(i, j - 1), CalcDamerLevenFor(i - 1, j)) + 1, CalcDamerLevenFor(i - 1, j - 1) + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0));
        }

        private int CalcOptimizedLevenFor(int i, int j)
        {
            if (i == 0 || j == 0)
                return knownValues[i, j];

            if (knownValues[i, j - 1] == int.MaxValue)
                knownValues[i, j - 1] = CalcOptimizedLevenFor(i, j - 1);
            if (knownValues[i - 1, j] == int.MaxValue)
                knownValues[i - 1, j] = CalcOptimizedLevenFor(i - 1, j);

            return Math.Min(Math.Min(knownValues[i, j - 1], knownValues[i - 1, j]) + 1, knownValues[i - 1, j - 1] + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0));
        }

        private int CalcOptimizedDamerLevenFor(int i, int j)
        {
            if (i == 0 || j == 0)
                return knownValues[i, j];

            if (knownValues[i, j - 1] == int.MaxValue)
                knownValues[i, j - 1] = CalcOptimizedDamerLevenFor(i, j - 1);
            if (knownValues[i - 1, j] == int.MaxValue)
                knownValues[i - 1, j] = CalcOptimizedDamerLevenFor(i - 1, j);

            if (i > 1 && j > 1 && (Str1[i - 1] == Str2[j - 2]) && (Str1[i - 2] == Str2[j - 1]))
                return Math.Min(Math.Min(knownValues[i, j - 1], knownValues[i - 1, j]) + 1, Math.Min(knownValues[i - 1, j - 1] + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0), knownValues[i - 2, j - 2] + 1));
            return Math.Min(Math.Min(knownValues[i, j - 1], knownValues[i - 1, j]) + 1, knownValues[i - 1, j - 1] + ((Str1[i - 1] != Str2[j - 1]) ? 1 : 0));
        }
    }
}

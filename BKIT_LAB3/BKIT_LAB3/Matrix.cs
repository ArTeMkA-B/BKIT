using System;
using System.Collections.Generic;
using System.Text;

namespace BKIT_LAB3
{
    public class Matrix<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        int maxX;
        int maxY;
        int maxZ;

        T nullElement;

        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            maxX = px;
            maxY = py;
            maxZ = pz;
            nullElement = nullElementParam;
        }

        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                return (_matrix.ContainsKey(key)) ? _matrix[key] : nullElement;
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                _matrix.Add(key, value);
            }
        }

        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= maxZ) throw new Exception("z=" + z + " выходит за границы");
        }

        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int z = 0; z != maxZ; ++z)
            {
                for (int j = 0; j != maxY; ++j)
                {
                    b.Append("[  ");
                    for (int i = 0; i != maxX; ++i)
                    {
                        if (i > 0) b.Append("  |  ");
                        b.Append(this[i, j, z].ToString());
                    }
                    b.Append("  ]\n");
                }
                b.Append("\n");
            }
            return b.ToString();
        }
    }
}

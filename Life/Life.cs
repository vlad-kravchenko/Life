namespace Life
{
    class Life
    {
        private int[,] map; //0 - empty, 1 - alive, 2 - dying, -1 - borning
        private int [,] sum; //number of creatures to the right and lower than Point(x,y)
        private int w, h;

        public Life(int w, int h)
        {
            this.w = w;
            this.h = h;
            map = new int[w, h];
            sum = new int[w, h];
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    map[x, y] = 0;
                }
            }
        }

        public int Turn(int x, int y)
        {
            map[x, y] = map[x, y] == 0 ? 1 : 0;
            return map[x, y];
        }

        public int GetMap(int x, int y)
        {
            if (x < 0 || x >= w) return 0;
            if (y < 0 || y >= h) return 0;
            return map[x, y];
        }

        public void Step1() //mark where born and dye creatures
        {
            //Prepare();
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    //int a = Around2(x, y);
                    int a = Around1(x, y);
                    if (map[x, y] == 1)
                    {
                        if (a <= 2) map[x, y] = 2;
                        if (a >= 5) map[x, y] = 2;
                    }
                    else
                    {
                        if (a == 3) map[x, y] = -1;
                    }
                }
            }
        }

        public void Step2() //remove dead and place who just born
        {
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    if (map[x, y] == -1) map[x, y] = 1;
                    else if (map[x, y] == 2) map[x, y] = 0;
                }
            }
        }

        private int Around1(int x, int y)
        {
            int sum = 0;

            for (int sx = -1; sx < 2; sx++)
            {
                for (int sy = -1; sy < 2; sy++)
                {
                    if (GetMap(x + sx, y + sy) > 0) sum++;
                }
            }

            return sum;
        }

        #region More efficient but lot more hard

        public int GetSum(int x, int y)
        {
            if (x >= w || y >= h) return 0;
            if (x < 0) x = 0;
            if (y < 0) y = 0;
            return sum[x, y];
        }

        private int Around2(int x, int y)
        {
            return GetSum(x - 1, y - 1) - GetSum(x + 2, y - 1) - GetSum(x - 1, y + 2) + GetSum(x + 2, y + 2);
        }

        private void Prepare()
        {
            for (int x = w - 1; x > -1; x--)
            {
                for (int y = h - 1; y > -1; y--)
                {
                    sum[x, y] = (GetMap(x, y) > 0 ? 1 : 0) + GetSum(x + 1, y) + GetSum(x, y + 1) - GetSum(x + 1, y + 1);
                }
            }
        }
        
        #endregion
    }
}

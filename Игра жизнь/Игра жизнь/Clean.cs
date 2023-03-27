using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_жизнь
{
    class Clean
    {
        int[,] map;
        int w, h;

        //очистка всего поля
        public Clean(int w, int h)
        {
            this.w = w;
            this.h = h;
            map = new int[w, h];
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                    map[x, y] = 0;
        }

        //функция для размещения и очистки клеток
        public int turn(int x, int y)
        {
            if (map[x, y] == 0)
                map[x, y] = 1;
            else
                map[x, y] = 0;
            return map[x, y];
        }

        public int get(int x, int y)
        {
            return map[x, y];
        }

        private int around(int x, int y)
        {
            int sum = 0;
            for (int a = -1; a <= 1; a++)
                for (int b = -1; b <= 1; b++)
                    if (!(a == 0 && b == 0))
                    {
                        if (map[(x + a + w) % w, (y + b + h) % h] > 0)
                            sum++;
                    }
            return sum;
        }

        public void stap1()
        {
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    int a = around(x, y);
                    if (map[x, y] == 1)
                    {
                        if (!(a == 2 || a == 3))
                            map[x, y] = 2;
                    }
                    else
                    {
                        if (a == 3)
                            map[x, y] = -1;
                    }
                }
        }

        public void stap2()
        {
            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    if (map[x, y] == -1)
                        map[x, y] = 1;
                    else
                        if (map[x, y] == 2)
                        map[x, y] = 0;
                }
        }
    }
}

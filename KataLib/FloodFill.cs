using System;
using System.Collections.Generic;
using System.Linq;

namespace KataLib
{
    public class FloodFillClass
    {
        public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
        {
            var size = array.GetLength(y);
            
            for(var i = 0; i < size; i++)
            {
                var lst = Enumerable.Range(0, size).Select(j => array[i, j]).ToList();
                var str = string.Join(",", lst);
                Console.WriteLine("{" + str + "}");
            }

            var oldValue = array[y, x];
            var s = new Stack<FloodPoint>();
            s.Push(new FloodPoint() { X = x, Y = y });

            void Scan(int lx, int rx, int y, ref Stack<FloodPoint> s)
            {
                var range = Enumerable.Range(lx, rx - lx + 1);
                foreach (var x in range)
                {
                    if (array[y, x] == oldValue)
                    {
                        var pt = new FloodPoint() { X = x, Y = y };
                        if (!s.Contains(pt))
                        {
                            s.Push(pt);
                        }
                    }
                }
            }

            while (s.Count > 0)
            {
                var item = s.Pop();
                var lx = item.X;
                y = item.Y;

                while (lx > 0 && array[lx - 1, y] == oldValue)
                {
                    array[y, lx - 1] = newValue;
                    lx--;
                }
                while (x < size && array[y, x] == oldValue)
                {
                    array[y, x] = newValue;
                    x++;
                }
                array[y, lx] = newValue;
                if (x > 1)
                {
                    if(y < size-1)
                        Scan(lx, x - 1, y + 1, ref s);
                    if(y > 0)
                        Scan(lx, x - 1, y - 1, ref s);
                }
            }

            return array;
        }



        public class FloodPoint
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        //public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
        //{
        //    var done = new List<FloodPoint>();
        //    var queue = new Queue<FloodPoint>();
        //    var icon = array[y, x];
        //    void FillQueue(int y, int x)
        //    {
        //        if (array[y, x] == icon)
        //        {
        //            var p = new FloodPoint { Y = y, X = x };
        //            if (!done.Contains(p) && !queue.Contains(p))
        //                queue.Enqueue(p);
        //        }
        //    }

        //    queue.Enqueue(new FloodPoint { Y = y, X = x });

        //    while (queue.Count > 0)
        //    {
        //        var current = queue.Dequeue();
        //        if (current.X > 0)
        //            FillQueue(current.Y, current.X - 1);
        //        if (current.X < array.GetLength(0) - 1)
        //            FillQueue(current.Y, current.X + 1);
        //        if (current.Y > 0)
        //            FillQueue(current.Y - 1, current.X);
        //        if (current.Y < array.GetLength(0) - 1)
        //            FillQueue(current.Y + 1, current.X);
        //        array[current.Y, current.X] = newValue;
        //        done.Add(current);
        //    }

        //    return array;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace KataLib
{
    public static class BattleshipField
    {
        public static bool ValidateBattlefield(int[,] field)
        {
            int[] oneline = field.Cast<int>().ToArray();
            int j = 0;
            int[][] jagged = oneline.GroupBy(x => j++ / field.GetLength(1))
                                        .Select(y => y.ToArray())
                                        .ToArray();

            Console.WriteLine(oneline.Length);
            foreach(var line in jagged)
            {
                foreach(var item in line)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            var result = oneline.Sum() == 20
                    && jagged.MatchesShipCountAndSizes();

            Console.WriteLine(result);
            return result;
        }

        public static bool MatchesShipCountAndSizes(this int[][] battlefield)
        {
            var cells = battlefield.Select((o, j) => o.Select((x, i) => new { Val = x, X = j, Y = i }))
                            .SelectMany(o => o)
                            .Where(o => o.Val == 1)
                            .Select(o => new Point(o.X, o.Y))
                            .ToList();

            var clusters = new List<List<Point>>();
            var clustered = new List<Point>();
            for (int i = 0; i < cells.Count; i++)
            {
                var c = cells[i];
                
                var neighbours = cells.Neighbours(c);
                foreach (var cluster in clusters)
                {
                    if (neighbours.Any(o => cluster.Contains(o)))
                    {
                        // add to existing cluster
                        cluster.Add(c);
                        clustered.Add(c);
                        break;
                    }
                }

                if(!clustered.Contains(c))
                {
                    // new cluster
                    clusters.Add(new List<Point>() { c });
                    clustered.Add(c);
                }
            }

            return clusters.ValidateClusters();
        }

        public static List<Point> Neighbours(this List<Point> cells, Point p)
            => cells.Where(o =>
                            (Math.Abs(p.X - o.X) == 1 && p.Y == o.Y) 
                                || (Math.Abs(p.Y - o.Y) == 1 && p.X == o.X) 
                                || (Math.Abs(p.X - o.X) == 1 && Math.Abs(p.Y - o.Y) == 1))
                            .ToList();

        public static bool ValidateClusters(this List<List<Point>> clusters)
        {
            if (clusters.Count != 10)
                return false;
            else if (clusters.Where(o => o.Count == 1).Count() != 4)
                return false;
            else if (clusters.Where(o => o.Count == 2).Count() != 3)
                return false;
            else if (clusters.Where(o => o.Count == 3).Count() != 2)
                return false;
            else if (clusters.Where(o => o.Count == 4).Count() != 1)
                return false;
            else
                return clusters.All(o => o.IsOneLine());
        }

        public static bool IsOneLine(this List<Point> cluster)
            => cluster.All(o => o.X == cluster.First().X) || cluster.All(o => o.Y == cluster.First().Y);
    }


    //public static bool ValidateBattlefield(int[,] field)
    //{
    //    var ships = new List<int>();
    //    for (var x = 0; x < 10; x++)
    //        for (var y = 0; y < 10; y++)
    //            if (field[x, y] == 1)
    //            {
    //                var length = 1;
    //                while (x + length < 10 && field[x + length, y] == 1)
    //                    field[x + length++, y] = 0;
    //                while (y + length < 10 && field[x, y + length] == 1)
    //                    field[x, y + length++] = 0;
    //                ships.Add(length);
    //            }
    //    ships.Sort();
    //    return string.Join("", ships) == "1111222334";
    //}
}

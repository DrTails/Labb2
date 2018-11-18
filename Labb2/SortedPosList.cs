using System;
using System.Linq;
using System.Collections.Generic;
namespace Labb2
{
    public class SortedPosList
    {

        private List<Position> PositionsList { get; set; }

        public SortedPosList()
        {
            PositionsList = new List<Position>();
        }

        public override string ToString()
        {
            return string.Join(", ", PositionsList);
        }

        public int Count()
        {
            return PositionsList.Count;
        }

        public void Add(Position pos)
        {
            PositionsList.Add(pos);
            PositionsList = PositionsList.OrderBy(p => p.Length()).ToList();
        }

        public bool Remove(Position pos)
        {
            if (PositionsList.Contains(pos))
            {
                PositionsList.Remove(pos);
                return true;
            }
            else
            {
                return false;
            }
        }

        public SortedPosList Clone()
        {
            SortedPosList cloneList = new SortedPosList();
            foreach (Position p in PositionsList)
            {
                cloneList.Add(p.Clone());
            }
            return cloneList;
        }

        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            SortedPosList circleList = new SortedPosList();
            foreach (Position p in PositionsList)
            {
                if ((Math.Pow(p.X - centerPos.X, 2) + (Math.Pow(p.Y - centerPos.Y, 2))) < Math.Pow(radius, 2))
                {
                    circleList.Add(p.Clone());
                }
            }
            return circleList;
        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList combinedList = new SortedPosList();
            foreach (Position p in sp1.PositionsList)
            {
                combinedList.Add(p.Clone());
            }
            foreach (Position p in sp2.PositionsList)
            {
                combinedList.Add(p.Clone());
            }
            return combinedList;
        }

    }
}

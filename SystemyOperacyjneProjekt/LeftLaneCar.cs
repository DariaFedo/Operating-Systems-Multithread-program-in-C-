using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemyOperacyjneProjekt
{
    class LeftLaneCar
    {
        private Point _currentPosition;
        private Point _nextPosition;
        private int _index;
        private Point[] _path;

        public Point[] Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public Point CurrentPosition
        {
            get { return _currentPosition; }
            set { _currentPosition = value; }
        }
        public Point NextPosition
        {
            get { return _nextPosition; }
            set { _nextPosition = value; }
        }
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public LeftLaneCar()
        {
            Point[] leftLane = { new Point(0, 193), new Point(701, 193), new Point(732, 211), new Point(771, 239), new Point(797, 274), new Point(814, 314),
                            new Point(800, 363), new Point(762, 409), new Point(728, 431), new Point(660, 439), new Point(202, 443), new Point(162, 469),
                            new Point(139, 521), new Point(154, 564), new Point(191, 595), new Point(229, 605), new Point(934, 605)};

            Path = leftLane;

            CurrentPosition = Path[0];
            Index = 1;
            NextPosition = Path[Index];

        }

        public void MoveCarOnLeftLane()
        {
            int xdiff = CurrentPosition.X - NextPosition.X;
            int ydiff = CurrentPosition.Y - NextPosition.Y;
            if (xdiff < 0)
                CurrentPosition = new Point(CurrentPosition.X + 1, CurrentPosition.Y);
            if (xdiff > 0)
                CurrentPosition = new Point(CurrentPosition.X - 1, CurrentPosition.Y);
            if (ydiff < 0)
                CurrentPosition = new Point(CurrentPosition.X, CurrentPosition.Y + 1);
            if (ydiff > 0)
                CurrentPosition = new Point(CurrentPosition.X, CurrentPosition.Y - 1);
            if (CurrentPosition == NextPosition)
                Index++;
            if (Index < Path.Length)
                NextPosition = Path[Index];
        }
    }
}

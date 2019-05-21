using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemyOperacyjneProjekt
{
    class RightLaneCar
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

        public RightLaneCar()
        {
            Point[] rightLane = { new Point(934, 646), new Point(202, 646), new Point(132, 636), new Point(82, 609), new Point(62, 574), new Point(62, 521),
                             new Point(62, 468), new Point(91, 426), new Point(134, 403), new Point(197, 397), new Point(265, 395), new Point(683, 383),
                             new Point(716, 343), new Point(726, 291), new Point(715, 259), new Point(679, 241), new Point(608, 234), new Point(0, 234)};

            Path = rightLane;

            CurrentPosition = Path[0];
            Index = 1;
            NextPosition = Path[Index];

        }

        public void MoveCarsOnRightLane()
        {
            int x = CurrentPosition.X - NextPosition.X;
            int y = CurrentPosition.Y - NextPosition.Y;

            if (x < 0)
                CurrentPosition = new Point(CurrentPosition.X + 1, CurrentPosition.Y);
            if (x > 0)
                CurrentPosition = new Point(CurrentPosition.X - 1, CurrentPosition.Y);
            if (y < 0)
                CurrentPosition = new Point(CurrentPosition.X, CurrentPosition.Y + 1);
            if (y > 0)
                CurrentPosition = new Point(CurrentPosition.X, CurrentPosition.Y - 1);
            if (CurrentPosition == NextPosition)
                Index++;
            if (Index < Path.Length)
                NextPosition = Path[Index];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemyOperacyjneProjekt
{
    class Train
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

        public Train()
        {
            Point[] railwayTracks = { new Point(0, 310), new Point(909, 310) };

            Path = railwayTracks;
            

            CurrentPosition = Path[0];
            Index = 1;
            NextPosition = Path[Index];

        }

        public void MoveTrain()
        {

            CurrentPosition = new Point(CurrentPosition.X + 1, CurrentPosition.Y);
            if (CurrentPosition == NextPosition)
                Index++;
            if (Index < Path.Length)
                NextPosition = Path[Index];
        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemyOperacyjneProjekt
{
    public partial class Form1 : Form
    {
        //Point border = new Point(1000, 313);
        Train train = new Train();
        LeftLaneCar blueCar = new LeftLaneCar();
        RightLaneCar blackCar = new RightLaneCar();

        public Form1()
        {
            InitializeComponent();
        }

        Thread TTrain;
        Thread TBlueCar;
        Thread TBlackCar;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            TTrain = new Thread(new ThreadStart(TrainMovement));
            TBlueCar = new Thread(new ThreadStart(LeftCarMove));
            TBlackCar = new Thread(new ThreadStart(RightCarMove));
            TTrain.Start();
            TBlueCar.Start();
            TBlackCar.Start();
        }

        private void TrainMovement()
        {
            trainBox.Location = train.CurrentPosition;

            Random r = new Random();
            while (true)
            {
                train.MoveTrain();
                Thread.Sleep(1);
                trainBox.Location = train.CurrentPosition;
                trainBox.Update();

                //if (trainBox.Location == border )
                //{
                //    trainBox.Location = new Point(-50, 313);
                //    Thread.Sleep(r.Next(500, 8000));

                //}

            }

        }

        private void LeftCarMove()
        {
            blueCarBox.Location = blueCar.CurrentPosition;

            Random r = new Random();
            while (true)
            {
                blueCar.MoveCarOnLeftLane();
                Thread.Sleep(1);
                blueCarBox.Location = blueCar.CurrentPosition;
                blueCarBox.Update();

            }

        }
        private void RightCarMove()
        {
            blackCarBox.Location = blackCar.CurrentPosition;

            Random r = new Random();
            while (true)
            {
                blackCar.MoveCarsOnRightLane();
                Thread.Sleep(1);
                blackCarBox.Location = blackCar.CurrentPosition;
                blackCarBox.Update();
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TTrain.Abort();
            TBlueCar.Abort();
            TBlackCar.Abort();
        }
    }
}

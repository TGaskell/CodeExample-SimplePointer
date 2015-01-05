using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePointer
{
    //sets the lblPointer to wingdings arrow
    public enum Direction
    {
        North = 217,
        West = 215,
        South = 218,
        East = 216
    }

    class MovePointer
    {
        public Direction direction;

        // Default constructor
        public MovePointer() 
        {
            location = new Point();
            direction = Direction.North;
        }

        public Point location { get; set; }

        //Function to move the lblPointer
        public void Move(int unitToMove)
        {
            Point P = new Point();
            switch (direction)
            {
                case Direction.North:
                    P.X = location.X;
                    P.Y = location.Y - unitToMove;
                    break;
                case Direction.West:
                    P.X = location.X - unitToMove;
                    P.Y = location.Y;
                    break;
                case Direction.South:
                    P.X = location.X;
                    P.Y = location.Y + unitToMove;
                    break;
                case Direction.East:
                    P.X = location.X + unitToMove;
                    P.Y = location.Y;
                    break;
                default:
                    break;
            }

            location = P;
        }

        //Function to draw the panel & set locations
        public void Draw(Panel P)
        {
            Point L = new Point(location.X + 100, location.Y + 100);
            P.Controls[0].Location = L;
        }

        //Function to change char to string for lblPointer
        public override string ToString()
        {
            return ((char)direction).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimplePointer
{
    public partial class frmSimplePointer : Form
    {
        private MovePointer pointer = new MovePointer();

        public frmSimplePointer()
        {
            InitializeComponent();
        }
        //when form loads set the lblPointer and lblCoords
        private void frmSimplePointer_Load(object sender, EventArgs e)
        {
            lblPointer.Text = pointer.ToString();
            pointer.Draw(pnlPosition);
            lblCoords.Text = pointer.location.ToString();
        }
        //on click command to direct the lblPointer North, South, East, West
        private void btnNorth_Click(object sender, EventArgs e)
        {
            pointer.direction = Direction.North;
            lblPointer.Text = pointer.ToString();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            pointer.direction = Direction.South;
            lblPointer.Text = pointer.ToString();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            pointer.direction = Direction.East;
            lblPointer.Text = pointer.ToString();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            pointer.direction = Direction.West;
            lblPointer.Text = pointer.ToString();
        }
        //on click command to move the lblPointer 1 unit
        private void btnGoOne_Click(object sender, EventArgs e)
        {
            pointer.Move(1);
            pointer.Draw(pnlPosition);
            lblCoords.Text = pointer.location.ToString();
        }
        //on click command to move the lblPointer 10 units
        private void btnGoTen_Click(object sender, EventArgs e)
        {
            pointer.Move(10);
            pointer.Draw(pnlPosition);
            lblCoords.Text = pointer.location.ToString();
        }
        //on click command to close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

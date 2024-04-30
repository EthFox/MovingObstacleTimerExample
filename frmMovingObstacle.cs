using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingObstacleTimerExample
{
	public partial class frmMovingObstacle : Form
	{
		public frmMovingObstacle()
		{
			InitializeComponent();
		}

		Point obstacleLoc;
		bool obstacleDirection; // false = right, true = left

		private void frmMovingObstacle_Load(object sender, EventArgs e)
		{
			obstacleLoc = movingObstacle.Location;
		}

		private void ObstacleTimer_Tick(object sender, EventArgs e) // interval property is set to 100, which means 10 times per second
		{                                                                                      //   ^ in milliseconds
			// Oscillates obstacle between x = 100 and 300
			if (obstacleDirection == false) // if moving right...
			{
				obstacleLoc.Offset(new Point(10, 0)); // ...move 10 pixels to the right
			}
			else // if moving left...
			{
				obstacleLoc.Offset(new Point(-10, 0)); // ...move 10 pixels to the left
			}

			movingObstacle.Location = obstacleLoc;

			if (obstacleLoc.X == 300) // once the obstacle reaches x = 300...
			{
				obstacleDirection = true; // ...start moving left
			}
			else if (obstacleLoc.X == 100) // once the obstacle gets back to x = 100...
			{
				obstacleDirection = false; // ...start moving right again
			}
		}
	}
}

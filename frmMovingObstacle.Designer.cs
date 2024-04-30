namespace MovingObstacleTimerExample
{
	partial class frmMovingObstacle
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.movingObstacle = new System.Windows.Forms.PictureBox();
			this.ObstacleTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.movingObstacle)).BeginInit();
			this.SuspendLayout();
			// 
			// movingObstacle
			// 
			this.movingObstacle.BackColor = System.Drawing.Color.Red;
			this.movingObstacle.Location = new System.Drawing.Point(100, 234);
			this.movingObstacle.Name = "movingObstacle";
			this.movingObstacle.Size = new System.Drawing.Size(25, 25);
			this.movingObstacle.TabIndex = 0;
			this.movingObstacle.TabStop = false;
			// 
			// ObstacleTimer
			// 
			this.ObstacleTimer.Enabled = true;
			this.ObstacleTimer.Tick += new System.EventHandler(this.ObstacleTimer_Tick);
			// 
			// frmMovingObstacle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 382);
			this.Controls.Add(this.movingObstacle);
			this.Name = "frmMovingObstacle";
			this.Text = "Moving Obstacle Example";
			this.Load += new System.EventHandler(this.frmMovingObstacle_Load);
			((System.ComponentModel.ISupportInitialize)(this.movingObstacle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox movingObstacle;
		private System.Windows.Forms.Timer ObstacleTimer;
	}
}


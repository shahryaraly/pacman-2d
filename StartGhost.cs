using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;


namespace PacManGame
{
	public class StartGhost
	{
		public bool left , right, up,down;
		public GetFormReady gfr = null;
		public Form form = null;
		public Label ghost;
		//public Thread ghostThread;
		public Timer timer_ghost = null;
		
		public StartGhost()
		{}
		
		public StartGhost(GetFormReady gfr, Form form,int ghostNum)
		{
		
			timer_ghost = new Timer();

			
			this.gfr = gfr;
			this.form = form;
			
			if(ghostNum == 1)
			{
				timer_ghost.Interval =10;
				this.ghost =  gfr.RedGhost;
				left =true;
			}
			else if(ghostNum == 2)
			{
				timer_ghost.Interval =20;
				this.ghost = gfr.BlueGhost;
				right = true;
			}
			else if(ghostNum == 3)
			{
				timer_ghost.Interval =30;
				this.ghost = gfr.YellowGhost;
				left = true;
			}
			else
			{
				timer_ghost.Interval =40;
				this.ghost = gfr.PinkGhost;
				right = true;
			}
			
			//ghostThread  = new Thread(startGhost);
			//ghostThread.Start();
			
			timer_ghost.Tick +=  new EventHandler(ghostStarted);
			timer_ghost.Enabled = true;
			
		}
		
		public void ghostStarted(object ob, EventArgs e)
		{
			startGhost();
		}
		
		public void startGhost()
		{
			//while(true)
			{
				if(left)
				{
					ghost.Location = new Point(ghost.Location.X-4,ghost.Location.Y);
	
				}
				if(right)
				{
					ghost.Location = new Point(ghost.Location.X+4,ghost.Location.Y);
				}
				if(up)
				{
					ghost.Location = new Point(ghost.Location.X,ghost.Location.Y-4);	
				}
				if(down)
				{
					ghost.Location = new Point(ghost.Location.X,ghost.Location.Y+4);
				}
				//Thread.Sleep(15);
			}
		}
		
		
	}
}
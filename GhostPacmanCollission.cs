using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;
using System;


namespace PacManGame
{	
	public class GhostPacmanCollission
	{
		public GetFormReady gfr = null;
		public Form form = null;
		public StartGhost sg =null;
		public Timer timer_checkCollission= null;
		public static int count =0;
		
		public GhostPacmanCollission()
		{}
		
		public GhostPacmanCollission(GetFormReady gfr,StartGhost sg,Form form)
		{
			this.gfr =  gfr;
			this.sg = sg;
			this.form = form;
		
			timer_checkCollission = new Timer();
			timer_checkCollission.Interval =1;
			timer_checkCollission.Tick += new EventHandler(startChecking);
			timer_checkCollission.Enabled = true;
			
			
		}
		
		public void startChecking(object ob,EventArgs e)
		{
			check();
		}
		
		
		
		public void check()
		{
		
			if(count == 0)
			{
				if(( ((gfr.pacmanHero.Location.Y > sg.ghost.Location.Y)&&(gfr.pacmanHero.Location.Y < sg.ghost.Location.Y+30  )) || ((sg.ghost.Location.Y > gfr.pacmanHero.Location.Y)&&(sg.ghost.Location.Y < gfr.pacmanHero.Location.Y+30)) || (gfr.pacmanHero.Location.Y == sg.ghost.Location.Y) )  && (( (gfr.pacmanHero.Location.X < sg.ghost.Location.X+30)&&(gfr.pacmanHero.Location.X > sg.ghost.Location.X) ) || ( (gfr.pacmanHero.Location.X > sg.ghost.Location.X-30)&&(gfr.pacmanHero.Location.X < sg.ghost.Location.X)   )) )
				{
					count++;
				}
				if(( ((gfr.pacmanHero.Location.X > sg.ghost.Location.X)&&(gfr.pacmanHero.Location.X < sg.ghost.Location.X+30)) || ((sg.ghost.Location.X > gfr.pacmanHero.Location.X)&&(sg.ghost.Location.X < gfr.pacmanHero.Location.X+30 )) || (gfr.pacmanHero.Location.X == sg.ghost.Location.X) )  &&  (( (gfr.pacmanHero.Location.Y < sg.ghost.Location.Y+30)&&(gfr.pacmanHero.Location.Y > sg.ghost.Location.Y)) || ((gfr.pacmanHero.Location.Y > sg.ghost.Location.Y-30)&&(gfr.pacmanHero.Location.Y < sg.ghost.Location.Y))) )
				{
					count++;
				}

			}

			
		}
		
	}
	
}
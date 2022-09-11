using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;
using System;
using System.Media;


namespace PacManGame
{
		public class AfterCollission 
		{
			public GetFormReady gfr = null;
			public StartHero sh = null;
			public StartGhost sg1 = null;
			public StartGhost sg2 = null;
			public StartGhost sg3 = null;
			public StartGhost sg4 = null;
			public Form form = null;
			public Timer timer_afterCollission = null;
			public Image die = null;
			public Image alive = null;
			public int lifes = 3;
			public SoundPlayer diesound = null;	
			public int win =0;				
		
			public AfterCollission()
			{}
			
			public AfterCollission(GetFormReady gfr,StartHero sh,StartGhost sg1,StartGhost sg2, StartGhost sg3, StartGhost sg4, Form form)
			{
				this.gfr = gfr;
				this.sh = sh;
				this.sg1 = sg1;
				this.sg2 = sg2;
				this.sg3 = sg3;
				this.sg4 = sg4;
				this.form = form;

				
				timer_afterCollission = new Timer();
				timer_afterCollission.Interval = 1;
				timer_afterCollission.Tick += new EventHandler(detector);
				timer_afterCollission.Enabled = true;
				
				die = Image.FromFile("pacmanDies.gif");
				alive = Image.FromFile("PacmanLeft.gif");
				diesound = new SoundPlayer("pacman_death.wav");
			}
			
			public void detector(object ob, EventArgs e)
			{
				startDetecting();
			}
			public int trick =0;
			
			public void startDetecting()
			{	
				if(win == 1)
				{
					MessageBox.Show("You Won\nPlay Again ...!!!\n\nSee You Soon :)");
					form.Close();
				}
			
				if(TeachPacmanHowToEat.score/100 == 80)
				{
					gfr.timer_startHero.Enabled = false;
					gfr.timer_pacmanRun.Enabled = false;
					gfr.timer_pacmanEat.Enabled = false;
					sh.check = !sh.check;
					sg1.timer_ghost.Enabled = false;
					sg2.timer_ghost.Enabled = false;
					sg3.timer_ghost.Enabled = false;
					sg4.timer_ghost.Enabled = false;
				
					

					gfr.BlueGhost.Visible = false;
					gfr.PinkGhost.Visible = false;
					gfr.RedGhost.Visible = false;
					gfr.YellowGhost.Visible = false;
					
					timer_afterCollission.Interval = 5000;
					gfr.msg.Text = "You Won";
					gfr.msg.Visible = true;
					win = 1;

				}
			
				if(lifes == 0)
				{
					
					MessageBox.Show("Sorry You Missed All 3 Chances\nGame Over Play Again ...!!!\n\nBetterLuck Next Time :)");
					form.Close();
				}
			
				if(trick == 1)
				{
					gfr.chompsound.PlayLooping();
					gfr.timer_startHero.Enabled = true;
					gfr.timer_pacmanRun.Enabled = true;
					gfr.timer_pacmanEat.Enabled = true;
					sh.check = !sh.check;

					
					gfr.pacmanHero.Image = alive;
					gfr.PinkGhost.Visible = true;
					gfr.BlueGhost.Visible = true;
					gfr.RedGhost.Visible = true;
					gfr.YellowGhost.Visible = true;
					
					gfr.RedGhost.Location = new Point(300,50);
					gfr.BlueGhost.Location = new Point(350,50);
					gfr.YellowGhost.Location = new Point(400,50);
					gfr.PinkGhost.Location = new Point(450,50);
					gfr.pacmanHero.Location =  new Point(350,240);
					
					sg1.timer_ghost.Enabled = true;
					sg2.timer_ghost.Enabled = true;
					sg3.timer_ghost.Enabled = true;
					sg4.timer_ghost.Enabled = true;
					
					sg1.left = true;
					sg1.right = false;
					sg1.up = false;
					sg1.down = false;
					
					sg2.left = false;
					sg2.right = true;
					sg2.up = false;
					sg2.down = false;
					
					sg3.left = true;
					sg3.right = false;
					sg3.up = false;
					sg3.down = false;
					
					sg4.left = false;
					sg4.right = true;
					sg4.up = false;
					sg4.down = false;
					
					sh.left = true;
					sh.right = false;
					sh.up = false;
					sh.down = false;					
					
					
					timer_afterCollission.Interval = 1;
					trick = 0;
					GhostPacmanCollission.count =0;
					
				}
			
			
				if(GhostPacmanCollission.count > 0)
				{
					gfr.timer_startHero.Enabled = false;
					gfr.timer_pacmanRun.Enabled = false;
					gfr.timer_pacmanEat.Enabled = false;
					sh.check = !sh.check;
					sg1.timer_ghost.Enabled = false;
					sg2.timer_ghost.Enabled = false;
					sg3.timer_ghost.Enabled = false;
					sg4.timer_ghost.Enabled = false;
				
					
					gfr.pacmanHero.Image = die;
					gfr.BlueGhost.Visible = false;
					gfr.PinkGhost.Visible = false;
					gfr.RedGhost.Visible = false;
					gfr.YellowGhost.Visible = false;
					

					
					timer_afterCollission.Interval = 2000;
					trick = 1;
					lifes = lifes-1;
					if(lifes == 2)gfr.life2.Visible = false;
					if(lifes == 1)gfr.life1.Visible = false;
					if(lifes == 0)
					{ 
						timer_afterCollission.Interval = 5000;
						gfr.msg.Text = "Game Over";
						gfr.msg.Visible = true;
					}
					//for(int i =0; i<3; i++)
					//{
						diesound.Play();
					//}

				}
				
				
				
				
				
				
			}
		}
}
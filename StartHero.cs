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
	public class StartHero 
	{
		public GetFormReady gfr=null;
		public Form form=null;
		public bool up,left=true,down,right;
		public bool check = true;
		public Timer tmr_checkHero = null;
		//public Thread heroThread = null;
		public bool upcheck , leftcheck=true , downcheck, rightcheck;
		public StartHero()
		{
		}
		
		public StartHero(GetFormReady gfr,Form form)
		{
			this.form = form;
			this.gfr = gfr;
			form.KeyDown += new KeyEventHandler(keydown);

			 tmr_checkHero = new Timer();
			

			
			
			gfr.timer_startHero.Tick += new EventHandler(startHeroTimer);
			gfr.timer_startHero.Enabled = true;
			
			
			
			tmr_checkHero.Interval = 1;
			tmr_checkHero.Tick += new EventHandler(timer_checkHero);
			tmr_checkHero.Enabled = true;

			//heroThread = new Thread(startHero);
			//heroThread.Start();

		}
		
		public void startHeroTimer(object ob , EventArgs e)
		{
			startHero();
		}
		
		
		
		public void timer_checkHero(object ob , EventArgs even)
		{
			if(leftcheck == true)
			{
					//1                                                                                                                                                   2                                                                                                                                      3                                                                                                                                      4                                                                                                                                            5                                                                                                                                            6                                                                                                                                         7                                                                                                                                                                                                                                                                         2                                                                                                                                             3                                                                                                                              4                                                                                                                                                        5                                                                                                                             6                                                                                                                                               7                                                                                                                                      8                                                                                                                                   9                                                                                                                                     10                                                                                                                                    11                                                                                                                             12                                                                                                                                                                                                                                                                              
  				if( ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X < 750)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<60)) || ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X<750)&&(gfr.pacmanHero.Location.Y>475 && gfr.pacmanHero.Location.Y<485)) ||   ((gfr.pacmanHero.Location.X>319 && gfr.pacmanHero.Location.X<430)&&(gfr.pacmanHero.Location.Y>234 && gfr.pacmanHero.Location.Y<250)) ||   ((gfr.pacmanHero.Location.X>403 && gfr.pacmanHero.Location.X<610)&&(gfr.pacmanHero.Location.Y>150 && gfr.pacmanHero.Location.Y<160)) ||   ((gfr.pacmanHero.Location.X>402 && gfr.pacmanHero.Location.X<595)&&(gfr.pacmanHero.Location.Y>=372 && gfr.pacmanHero.Location.Y<=380)) ||   ((gfr.pacmanHero.Location.X>138 && gfr.pacmanHero.Location.X<334)&&(gfr.pacmanHero.Location.Y>148 && gfr.pacmanHero.Location.Y<156)) ||  ((gfr.pacmanHero.Location.X>138 && gfr.pacmanHero.Location.X<334)&&(gfr.pacmanHero.Location.Y>370 && gfr.pacmanHero.Location.Y<380)) )
				{
					changeImageLeft();
					up= false;
					down=false;
					left =true;
					right= false;
					
					leftcheck = false;
					upcheck = false;
					rightcheck = false;
					downcheck = false;
				}
			}
			
			
			
			
			if(rightcheck == true)
			{		
					//1                                                                                                                                                   2                                                                                                                                      3                                                                                                                                      4                                                                                                                                            5                                                                                                                                            6                                                                                                                                         7                                                                                                                         
				if( ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X<750)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<60)) || ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X<750)&&(gfr.pacmanHero.Location.Y>475 && gfr.pacmanHero.Location.Y<485)) ||  ((gfr.pacmanHero.Location.X>319 && gfr.pacmanHero.Location.X<430)&&(gfr.pacmanHero.Location.Y>234 && gfr.pacmanHero.Location.Y<250)) ||  ((gfr.pacmanHero.Location.X>403 && gfr.pacmanHero.Location.X<610)&&(gfr.pacmanHero.Location.Y>150 && gfr.pacmanHero.Location.Y<160)) ||  ((gfr.pacmanHero.Location.X>402 && gfr.pacmanHero.Location.X<595)&&(gfr.pacmanHero.Location.Y>372 && gfr.pacmanHero.Location.Y<380)) ||  ((gfr.pacmanHero.Location.X>138 && gfr.pacmanHero.Location.X<334)&&(gfr.pacmanHero.Location.Y>148 && gfr.pacmanHero.Location.Y<156)) ||  ((gfr.pacmanHero.Location.X>138 && gfr.pacmanHero.Location.X<334)&&(gfr.pacmanHero.Location.Y>370 && gfr.pacmanHero.Location.Y<380)) )
				{
					changeImageRight();
					up= false;
					down=false;
					left =false;
					right= true;
					
					leftcheck = false;
					upcheck = false;
					rightcheck = false;
					downcheck = false;
				}
			}
			
			if(downcheck == true)
			{
				if( ((gfr.pacmanHero.Location.X>27 && gfr.pacmanHero.Location.X<40)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<468)) ||  ((gfr.pacmanHero.Location.X>144 && gfr.pacmanHero.Location.X<152)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<468)) ||  ((gfr.pacmanHero.Location.X>322 && gfr.pacmanHero.Location.X<330)&&(gfr.pacmanHero.Location.Y>149 && gfr.pacmanHero.Location.Y<366 )) ||  ((gfr.pacmanHero.Location.X>406 && gfr.pacmanHero.Location.X<413)&&(gfr.pacmanHero.Location.Y>149 && gfr.pacmanHero.Location.Y <366)) ||  ((gfr.pacmanHero.Location.X>580 && gfr.pacmanHero.Location.X<595)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<468)) ||  ((gfr.pacmanHero.Location.X>686 && gfr.pacmanHero.Location.X<704)&&(gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<468 )) )
				{
					changeImageDown();
					up= false;
					down=true;
					left =false;
					right= false;
					
					leftcheck = false;
					upcheck = false;
					rightcheck = false;
					downcheck = false;
				}
			}
			
			
			if(upcheck == true)
			{
				if( ((gfr.pacmanHero.Location.X>27 && gfr.pacmanHero.Location.X<40)&&(gfr.pacmanHero.Location.Y>50 && gfr.pacmanHero.Location.Y<488)) ||  ((gfr.pacmanHero.Location.X>144 && gfr.pacmanHero.Location.X<152)&&(gfr.pacmanHero.Location.Y>50 && gfr.pacmanHero.Location.Y<488)) ||  ((gfr.pacmanHero.Location.X>580 && gfr.pacmanHero.Location.X<595)&&(gfr.pacmanHero.Location.Y>50 && gfr.pacmanHero.Location.Y<488)) ||  ((gfr.pacmanHero.Location.X>686 && gfr.pacmanHero.Location.X<706)&&(gfr.pacmanHero.Location.Y>50 && gfr.pacmanHero.Location.Y<488)) ||  ((gfr.pacmanHero.Location.X>322 && gfr.pacmanHero.Location.X<330)&&(gfr.pacmanHero.Location.Y>152 && gfr.pacmanHero.Location.Y<392)) ||  ((gfr.pacmanHero.Location.X>406 && gfr.pacmanHero.Location.X<413)&&(gfr.pacmanHero.Location.Y>152 && gfr.pacmanHero.Location.Y<392))  )
				{                                                                                                                                                                                                                                                                        // gfr.pacmanHero.Location.X>580 && gfr.pacmanHero.Location.X<595                                                                                              
					changeImageUp();
					up= true;
					down=false;
					left =false;
					right= false;
					
					leftcheck = false;
					upcheck = false;
					rightcheck = false;
					downcheck = false;
					
				}
			}
			
			
			
		}
		
		//public static KeyEventArgs e = null;
		
		public void keydown(object o, KeyEventArgs e)
		{
		if(check)
		{
			if(e.KeyCode == Keys.Up)
			{
				upcheck = true;
			}
			
			if(e.KeyCode == Keys.Down)
			{	
				downcheck = true;
			}
			
			if(e.KeyCode == Keys.Right)
			{	
				rightcheck = true;
			}
			
			if(e.KeyCode == Keys.Left)
			{	
				leftcheck = true;
			}
		}			
		}
		// (()&&()) || 
		public void changeImageLeft()
		{
			Image img = Image.FromFile("pacmanLeft.gif");
			gfr.pacmanHero.Image =img;
		}
		
		public void changeImageRight()
		{
			Image img = Image.FromFile("pacmanRight.gif");
			gfr.pacmanHero.Image =img;
		}

		public void changeImageUp()
		{
			Image img = Image.FromFile("pacmanUp.gif");			
			gfr.pacmanHero.Image =img;
		}
		
		public void changeImageDown()
		{
			Image img = Image.FromFile("pacmanDown.gif");
			gfr.pacmanHero.Image =img;	
		}
		
		public void startHero()
		{
			//while(true)
			{
				if(left)
				{
					gfr.pacmanHero.Location = new Point(gfr.pacmanHero.Location.X-2,gfr.pacmanHero.Location.Y);
	
				}
				if(right)
				{
					gfr.pacmanHero.Location = new Point(gfr.pacmanHero.Location.X+2,gfr.pacmanHero.Location.Y);
				}
				if(up)
				{
					gfr.pacmanHero.Location = new Point(gfr.pacmanHero.Location.X,gfr.pacmanHero.Location.Y-2);	
				}
				if(down)
				{
					gfr.pacmanHero.Location = new Point(gfr.pacmanHero.Location.X,gfr.pacmanHero.Location.Y+2);
				}
				
				//form.Text = "PH : "+gfr.pacmanHero.Height+" PW : "+gfr.pacmanHero.Width+"   DH : "+gfr.lbl[1].Height+" DW : "+gfr.lbl[1].Width;
				//form.Text = "X : "+gfr.pacmanHero.Location.X+" Y: "+gfr.pacmanHero.Location.Y;
				//Thread.Sleep(10);
			}
		}
	}
}
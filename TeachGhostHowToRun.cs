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
	public class TeachGhostHowToRun
	{
		public GetFormReady gfr = null;
		public Form form = null;
		public StartGhost sg = null;
		//public Thread checkGhostThread = null;
		public Random  rand = null;
		public Timer timer_checkGhost = null;
		public int count=0;
		
		public TeachGhostHowToRun()
		{
		}
		
		public TeachGhostHowToRun(GetFormReady gfr ,StartGhost sg, Form form)
		{
			this.gfr = gfr;
			this.sg = sg;
			this.form = form;
			rand = new Random();
			sg.ghost.Location = new Point(sg.ghost.Location.X,48);
			//checkGhostThread = new Thread(checkGhost);
			//checkGhostThread.Start();
			timer_checkGhost = new Timer();
			timer_checkGhost.Interval = 1;
			timer_checkGhost.Enabled = true;
			timer_checkGhost.Tick += new EventHandler(CheckStarted);
		}
		
		public void CheckStarted(object ob, EventArgs e)
		{
			checkGhost();
		}
		
		public void checkGhost()
		{
			//while(true)
			{
				//Number 1 
				if((sg.ghost.Location.X > 690 && sg.ghost.Location.X<705)&&(sg.ghost.Location.Y > 38 && sg.ghost.Location.Y<60))
				{	
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveLeft();
						if(count == 0)
						count++;
					}
					else
					{
						moveDown();
						if(count == 0)
						count++;
					}
				}
				
				//Number 2
				if((sg.ghost.Location.X > 581 && sg.ghost.Location.X<590)&&(sg.ghost.Location.Y > 38 && sg.ghost.Location.Y<60))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveRight();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
				}
			
				//Number 3
				if((sg.ghost.Location.X > 142 && sg.ghost.Location.X<152)&&(sg.ghost.Location.Y > 38 && sg.ghost.Location.Y<60))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveRight();
						if(count == 0 )
						count++;
					}
					if(p==2)
					{
						moveLeft();
						if(count == 0 )
						count++;
					}
					if(p==3)
					{
						moveDown();
						if(count == 0 )
						count++;
					}
				}
				
				//Number 4
				if((sg.ghost.Location.X > 32 && sg.ghost.Location.X<46)&&(sg.ghost.Location.Y > 40 && sg.ghost.Location.Y<60))
				{
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveRight();
						if(count == 0)
						count++;
						
					}
					else
					{
						moveDown();
						if(count == 0)
						count++;
					}
				}
				
				
				//Number 5
				if((sg.ghost.Location.X > 32 && sg.ghost.Location.X<46)&&(sg.ghost.Location.Y > 470 && sg.ghost.Location.Y<480))
				{
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveRight();
						if(count == 0)
						count++;
					}
					else
					{
						moveUp();
						if(count ==0)
						count++;
					}
				}
				
				//Number 6
				if((sg.ghost.Location.X > 140 && sg.ghost.Location.X<155)&&(sg.ghost.Location.Y > 470 && sg.ghost.Location.Y<480))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveRight();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						if(count==0)
						count++;
					}
					if(p==3)
					{
						moveUp();
						if(count== 0)
						count++;
					}
				}
				
				
				//Number 7
				if((sg.ghost.Location.X > 580 && sg.ghost.Location.X<589)&&(sg.ghost.Location.Y > 470 && sg.ghost.Location.Y<480))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveRight();
						if(count==0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						if(count ==0)
						count++;
					}
					if(p==3)
					{
						moveUp();
						if(count ==0)
						count++;	
					}
				}
				
				//Number 8
				if((sg.ghost.Location.X > 690 && sg.ghost.Location.X<702)&&(sg.ghost.Location.Y > 470 && sg.ghost.Location.Y<480))
				{
				
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveUp();
						if(count ==0)
						count++;
					}
					else
					{
						moveLeft();
						if(count == 0)
							count++;
					}
				}
				
				//Number 9
				if((sg.ghost.Location.X > 578 && sg.ghost.Location.X<594)&&(sg.ghost.Location.Y > 370 && sg.ghost.Location.Y<380))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
				}
				
				//Number 10
				if((sg.ghost.Location.X > 400 && sg.ghost.Location.X<417)&&(sg.ghost.Location.Y > 368 && sg.ghost.Location.Y<380))
				{
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					else
					{
						moveRight();
						
						if(count == 0)
						count++;
					}
		
				}
				
				//Number 11
				if((sg.ghost.Location.X > 578 && sg.ghost.Location.X<594)&&(sg.ghost.Location.Y > 148 && sg.ghost.Location.Y<160))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
		
				}
				//Number 12
				if((sg.ghost.Location.X > 400 && sg.ghost.Location.X<417)&&(sg.ghost.Location.Y > 140 && sg.ghost.Location.Y<170))
				{
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveDown();
						if(count == 0)
						count++;
					}
					else
					{
						moveRight();
						if(count == 0)
						count++;
					}	
				}
				//Number 13
				if((sg.ghost.Location.X > 406 && sg.ghost.Location.X<415)&&(sg.ghost.Location.Y > 232 && sg.ghost.Location.Y<242))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveLeft();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
		
				}
				
				//Number 14
				if((sg.ghost.Location.X > 320 && sg.ghost.Location.X<326)&&(sg.ghost.Location.Y > 232 && sg.ghost.Location.Y<242))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveRight();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
		
				}
				
				//Number 15
				if((sg.ghost.Location.X > 318 && sg.ghost.Location.X<328)&&(sg.ghost.Location.Y > 148 && sg.ghost.Location.Y<158))
				{
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveDown();
						if(count == 0)
						count++;
					}
					else
					{
						moveLeft();
						if(count == 0)
						count++;
					}
				}
				
				//Number 16
				if((sg.ghost.Location.X > 135 && sg.ghost.Location.X<154)&&(sg.ghost.Location.Y > 148 && sg.ghost.Location.Y<158))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveRight();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
		
				}
				
				//Number 17
				if((sg.ghost.Location.X > 135 && sg.ghost.Location.X<154)&&(sg.ghost.Location.Y > 372 && sg.ghost.Location.Y<382))
				{
					
					int p = rand.Next(1,4);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					if(p==2)
					{
						moveRight();
						
						if(count == 0)
						count++;
					}
					if(p==3)
					{
						moveDown();
						
						if(count == 0)
						count++;
					}
		
				}
				
				//Number 18
				if((sg.ghost.Location.X > 316 && sg.ghost.Location.X<330)&&(sg.ghost.Location.Y > 368 && sg.ghost.Location.Y<378))
				{
					
					int p = rand.Next(1,3);
					if(p == 1)
					{
						moveUp();
						if(count == 0)
						count++;
					}
					else
					{
						moveLeft();
						if(count == 0)
						count++;
					}
				}
				
				
				
				
				//Resetting Position Counter
				if(count >0)
				{
					//C1
					if((sg.ghost.Location.X > 96 && sg.ghost.Location.X < 102)&&(sg.ghost.Location.Y > 40 && sg.ghost.Location.Y <125))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,48);
						count =0;
					}
					//C2
					if((sg.ghost.Location.X > 348 && sg.ghost.Location.X < 355)&&(sg.ghost.Location.Y > 40 && sg.ghost.Location.Y <125))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,48);
						count =0;
					}
					//C3
					if((sg.ghost.Location.X > 648 && sg.ghost.Location.X < 655)&&(sg.ghost.Location.Y > 40 && sg.ghost.Location.Y <125))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,48);
						count =0;
					}
					//C4
					if((sg.ghost.Location.X > 96 && sg.ghost.Location.X < 105)&&(sg.ghost.Location.Y > 450 && sg.ghost.Location.Y <500))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,476);
						count =0;
					}
					//C5
					if((sg.ghost.Location.X > 348 && sg.ghost.Location.X < 355)&&(sg.ghost.Location.Y > 450 && sg.ghost.Location.Y <500))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,476);
						count =0;
					}
					//C6
					if((sg.ghost.Location.X > 648 && sg.ghost.Location.X < 655)&&(sg.ghost.Location.Y > 450 && sg.ghost.Location.Y <500))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,476);
						count =0;
					}
					//C7
					if((sg.ghost.Location.X > 30 && sg.ghost.Location.X < 52)&&(sg.ghost.Location.Y > 248 && sg.ghost.Location.Y <282))
					{
						sg.ghost.Location = new Point(36,sg.ghost.Location.Y);
						count =0;
					}
					//C8
					if((sg.ghost.Location.X > 660 && sg.ghost.Location.X < 750)&&(sg.ghost.Location.Y > 248 && sg.ghost.Location.Y <282))
					{
						sg.ghost.Location = new Point(694,sg.ghost.Location.Y);
						count =0;
					}
					//C9
					if((sg.ghost.Location.X > 120 && sg.ghost.Location.X < 160)&&(sg.ghost.Location.Y > 248 && sg.ghost.Location.Y <282))
					{
						sg.ghost.Location = new Point(144,sg.ghost.Location.Y);
						count =0;
					}
					//C10
					if((sg.ghost.Location.X > 560 && sg.ghost.Location.X < 598)&&(sg.ghost.Location.Y > 248 && sg.ghost.Location.Y <282))
					{
						sg.ghost.Location = new Point(586,sg.ghost.Location.Y);
						count =0;
					}
					//C11
					if((sg.ghost.Location.X > 120 && sg.ghost.Location.X < 170)&&(sg.ghost.Location.Y > 110 && sg.ghost.Location.Y <134))
					{
						sg.ghost.Location = new Point(144,sg.ghost.Location.Y);
						count =0;
					}
					//C12
					if((sg.ghost.Location.X > 560 && sg.ghost.Location.X < 600)&&(sg.ghost.Location.Y > 102 && sg.ghost.Location.Y <134))
					{
						sg.ghost.Location = new Point(586,sg.ghost.Location.Y);
						count =0;
					}
					//C13
					if((sg.ghost.Location.X > 120 && sg.ghost.Location.X < 170)&&(sg.ghost.Location.Y > 430 && sg.ghost.Location.Y <454))
					{
						sg.ghost.Location = new Point(144,sg.ghost.Location.Y);
						count =0;
					}
					//C14
					if((sg.ghost.Location.X > 560 && sg.ghost.Location.X < 600)&&(sg.ghost.Location.Y > 430 && sg.ghost.Location.Y <454))
					{
						sg.ghost.Location = new Point(586,sg.ghost.Location.Y);
						count =0;
					}
					//C15
					if((sg.ghost.Location.X > 226 && sg.ghost.Location.X < 266)&&(sg.ghost.Location.Y > 125 && sg.ghost.Location.Y <180))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,152);
						count =0;
					}
					//C16
					if((sg.ghost.Location.X > 494 && sg.ghost.Location.X < 536)&&(sg.ghost.Location.Y > 125 && sg.ghost.Location.Y <180))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,152);
						count =0;
					}
					//C17
					if((sg.ghost.Location.X > 228 && sg.ghost.Location.X < 268)&&(sg.ghost.Location.Y > 340 && sg.ghost.Location.Y <430))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,376);
						count =0;
					}
					//C18
					if((sg.ghost.Location.X > 496 && sg.ghost.Location.X < 536)&&(sg.ghost.Location.Y > 340 && sg.ghost.Location.Y <430))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,376);
						count =0;
					}
					//C19
					if((sg.ghost.Location.X > 250 && sg.ghost.Location.X < 350)&&(sg.ghost.Location.Y > 206 && sg.ghost.Location.Y <222))
					{
						sg.ghost.Location = new Point(322,sg.ghost.Location.Y);
						count =0;
					}
					//C20
					if((sg.ghost.Location.X > 370 && sg.ghost.Location.X < 500)&&(sg.ghost.Location.Y > 206 && sg.ghost.Location.Y <222))
					{
						sg.ghost.Location = new Point(408,sg.ghost.Location.Y);
						count =0;
					}
					//C21
					if((sg.ghost.Location.X >250 && sg.ghost.Location.X < 350)&&(sg.ghost.Location.Y > 306 && sg.ghost.Location.Y <336))
					{
						sg.ghost.Location = new Point(322,sg.ghost.Location.Y);
						count =0;
					}
					//C22
					if((sg.ghost.Location.X > 350 && sg.ghost.Location.X < 426)&&(sg.ghost.Location.Y > 306 && sg.ghost.Location.Y <336))
					{
						sg.ghost.Location = new Point(408,sg.ghost.Location.Y);
						count =0;
					}
					//C23
					if((sg.ghost.Location.X > 370 && sg.ghost.Location.X < 396)&&(sg.ghost.Location.Y > 200 && sg.ghost.Location.Y <300))
					{
						sg.ghost.Location = new Point(sg.ghost.Location.X,238);
						count =0;
					}
					
				}
				
				
				
				//form.Text = "X : "+sg.ghost.Location.X+" Y: "+sg.ghost.Location.Y;

			}
		}
		
		public void moveRight()
		{
			sg.right =true;
			sg.up = false;
			sg.down = false;
			sg.left = false;
		}
		
		public void moveLeft()
		{
			sg.right = false;
			sg.up = false;
			sg.down = false;
			sg.left= true;
		}
		
		public void moveDown()
		{
			sg.up = false;
			sg.left = false;
			sg.right = false;
			sg.down = true;
		}
		
		public void moveUp()
		{
			sg.down =  false;
			sg.left = false;
			sg.right = false;
			sg.up =true;
		}
		
		
	}
}
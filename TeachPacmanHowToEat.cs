using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;
using System.Media;

namespace PacManGame
{
	public class TeachPacmanHowToEat
	{
		
		public GetFormReady  gfr = null;
		public StartHero sh = null;
		public Form form = null;
		public static int score = 0 ;
		//public Thread eatingThread = null;
		public SoundPlayer eatsound = null;
		
		public TeachPacmanHowToEat()
		{	}
		
		public TeachPacmanHowToEat(GetFormReady gfr,StartHero sh, Form form)
		{
			this.gfr = gfr;
			this.sh = sh;
			this.form = form;
			
			//eatingThread =  new Thread(startEatingDots);
			//eatingThread.Start();
			gfr.timer_pacmanEat.Tick += new EventHandler(pacmanEating);
			gfr.timer_pacmanEat.Enabled = true;
			eatsound = new SoundPlayer("pacman_eatfruit.wav");
			
		}
		
		public void pacmanEating(object ob, EventArgs e)
		{
			startEatingDots();
		}
		
		public void afterCollission(Label lbl)
		{
			Label lblTest = lbl;
			
			if(lblTest.Visible)
			{
				lblTest.Hide();
				score = score+100;
				//gfr.chompsound.Stop();
				eatsound.Play();
				//gfr.chompsound.PlayLooping();
			}
		}
	
		public void startEatingDots()
		{
			gfr.score.Text = ""+score;
			//while(true)
			{
				//Checking For Left Position Of PacMan
				if(sh.left)
				{
					// Wall up1 Dots Checking Left
					if((gfr.pacmanHero.Location.X > 30 && gfr.pacmanHero.Location.X < 730  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 60 ))
					{
						for(int i =0;  i<=13;  i++)
						{
							if( (gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X+20) &&(gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 60) )
							{
								if(gfr.lbl[i].Visible)
								{
								
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//wall up2 Dots Checking Left
					if((gfr.pacmanHero.Location.X > 138 && gfr.pacmanHero.Location.X < 630 )&&( gfr.pacmanHero.Location.Y > 148 && gfr.pacmanHero.Location.Y < 160 ))
					{
						for(int i=28; i<=39; i++)
						{
							if( (gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X+20) &&(gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 148 && gfr.pacmanHero.Location.Y < 160) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					// wall Down1 Dots Eating Left
					if((gfr.pacmanHero.Location.X > 30 && gfr.pacmanHero.Location.X < 730  )&&( gfr.pacmanHero.Location.Y > 470 && gfr.pacmanHero.Location.Y < 500 ))
					{
						for(int i =14;  i<=27;  i++)
						{
							if( (gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X+20) &&(gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 470 && gfr.pacmanHero.Location.Y < 500) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
				
					//wall Down2 Dots Checking Left
					if((gfr.pacmanHero.Location.X > 138 && gfr.pacmanHero.Location.X < 630 )&&( gfr.pacmanHero.Location.Y > 368 && gfr.pacmanHero.Location.Y < 388 ))
					{
						for(int i=40; i<=51; i++)
						{
							if( (gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X+20) &&(gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 368 && gfr.pacmanHero.Location.Y < 388 ) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					
				}
			
				//Checking For Right Position Of PacMan
				if(sh.right)
				{
					//wall up1 Dots Checking Right
					if((gfr.pacmanHero.Location.X > 30 && gfr.pacmanHero.Location.X < 730  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 60 ))
					{
						for(int i = 0; i<=13; i++)
						{
							if( (gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X-20) &&(gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 60) )
							{
								if(gfr.lbl[i].Visible)
									{
									afterCollission(gfr.lbl[i]);

									}
							}
						}
					}
			
					//wall up2 Dots Checking Right
					if((gfr.pacmanHero.Location.X > 138 && gfr.pacmanHero.Location.X < 630 )&&( gfr.pacmanHero.Location.Y > 148 && gfr.pacmanHero.Location.Y < 160 ))
					{
						for(int i=28; i<=39; i++)
						{
							if( (gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X-20) &&(gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 148 && gfr.pacmanHero.Location.Y < 160) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					// wall Down1 Dots Eating Right
					if((gfr.pacmanHero.Location.X > 30 && gfr.pacmanHero.Location.X < 730  )&&( gfr.pacmanHero.Location.Y > 470 && gfr.pacmanHero.Location.Y < 500 ))
					{
						for(int i =14;  i<=27;  i++)
						{
							if( (gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X-20) &&(gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 470 && gfr.pacmanHero.Location.Y < 500) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
				
					//wall Down2 Dots Checking Right
					if((gfr.pacmanHero.Location.X > 138 && gfr.pacmanHero.Location.X < 630 )&&( gfr.pacmanHero.Location.Y > 368 && gfr.pacmanHero.Location.Y < 388 ))
					{
						for(int i=40; i<=51; i++)
						{
							if( (gfr.pacmanHero.Location.X > gfr.lbl[i].Location.X-20) &&(gfr.pacmanHero.Location.X < gfr.lbl[i].Location.X)&& ( gfr.pacmanHero.Location.Y > 368 && gfr.pacmanHero.Location.Y < 388 ) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
				}
				
				//Checking For Up Position Of PacMan
				if(sh.up)
				{
					//left Wall1 Checking Up
					if((gfr.pacmanHero.Location.X > 28 && gfr.pacmanHero.Location.X < 68  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =52;  i<=59;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 28 && gfr.pacmanHero.Location.X < 68) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//left Wall2 Checking Up
					if((gfr.pacmanHero.Location.X > 129 && gfr.pacmanHero.Location.X < 160  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =68;  i<=71;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 129 && gfr.pacmanHero.Location.X < 160) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//left Middle Wall3 Checking Up
					if((gfr.pacmanHero.Location.X > 310 && gfr.pacmanHero.Location.X < 340  )&&( gfr.pacmanHero.Location.Y > 146 && gfr.pacmanHero.Location.Y < 414 ))
					{
						for(int i =72;  i<=75;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 310 && gfr.pacmanHero.Location.X < 340) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					
					//Right Wallls
					//Right Wall1 Checking Up
					if((gfr.pacmanHero.Location.X > 684 && gfr.pacmanHero.Location.X < 710  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =60;  i<=67;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 684 && gfr.pacmanHero.Location.X < 710) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//Right Wall2 Checking Up
					if((gfr.pacmanHero.Location.X > 566 && gfr.pacmanHero.Location.X < 608  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =80;  i<=83;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 566 && gfr.pacmanHero.Location.X < 608) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//Right Middle Wall3 Checking Up
					if((gfr.pacmanHero.Location.X > 400 && gfr.pacmanHero.Location.X < 428  )&&( gfr.pacmanHero.Location.Y > 146 && gfr.pacmanHero.Location.Y < 414 ))
					{
						for(int i =76;  i<=79;  i++)
						{
							if( (gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y+20) &&(gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 400 && gfr.pacmanHero.Location.X < 428) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
				}
				
				//Checking For Down Position Of PacMan
				if(sh.down)
				{
					//left Wall1 Checking Down
					if((gfr.pacmanHero.Location.X > 28 && gfr.pacmanHero.Location.X < 68  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =52;  i<=59;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 28 && gfr.pacmanHero.Location.X < 68) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					
					
					
					//left Wall2 Checking Down
					if((gfr.pacmanHero.Location.X > 129 && gfr.pacmanHero.Location.X < 160  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =68;  i<=71;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 129 && gfr.pacmanHero.Location.X < 160) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//left Middle Wall3 Checking Down
					if((gfr.pacmanHero.Location.X > 310 && gfr.pacmanHero.Location.X < 340  )&&( gfr.pacmanHero.Location.Y > 146 && gfr.pacmanHero.Location.Y < 414 ))
					{
						for(int i =72;  i<=75;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 310 && gfr.pacmanHero.Location.X < 340) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					
					//Right Wallls
					//Right Wall1 Checking Down
					if((gfr.pacmanHero.Location.X > 684 && gfr.pacmanHero.Location.X < 710  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =60;  i<=67;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 684 && gfr.pacmanHero.Location.X < 710) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//Right Wall2 Checking Down
					if((gfr.pacmanHero.Location.X > 566 && gfr.pacmanHero.Location.X < 608  )&&( gfr.pacmanHero.Location.Y > 40 && gfr.pacmanHero.Location.Y < 515 ))
					{
						for(int i =80;  i<=83;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 566 && gfr.pacmanHero.Location.X < 608) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
					//Right Middle Wall3 Checking Down
					if((gfr.pacmanHero.Location.X > 400 && gfr.pacmanHero.Location.X < 428  )&&( gfr.pacmanHero.Location.Y > 146 && gfr.pacmanHero.Location.Y < 414 ))
					{
						for(int i =76;  i<=79;  i++)
						{
							if( (gfr.pacmanHero.Location.Y > gfr.lbl[i].Location.Y-20) &&(gfr.pacmanHero.Location.Y < gfr.lbl[i].Location.Y)&& ( gfr.pacmanHero.Location.X > 400 && gfr.pacmanHero.Location.X < 428) )
							{
								if(gfr.lbl[i].Visible)
								{
									afterCollission(gfr.lbl[i]);

								}
							}
						}
					}
					
				}
				
			}
		}

	}
}
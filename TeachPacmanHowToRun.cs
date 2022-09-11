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
public class TeachPacmanHowToRun
{
	public GetFormReady gfr=null;
	public StartHero sh =null;
	public Form form= null;
	//public Thread checkThread=null;
	public int count=0;
	
	public TeachPacmanHowToRun()
	{
		
	}
	
	public TeachPacmanHowToRun(GetFormReady gfr,StartHero sh, Form form)
	{
		this.gfr = gfr;
		this.sh = sh;
		this.form = form;
		//checkThread = new Thread(givePacmanDirection);
		//checkThread.Start();
		gfr.timer_pacmanRun.Tick += new EventHandler(pacmanRunning);
		gfr.timer_pacmanRun.Enabled = true;
	}
	
	public void pacmanRunning(object ob , EventArgs e)
	{
		givePacmanDirection();
	}
	
	
	

	public void givePacmanDirection()
	{
		
		//while(true)
		{
			//Making Left Movement False
			if(sh.left)
			{	//1                                                                                                                                                            2                                                                                                                              3                                                                                                        4                                                                                                                                         5                                                                                                6                                                                                                                                   7                                                                                   
				if(((gfr.pacmanHero.Location.Y>229 && gfr.pacmanHero.Location.Y<256)&&(gfr.pacmanHero.Location.X>194 && gfr.pacmanHero.Location.X < 326)) || ((gfr.pacmanHero.Location.Y>140 && gfr.pacmanHero.Location.Y<160)&&(gfr.pacmanHero.Location.X > 86 && gfr.pacmanHero.Location.X<148)) || ((gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<60)&&(gfr.pacmanHero.Location.X<38)) || ((gfr.pacmanHero.Location.Y>365 && gfr.pacmanHero.Location.Y<390)&&(gfr.pacmanHero.Location.X>86 && gfr.pacmanHero.Location.X<148)) || ((gfr.pacmanHero.Location.Y>466 && gfr.pacmanHero.Location.Y<484)&&(gfr.pacmanHero.Location.X<38)) || ((gfr.pacmanHero.Location.Y>147 && gfr.pacmanHero.Location.Y<163)&&(gfr.pacmanHero.Location.X>372 && gfr.pacmanHero.Location.X<410)) || ((gfr.pacmanHero.Location.Y>360 && gfr.pacmanHero.Location.Y<395)&&(gfr.pacmanHero.Location.X>372 && gfr.pacmanHero.Location.X<410)) )
					{
						sh.left = false;
					}
			}
			
			
			//Making Right Movement False
			if(sh.right)
			{
				if( ((gfr.pacmanHero.Location.Y>149 && gfr.pacmanHero.Location.Y<160)&&(gfr.pacmanHero.Location.X>324 && gfr.pacmanHero.Location.X<405)) || ((gfr.pacmanHero.Location.Y>360 && gfr.pacmanHero.Location.Y<384)&&(gfr.pacmanHero.Location.X>322 && gfr.pacmanHero.Location.X<408)) || ((gfr.pacmanHero.Location.Y>229 && gfr.pacmanHero.Location.Y<256)&&(gfr.pacmanHero.Location.X>410 && gfr.pacmanHero.Location.X<584)) || ((gfr.pacmanHero.Location.Y>145 && gfr.pacmanHero.Location.Y<165)&&(gfr.pacmanHero.Location.X>588 && gfr.pacmanHero.Location.X<692)) || ((gfr.pacmanHero.Location.Y>40 && gfr.pacmanHero.Location.Y<62)&&(gfr.pacmanHero.Location.X>696)) || ((gfr.pacmanHero.Location.Y>373 && gfr.pacmanHero.Location.Y<384)&&(gfr.pacmanHero.Location.X>588 && gfr.pacmanHero.Location.X<692)) || ((gfr.pacmanHero.Location.Y>460 && gfr.pacmanHero.Location.Y<484)&&(gfr.pacmanHero.Location.X>696)) )
				{
					sh.right= false;
				}
			}
			
			//Making Up Movement False
			if(sh.up)
			{
				if( ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X<50)&&(gfr.pacmanHero.Location.Y<52)) || ((gfr.pacmanHero.Location.X>130 && gfr.pacmanHero.Location.X<160)&&(gfr.pacmanHero.Location.Y<52)) ||  ((gfr.pacmanHero.Location.X>320 && gfr.pacmanHero.Location.X<330)&&(gfr.pacmanHero.Location.Y>100 && gfr.pacmanHero.Location.Y<154)) ||  ((gfr.pacmanHero.Location.X>406 && gfr.pacmanHero.Location.X<414)&&(gfr.pacmanHero.Location.Y>100 && gfr.pacmanHero.Location.Y<154)) ||  ((gfr.pacmanHero.Location.X>560 && gfr.pacmanHero.Location.X<600)&&(gfr.pacmanHero.Location.Y<52)) ||  ((gfr.pacmanHero.Location.X>680 && gfr.pacmanHero.Location.X<710)&&(gfr.pacmanHero.Location.Y<52))  )
				{
					sh.up = false;
				}
			}
			
			
			//Making Down Movement False
			if(sh.down)
			{
				if( ((gfr.pacmanHero.Location.X>30 && gfr.pacmanHero.Location.X<55)&&(gfr.pacmanHero.Location.Y>480)) || ((gfr.pacmanHero.Location.X>130 && gfr.pacmanHero.Location.X<162)&&(gfr.pacmanHero.Location.Y>480)) ||  ((gfr.pacmanHero.Location.X>320 && gfr.pacmanHero.Location.X<330)&&(gfr.pacmanHero.Location.Y>376 && gfr.pacmanHero.Location.Y<476)) ||  ((gfr.pacmanHero.Location.X>404 && gfr.pacmanHero.Location.X<414)&&(gfr.pacmanHero.Location.Y>374 && gfr.pacmanHero.Location.Y<476)) ||  ((gfr.pacmanHero.Location.X>570 && gfr.pacmanHero.Location.X<595)&&(gfr.pacmanHero.Location.Y>475)) ||  ((gfr.pacmanHero.Location.X>675 && gfr.pacmanHero.Location.X<710)&&(gfr.pacmanHero.Location.Y>480)) )
				{
					sh.down = false;
				}
			}
			
			
				
			
			
		}
	}
	
	
		
}
}

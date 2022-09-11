using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.Threading;

namespace PacManGame
{
	public partial class pacman : Form
	{
		
		
		public pacman()
		{
			GetFormReady gfr = new GetFormReady(this);
			StartHero sh = new StartHero(gfr,this);
			TeachPacmanHowToRun  tpmhtr = new TeachPacmanHowToRun(gfr,sh,this);
			TeachPacmanHowToEat tpmhte = new TeachPacmanHowToEat(gfr,sh,this);
			
			//ghost1
			StartGhost sg1 = new StartGhost(gfr,this,1);
			TeachGhostHowToRun tghtr1 = new  TeachGhostHowToRun(gfr,sg1,this);
			//ghost2
			StartGhost sg2 = new StartGhost(gfr,this,2);
			TeachGhostHowToRun tghtr2 = new  TeachGhostHowToRun(gfr,sg2,this);
			//ghost3
			StartGhost sg3 = new StartGhost(gfr,this,3);
			TeachGhostHowToRun tghtr3 = new  TeachGhostHowToRun(gfr,sg3,this);
			//ghost4
			StartGhost sg4 = new StartGhost(gfr,this,4);
			TeachGhostHowToRun tghtr4 = new  TeachGhostHowToRun(gfr,sg4,this);
			
			//Collision Detection
			GhostPacmanCollission gpc1 = new GhostPacmanCollission(gfr,sg1,this);
			GhostPacmanCollission gpc2 = new GhostPacmanCollission(gfr,sg2,this);
			GhostPacmanCollission gpc3 = new GhostPacmanCollission(gfr,sg3,this);
			GhostPacmanCollission gpc4 = new GhostPacmanCollission(gfr,sg4,this);			
			
			AfterCollission ac = new AfterCollission( gfr,sh,sg1,sg2,sg3,sg4,this);

			
		}

	
		public static void Main(String[] args)
		{
			Application.Run(new pacman());
		}
	}
}
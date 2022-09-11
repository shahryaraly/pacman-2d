using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace PacManGame
{
	public class GetFormReady
	{
		public Label pacmanHero = null;
		public Form form= null;

		
		public Label BlueGhost= null;
		public Label RedGhost= null;
		public Label YellowGhost= null;
		public Label PinkGhost= null;
		
		public Label WallUp= null;
		public Label WallDown= null;
		public Label WallRight= null;
		public Label WallLeft= null;
		
		public Label WallUp2= null;
		public Label WallDown2= null;
		public Label WallRight2= null;
		public Label WallLeft2= null;
			
		public Label WallUp3= null;
		public Label WallDown3= null;
		public Label WallRight3= null;
		public Label WallLeft3= null;
		
		public Label[] lbl = new Label[84]; 
		public int lblCount = 0;
		
		//testing Variable
		public Label test= null;
		
		//its All About Timmer ...
		public Timer timer_startHero = null;
		public Timer timer_pacmanRun = null;
		public Timer timer_pacmanEat = null;
		
		
		public Label lblScore = null;
		public Label lblLifes = null;
		public Label score = null;
		public Label life1 = null;
		public Label life2 = null;
		public Label msg = null;
		
		
		public SoundPlayer chompsound = null;
		
		public GetFormReady()
		{

		}
		
		public GetFormReady(Form form)
		{
			this.form =  form;
			form.Width = 800;
			form.Height = 650;
			form.BackColor = Color.Black;

			Console.WriteLine("Initialization Start");
			
			Console.WriteLine("\n\nInitialization of Timers Started");
			getTimerReady();
			Console.WriteLine("Initialization of Timers Ended Succsessfully...!!!");

			
			Console.WriteLine("\n\nInitialization of Walls Started");
			getWallReady();
			Console.WriteLine("Initialization of Walls Ended Succsessfully...!!!");
			Console.WriteLine("\n\nInitialization of Ghost Started");
			getGhostReady();
			Console.WriteLine("Initialization of Ghost Ended Succsessfully...!!!");
			Console.WriteLine("\n\nInitialization of Hero Started");
			getHeroReady();
			Console.WriteLine("Initialization of Hero Ended Succsessfully...!!!");
			Console.WriteLine("\n\nInitialization of Dots Started");
			getDotsReady();
			Console.WriteLine("Initialization of Dots Ended Succsessfully...!!!");

			
			Console.WriteLine("Initialization End");
			
			// // Testing Purpose
			// test = new Label();
			// test.Height = 50;
			// test.Width = 50;
			// test.Location = new Point(50,50);
			// test.BackColor = Color.Blue;
			// form.Controls.Add(test);
			
			// form.KeyDown += new KeyEventHandler(keydown);
			
			chompsound = new SoundPlayer("pacman_chomp.wav");
			chompsound.PlayLooping();
			

		}
		
		public void getTimerReady()
		{
			timer_pacmanRun = new Timer();
			timer_startHero = new Timer();
			timer_pacmanEat = new Timer();
			
			timer_pacmanRun.Interval = 1;
			timer_startHero.Interval = 1;
			timer_pacmanEat.Interval = 1;
			
			
			Font font = new Font("Gill Sans", 25.0f,FontStyle.Bold);
			lblScore = new Label();
			lblScore.Text = "Score : ";
			lblScore.Font = font;
			lblScore.Height = 60;
			lblScore.Width = 125;
			lblScore.ForeColor = Color.Yellow;
			lblScore.Location = new Point(50,570);
			form.Controls.Add(lblScore);
			

			lblLifes = new Label();
			lblLifes.Text = "Lives : ";
			lblLifes.Font = font;
			lblLifes.Height = 50;
			lblLifes.Width = 120;
			lblLifes.ForeColor = Color.Yellow;
			lblLifes.Location = new Point(330,570);
			form.Controls.Add(lblLifes);
			
			
			
			score = new Label();
			score.Text = "0000";
			score.Font = font;
			score.Height = 50;
			score.Width = 100;
			score.ForeColor = Color.Yellow;
			score.Location = new Point(170,570);
			form.Controls.Add(score);
			
			
			Image img = Image.FromFile("pacmanLife.png");
			
			life1 = new Label();
			life1.Image = img;
			life1.Height = img.Height;
			life1.Width = img.Width;
			life1.ForeColor = Color.Yellow;
			life1.Location = new Point(450,565);
			form.Controls.Add(life1);
			
			
			life2 = new Label();
			life2.Image = img;
			life2.Height = img.Height;
			life2.Width = img.Width;
			life2.ForeColor = Color.Yellow;
			life2.Location = new Point(500,565);
			form.Controls.Add(life2);
			
			
			msg = new Label();
			msg.Text = "";
			msg.Font = font;
			msg.Height = 50;
			msg.Width = 220;
			msg.Visible = false;
			msg.ForeColor = Color.Red;
			msg.Location = new Point(300,250);
			form.Controls.Add(msg);
					
		}
		
		
		public void getDotsReady()
		{
			//wall up1 Dots
			int i;
			int xloc = 50;
			int yloc = 110;
			for(i = lblCount; i<=lblCount+13; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(xloc , 65);
				form.Controls.Add(lbl[i]);
				xloc = xloc+50;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall down1 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			xloc = 50;
			for(i= lblCount; i<=lblCount+13; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(xloc,490);
				form.Controls.Add(lbl[i]);
				xloc = xloc+50;
				//Console.WriteLine("Label Number :  {0} Created",i);
		
			}
			//Console.WriteLine("\n\n");
			//wall up2 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			xloc =150;
			for(i = lblCount; i<=lblCount+11; i++)
			{
				//if((xloc >150 && xloc <370 ) || (xloc>140 && xloc<635))
				{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(xloc,160);
				form.Controls.Add(lbl[i]);
				xloc = xloc+45;
				}
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Down2 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			xloc =150;
			for(i = lblCount; i<=lblCount+11; i++)
			{
				//if((xloc >150 && xloc <370 ) || (xloc>140 && xloc<635))
				{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(xloc,390);
				form.Controls.Add(lbl[i]);
				xloc = xloc+45;
				}
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall left1 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			for(i=lblCount; i<= lblCount+7; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(50,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Right1 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			yloc = 110;
			for(i=lblCount; i<= lblCount+7; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(700,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Left2 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			yloc = 200;
			for(i=lblCount; i<= lblCount+3; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(150,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Middle left Dots
			lblCount = i;
			form.Text = ""+lblCount;
			yloc = 200;
			for(i=lblCount; i<= lblCount+3; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(330,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Middle Right Dots
			lblCount = i;
			form.Text = ""+lblCount;
			yloc = 200;
			for(i=lblCount; i<= lblCount+3; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(420,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//wall Right2 Dots
			lblCount = i;
			form.Text = ""+lblCount;
			yloc = 200;
			for(i=lblCount; i<= lblCount+3; i++)
			{
				lbl[i] = new Label();
				Image foodImage = Image.FromFile("food.gif");
				lbl[i].Width = foodImage.Width;
				lbl[i].Height = foodImage.Height;
				lbl[i].Image = foodImage;
				lbl[i].Location = new Point(600,yloc);
				form.Controls.Add(lbl[i]);
				yloc = yloc+48;
				//Console.WriteLine("Label Number :  {0} Created",i);
			}
			//Console.WriteLine("\n\n");
			//Final value of Total Dots Label
			//lblCount = i-1;
			//form.Text = ""+lblCount;
			
		}
		
		
		void keydown(object o, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Up)
			{
				test.Location = new Point(test.Location.X,test.Location.Y-2);
			}
			
			if(e.KeyCode == Keys.Down)
			{
				test.Location = new Point(test.Location.X,test.Location.Y+2);
			}
			
			if(e.KeyCode == Keys.Right)
			{
				test.Location = new Point(test.Location.X+2,test.Location.Y);
			}
			
			if(e.KeyCode == Keys.Left)
			{
				test.Location = new Point(test.Location.X-2,test.Location.Y);
			}
				//form.Text = "X : "+test.Location.X+" Y : "+test.Location.Y;
				form.Text = "PacMan Updated Version... !!!";
		}
		

		
		public void getWallReady()
		{
			//WallUp Codding
			WallUp = new Label();
			WallUp.Location = new Point(200,100);
			WallUp.Width = 380;
			WallUp.Height = 50;
			WallUp.BackColor = Color.Purple;
			form.Controls.Add(WallUp);
			
			//WallDown Codding
			WallDown = new Label();
			WallDown.Location = new Point(200,425);
			WallDown.Width = 380;
			WallDown.Height = 50;
			WallDown.BackColor = Color.Purple;
			form.Controls.Add(WallDown);
			
			
			//WallRight Codding
			WallRight = new Label();
			WallRight.Location = new Point(640,100);
			WallRight.Width = 50;
			WallRight.Height = 370;
			WallRight.BackColor = Color.Purple;
			form.Controls.Add(WallRight);
			
			
			//WallLeft Codding
			WallLeft = new Label();
			WallLeft.Location = new Point(90,100);
			WallLeft.Width = 50;
			WallLeft.Height = 370;
			WallLeft.BackColor = Color.Purple;
			form.Controls.Add(WallLeft);
			
			
			//WallUp2 Codding
			WallUp2 = new Label();
			WallUp2.Location = new Point(375,130);
			WallUp2.Width = 30;
			WallUp2.Height = 100;
			WallUp2.BackColor = Color.Purple;
			form.Controls.Add(WallUp2);
			
			
			//WallDown2 Codding
			WallDown2 = new Label();
			WallDown2.Location = new Point(375,295);
			WallDown2.Width = 30;
			WallDown2.Height = 130;
			WallDown2.BackColor = Color.Purple;
			form.Controls.Add(WallDown2);
			
			//WallRight2 Codding
			WallRight2 = new Label();
			WallRight2.Location = new Point(460,205);
			WallRight2.Width = 120;
			WallRight2.Height = 170;
			WallRight2.BackColor = Color.Purple;
			form.Controls.Add(WallRight2);
			
			//WallLeft2 Codding
			WallLeft2 = new Label();
			WallLeft2.Location = new Point(200,205);
			WallLeft2.Width = 120;
			WallLeft2.Height = 170;
			WallLeft2.BackColor = Color.Purple;
			form.Controls.Add(WallLeft2);
			
		
			//WallUp3 Codding
			WallUp3 = new Label();
			WallUp3.Location = new Point(0,0);
			WallUp3.Height = 40;
			WallUp3.Width = form.Width;
			WallUp3.BackColor = Color.Purple;
			form.Controls.Add(WallUp3);
			
			//WallDown3 Codding
			WallDown3 = new Label();
			WallDown3.Location = new Point(0,530);
			WallDown3.Height = 30;
			WallDown3.Width = form.Width;
			WallDown3.BackColor = Color.Purple;
			form.Controls.Add(WallDown3);
			
			//WallLeft3 Codding
			WallLeft3 = new Label();
			WallLeft3.Location = new Point(0,30);
			WallLeft3.Height = form.Height-150;
			WallLeft3.Width = 30;
			WallLeft3.BackColor = Color.Purple;
			form.Controls.Add(WallLeft3);
			
			//WallRight3 Codding
			WallRight3 = new Label();
			WallRight3.Location = new Point(755,30);
			WallRight3.Height = form.Height-150;
			WallRight3.Width = 30;
			WallRight3.BackColor = Color.Purple;
			form.Controls.Add(WallRight3);
		}
		
		
		public void getGhostReady()
		{
			//redGhost Codding
			RedGhost = new Label();
			RedGhost.Location = new Point(300,50);
			Image RedGhostImage = Image.FromFile("RedGhost2.gif");
			RedGhost.Height = RedGhostImage.Height;
			RedGhost.Width = RedGhostImage.Width;
			RedGhost.Image = RedGhostImage;
			form.Controls.Add(RedGhost);
			
			//blueGhost Codding
			BlueGhost = new Label();
			BlueGhost.Location = new Point(350,50);
			Image BlueGhostImage = Image.FromFile("BlueGhost2.gif");
			BlueGhost.Height = BlueGhostImage.Height;
			BlueGhost.Width = BlueGhostImage.Width;
			BlueGhost.Image = BlueGhostImage;
			form.Controls.Add(BlueGhost);
			
			//yellowGhost Codding
			YellowGhost = new Label();
			YellowGhost.Location = new Point(400,50);
			Image YellowGhostImage = Image.FromFile("YellowGhost2.gif");
			YellowGhost.Height = YellowGhostImage.Height;
			YellowGhost.Width = YellowGhostImage.Width;
			YellowGhost.Image = YellowGhostImage;
			form.Controls.Add(YellowGhost);
			
			// PinkGhost Codding
			PinkGhost = new Label();
			PinkGhost.Location = new Point(450,50);
			Image PinkGhostImage = Image.FromFile("PinkGhost2.gif");
			PinkGhost.Height = PinkGhostImage.Height;
			PinkGhost.Width = PinkGhostImage.Width;
			PinkGhost.Image = PinkGhostImage;
			form.Controls.Add(PinkGhost);
		}
		
		public void getHeroReady()
		{
			// hero pacmanHero Codding
			pacmanHero = new Label();
			pacmanHero.Location = new Point(350,240);
			Image pacmanImage = Image.FromFile("pacmanLeft.gif");
			pacmanHero.Height = pacmanImage.Height;
			pacmanHero.Width = pacmanImage.Width;
			pacmanHero.Image = pacmanImage;
			form.Controls.Add(pacmanHero);
			
		}
	}
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form2 : Form
    {
        BallBehavior behavior;
        PictureBox[] rewards;
        List<PictureBox>[] reflectors;
        bool isMouseDown;
        bool mouseEvents;
        public Form2()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            mouseEvents = true;
            reflectors = new List<PictureBox>[3];
            reflectors[0] = new List<PictureBox>();
            reflectors[1] = new List<PictureBox>();
            reflectors[2] = new List<PictureBox>();
            behavior = new BallBehavior();
            rewards = StaticObjectCreator.RewardPosition(Height, Width);
            Controls.AddRange(rewards);
            timer1.Interval = 20;
            timer1.Tick += new EventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            behavior.StaticObject(ball, reflectors, endgame, rewards);
            ball.Invalidate();
        }
        private void ESC(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void MouseReflectorOn(PictureBox reflector)
        {
            reflector.MouseMove += new MouseEventHandler(Reflector_MouseMove);
            reflector.MouseDown += new MouseEventHandler(Reflector_MouseDown);
            reflector.MouseUp += new MouseEventHandler(Reflector_MouseUp);
            reflector.MouseDoubleClick += new MouseEventHandler(Reflector_MouseDoubleClick);
            Controls.Add(reflector);
        }
        private void HideElements()
        {
            addleftup.Hide();
            addrightup.Hide();
            addup.Hide();
            start.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }
        private void ShowElements()
        {
            addleftup.Show();
            addrightup.Show();
            addup.Show();
            start.Show();
            label1.Show();
            label2.Show();
            label3.Show();
        }
        private void button_AddRightUpReflector(object sender, EventArgs e)
        {
            PictureBox reflector = StaticObjectCreator.AddReflectorRightUp();
            MouseReflectorOn(reflector);
            Controls.Add(reflector);
            reflectors[0].Add(reflector);
        }
        private void button_AddUpReflector(object sender, EventArgs e)
        {
            PictureBox reflector = StaticObjectCreator.AddReflectorUp();
            MouseReflectorOn(reflector);
            Controls.Add(reflector);
            reflectors[1].Add(reflector);
        }
        private void button_AddLeftUpReflector(object sender, EventArgs e)
        {
            PictureBox reflector = StaticObjectCreator.AddReflectorLeftUp();
            MouseReflectorOn(reflector);
            Controls.Add(reflector);
            reflectors[2].Add(reflector);
        }
        private void Reflector_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseEvents)
                isMouseDown = true;
            HideElements();
        }

        private void Reflector_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isMouseDown)
            {

                c.Location = PointToClient(MousePosition);
            }
        }

        private void Reflector_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            ShowElements();
        }

        private void Reflector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (mouseEvents)
            {
                c.Location = new System.Drawing.Point(2000,1000);
                c.Dispose();
            }
            
        }

        private void button_StartLevel(object sender, EventArgs e)
        {
            HideElements();
            mouseEvents = false;
            start.Enabled = false;
            restart.Enabled = true;
            restart.Show();
            timer1.Start();
        }
        private void button_RestartLevel(object sender, EventArgs e)
        {
            timer1.Stop();
            StaticObjectCreator.BallStartPosition(ball);
            mouseEvents = true;
            behavior.OriginMoveDirection();
            StaticObjectCreator.RewardStartPosition(rewards);
            ShowElements();
            start.Enabled = true;
            restart.Enabled = false;
            restart.Hide();
        }
    }
}
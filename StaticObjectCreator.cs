using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGame
{
    static class StaticObjectCreator
    {
        static int countup = 0;
        static int countleftup = 0;
        static int countrightup = 0;

        static readonly Random random = new Random();
        static public PictureBox[] RewardPosition(int Height, int Width)
        {
            int numofrew = random.Next(3, 5);
            PictureBox[] rewards = new PictureBox[numofrew];
            rewards[0] = new PictureBox
            {
                Image = Properties.Resources.Moss,
                Location = new Point(random.Next(Width - 20), random.Next(Height - 20)),
                Size = new Size(64, 64),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = $"reward0",
                BackgroundImageLayout = ImageLayout.None,
            };
            for (int i = 1; i < numofrew; i++)
            {
                PictureBox rew = new PictureBox
                {
                    Image = Properties.Resources.Moss,
                    Location = new Point(random.Next(Width - 20), random.Next(Height - 20)),
                    Size = new Size(64, 64),
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Name = $"reward{i}",
                    BackgroundImageLayout = ImageLayout.None,
                };
                while (Math.Abs(rewards[i - i].Location.X - rew.Location.Y) < rew.Width * 3 && Math.Abs(rewards[i - i].Location.Y - rew.Location.Y) < rew.Width * 3)
                {
                    rew.Location = new Point(random.Next(Width - 20), random.Next(Height - 20));
                }
                rewards[i] = rew;
            }
            return rewards;
        }

        static public void RewardStartPosition(PictureBox[] rewards)
        {
            for (int i = 0; i < rewards.Length; i++)
            {
                rewards[i].Visible = true;
            }
        }
        static public PictureBox AddReflectorUp()
        {
            PictureBox pictureBox = new PictureBox()
            {
                Anchor = AnchorStyles.None,
                Image = Properties.Resources.loghor,
                Location = new Point(0, 0),
                Size = new Size(170, 55),
                BackgroundImageLayout = ImageLayout.None,
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = $"logup{countup}",
            };
            countup++;
            return pictureBox;
        }
        static public PictureBox AddReflectorLeftUp()
        {
            PictureBox pictureBox = new PictureBox()
            {
                Anchor = AnchorStyles.None,
                Image = Properties.Resources.logleft,
                Location = new Point(0, 0),
                Size = new Size(170, 170),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = $"logleftup{countleftup}",
                BackgroundImageLayout = ImageLayout.None,
            };
            countleftup++;
            return pictureBox;
        }
        static public PictureBox AddReflectorRightUp()
        {
            PictureBox pictureBox = new PictureBox()
            {
                Anchor = AnchorStyles.None,
                Image = Properties.Resources.logright,
                Location = new Point(0, 0),
                Size = new Size(170, 170),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = $"logrightup{countrightup}",
                BackgroundImageLayout = ImageLayout.None,
            };
            countrightup++;
            return pictureBox;
        }

        static public void BallStartPosition(PictureBox ball)
        {
            ball.Visible = true;
            ball.Location = new Point(40, 10);
        }
    }
}
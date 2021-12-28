using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGame
{
    class BallBehavior
    {
        private int speed;
        private int x;
        private int y;
        public BallBehavior()
        {
            OriginMoveDirection();
        }

        public void OriginMoveDirection()
        {
            x = 0;
            speed = 10;
            y = speed;
        }

        public void StaticObject(PictureBox ball, List<PictureBox>[] reflectors, PictureBox endgame, PictureBox[] rewards)
        {
            ball.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            ball.Location = new Point(ball.Location.X + x, ball.Location.Y + y);
            Point ballCenter = new Point(ball.Location.X + ball.Width / 2, ball.Location.Y + ball.Height / 2);


            foreach (var reflright in reflectors[0])
            {
                Point reflrightCenter = new Point(reflright.Location.X + reflright.Width / 2, reflright.Location.Y + reflright.Height / 2);
                if (ball.Bounds.IntersectsWith(reflright.Bounds))
                {
                    if (Math.Pow(ballCenter.X - reflrightCenter.X, 2) + Math.Pow(ballCenter.Y - reflrightCenter.Y, 2) <= Math.Pow((double)ball.Width*2, 2))
                        if (ballCenter.Y - reflrightCenter.Y > 0)
                        {
                            x = 0;
                            y = 0;
                            y += speed;
                            x -= speed;
                        }
                        else
                        {
                            x = 0;
                            y = 0;
                            y -= speed;
                            x += speed;
                        }
                }
            }

            foreach (var reflup in reflectors[1])
            {
                if (ball.Bounds.IntersectsWith(reflup.Bounds))
                    if (ball.Location.Y - reflup.Location.Y > 0)
                    {
                        x = 0;
                        y = 0;
                        y += speed;
                    }
                    else
                    {
                        x = 0;
                        y = 0;
                        y -= speed;
                    }
            }

            foreach (var reflleft in reflectors[2])
            {
                Point reflrightCenter = new Point(reflleft.Location.X + reflleft.Width / 2, reflleft.Location.Y + reflleft.Height / 2);
                if (ball.Bounds.IntersectsWith(reflleft.Bounds))
                {
                    if (Math.Pow(ballCenter.X - reflrightCenter.X, 2) + Math.Pow(ballCenter.Y - reflrightCenter.Y, 2) <= Math.Pow((double)ball.Width*2, 2))
                        if (ballCenter.Y - reflrightCenter.Y > 0)
                        {
                            x = 0;
                            y = 0;
                            y += speed;
                            x += speed;
                        }
                        else
                        {
                            x = 0;
                            y = 0;
                            y -= speed;
                            x -= speed;
                        }
                }
            }
            foreach (var item in rewards)
            {
                if (ball.Bounds.IntersectsWith(item.Bounds))
                {
                    item.Visible = false;
                }
            }

            if (ball.Bounds.IntersectsWith(endgame.Bounds))
            {
                ball.Size = new Size(0, 0);
                MessageBox.Show($"Level complete!");
            }
        }
    }
}
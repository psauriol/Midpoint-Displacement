using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Midpoint_Displacement
{
    public partial class Form1 : Form
    {
        Point leftPoint = new Point(0, 0);
        Point rightPoint = new Point(1200, 0);
        Color awsome = Color.Black;//color parts
        int A;
        int R;
        int G;
        int B;
        //string txtColor;
        //Random rand = new Random();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "11";
            positionAdjust();
        }

        void positionAdjust()
        {
            leftPoint.X += 100;
            leftPoint.Y += 400;
            rightPoint.X -= 100;
            rightPoint.Y += 400;
        }

       /* void curveCalc(Point startPoint, Point endPoint, int stopCalc)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(awsome, 1);
            if (stopCalc > 0)
            {
                ChangeColor();

                if (startPoint.Y < 300)
                {
                startPoint.X += 10;
                endPoint.Y -= 10;
                curveCalc(startPoint, endPoint, stopCalc - 1);
                graphicsObj.DrawLine(myPen, startPoint, endPoint);
                }else{

            
                    endPoint.X -= 10;
                    startPoint.Y -= 10;
                    curveCalc(startPoint, endPoint, stopCalc - 1);
                    graphicsObj.DrawLine(myPen, startPoint, endPoint);
                }
            }
        }*/
       /* int randomOffsetY(int offset)
        {
                //start randomization block
                int add = new Random().Next(1, 6);
                add /= 10;
                int bob = (new Random().Next(11, 21)) % 2;
                if (bob == 0)
                {
                    bob = -1;
                }

                offset *= (1 + add) * bob;
                //end random block    

            return offset;
        }*/


        void lineCalc(Point startPoint, Point endPoint, int stopCalc, int offset)
        {
            
            offset /= 2;


            if (stopCalc > 0)
            {
               
                
                Point midPoint = new Point();

                midPoint.X = ((startPoint.X + endPoint.X) / 2);
                midPoint.Y = ((startPoint.Y + endPoint.Y) / 2) - offset;
                ChangeColor();
                System.Drawing.Graphics graphicsObj;
                graphicsObj = this.CreateGraphics();
                Pen leftPen = new Pen(awsome, 1);//pen/color for left hand lines
                Pen rightPen = new Pen(Color.Red, 1); //pen/color for right hand lines
                Pen basePen = new Pen(Color.ForestGreen, 1);//pen/color for terrain layer
                Pen waterPen = new Pen(Color.Blue, 1);//pen/color for water layer
                Pen snowPen = new Pen(Color.WhiteSmoke, 1);//pen/color for snow layer
                Pen skyPen = new Pen(Color.LightSkyBlue, 1);//pen/color for sky layer

                
                if (stopCalc == 1 || ShowlinesCheckbox.Checked == true)
                {

                    if (ShowFillCheckbox.Checked == true)
                    {
                        graphicsObj.DrawLine(skyPen, midPoint.X, midPoint.Y, midPoint.X, 50);//draws right hand lines
                        if (midPoint.Y < 500)
                        {
                          
                            graphicsObj.DrawLine(basePen, midPoint.X, midPoint.Y, midPoint.X, 500);//fills between terrain and base
                            
                            if (midPoint.Y < 200)
                            {
                                int snowLine = new Random().Next(195, 205);
                                graphicsObj.DrawLine(snowPen, midPoint.X, midPoint.Y, midPoint.X, snowLine);//fills between snow layer and peak
                            }
                        }
                        if(midPoint.Y > 400)
                        {
                            graphicsObj.DrawLine(waterPen, midPoint.X, midPoint.Y, midPoint.X, 400);//fills stuff under base with blue
                        }
                    }

                    
                    graphicsObj.DrawLine(rightPen, midPoint, endPoint);//draws right hand lines
                    graphicsObj.DrawLine(leftPen, startPoint, midPoint);//draws left hand lines

                }

                
                //start randomization block
                //randomOffsetY(offset);
                int add = new Random().Next(1, 8);
                add /= 10;
                int bob = (new Random().Next(11, 21)) % 2;
                if (bob == 0)
                {
                    bob = -1;
                }

                offset *= (1 + add) * bob;//kill this line to remove the displacement
                //end random block    

                lineCalc(startPoint, midPoint, stopCalc - 1, offset);//starts method to calculate new lefthand line
                lineCalc(midPoint, endPoint, stopCalc - 1, offset);//starts method to calculate new righthand line


                
            }
        }
        void ChangeColor()
        {
            //convert color to string
            string txtColor = awsome.A + "," + awsome.R + "," + awsome.G + "," + awsome.B;

            
            //to convert your string to color
            string[] awsomeSplit = txtColor.Split(',');
            A = awsome.A;
            R = awsome.R;
            G = awsome.G;
            B = awsome.B;
            if ((R + 5) < 255)
            {
                R = 240;
               // R += 1;
            }
            else if ((G + 5) < 255)
            {
                G += 1;
            }
            else if ((B + 5) < 255)
            {
                B += 1;
            }
            else { }
            A = 200;
            awsomeSplit[0] = Convert.ToString(A);
            awsomeSplit[1] = Convert.ToString(R);
            awsomeSplit[2] = Convert.ToString(G);
            awsomeSplit[3] = Convert.ToString(B);
            awsome = Color.FromArgb(Convert.ToInt32(awsomeSplit[0]),
                                Convert.ToInt32(awsomeSplit[1]),
                                Convert.ToInt32(awsomeSplit[2]),
                                Convert.ToInt32(awsomeSplit[3]));

            
            label2.Text = txtColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int times = Convert.ToInt32(textBox1.Text);
            
            int peakY = new Random().Next(256, 512);//determins starting height of peak
    


            lineCalc(leftPoint, rightPoint, times, peakY);
          //debug label1.Text = "Point 1: " + leftPoint + "\nPoint 2: " + rightPoint + "\nMid-Point: " ;
          //debug  label2.Text = "" + awsome;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}

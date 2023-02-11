using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoControlAppPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openapp(object sender, EventArgs e)
        {
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "How Kteam - Free Education.html");
            Process.Start("How Kteam - Free Education.html");
        }
        private void okk( int x, int y)
        {
            EMouseKey mouseKey = EMouseKey.LEFT;

            AutoControl.MouseClick(x, y, mouseKey);
        }

        private void pingg()
        {
            Thread.Sleep(600);

            AutoControl.SendKeyFocus(KeyCode.KEY_S);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_O);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_W);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_N);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_D);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_D);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_E);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_P);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_J);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_T);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_R);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_A);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_I);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_Q);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_U);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_A);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_S);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.ENTER);
            Thread.Sleep(100);

            AutoControl.SendKeyFocus(KeyCode.KEY_T);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_I);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_C);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_S);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_S);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_O);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_W);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_N);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_Q);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_U);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_A);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_S);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.ENTER);
            Thread.Sleep(100);



            AutoControl.SendKeyFocus(KeyCode.KEY_M);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_O);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_A);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);

            AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100); AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100); AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100); AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100); AutoControl.SendKeyFocus(KeyCode.SPACE_BAR);
            Thread.Sleep(100);



            AutoControl.SendKeyFocus(KeyCode.KEY_M);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_O);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_A);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.KEY_H);
            Thread.Sleep(100);
            AutoControl.SendKeyFocus(KeyCode.ENTER);
            Thread.Sleep(100);
        }
        private void coverr(string input)
        {
            
            int a, b;

            MatchCollection matches = Regex.Matches(input, @"\d+");
            a = int.Parse(matches[0].Value);
            b = int.Parse(matches[1].Value);
            okk(a, b);
        }

        private void img(string tmp)
        {

            var screen = CaptureHelper.CaptureScreen();
            screen.Save("mainScreen.PNG");
            var subBitmap = ImageScanOpenCV.GetImage(tmp);


            var resBitmap = ImageScanOpenCV.FindOutPoint((Bitmap)screen, subBitmap);
            if (resBitmap != null)
            {
                coverr(resBitmap.ToString());

            }

        }
        private void button17_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/trongsonne/";
            System.Diagnostics.Process.Start(url);

            Thread.Sleep(4000);

            img("pick_mess.png");
            Thread.Sleep(100);

            img("tesstt.png");
            Thread.Sleep(100);

            pingg();
           
           
                
        }

    }
}

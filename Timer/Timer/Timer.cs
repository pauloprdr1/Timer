using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private int timeLeft;
        private bool OnOff=false;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool negativo = Temporizador.Text.StartsWith("-");
            // Convert text to seconds as int for timer
            string[] totalSeconds = Temporizador.Text.Split(':');
            int hours = Convert.ToInt32(totalSeconds[0]);
            int minutes = Convert.ToInt32(totalSeconds[1]);
            int seconds = Convert.ToInt32(totalSeconds[2]);
            timeLeft =(hours * 3600) + (minutes * 60) + seconds;
            if (negativo) { timeLeft = -timeLeft; }

            // Lock Start and Clear buttons and text box
            buttonStart.Enabled = false;
            buttonReset.Enabled = false;
            buttonExit.Enabled = false;
            buttonHoras.Enabled = false;
            Temporizador.ReadOnly = true;
            Temporizador.ForeColor = Color.Red;
            Temporizador.BackColor = Color.White;
            textBoxTimeUp.ReadOnly = true;
            textBoxTimeUp2.ReadOnly = true;

            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeLeft = 0;
            buttonStart.Enabled = true;
            buttonReset.Enabled = true;
            buttonExit.Enabled = true;
            buttonHoras.Enabled = true;
            Temporizador.ReadOnly = false;
            textBoxTimeUp.ReadOnly = true;
            textBoxTimeUp2.ReadOnly = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Temporizador.ForeColor = Color.Red;
            Temporizador.BackColor = Color.White;
            textBoxTimeUp.Text = "";
            textBoxTimeUp.BackColor = Color.White;
            textBoxTimeUp2.Text = "";
            textBoxTimeUp2.BackColor = Color.White;
            Temporizador.Text = "00:00:00";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;
            // Display time remaining as mm:ss
            var timespan = TimeSpan.FromSeconds(timeLeft);
            if (timeLeft < 0) { Temporizador.Text = "-" + timespan.ToString(@"hh\:mm\:ss"); }
            else { Temporizador.Text = timespan.ToString(@"hh\:mm\:ss"); }
            
            if (timeLeft < 0)
            {
                Temporizador.ReadOnly = true;
                Temporizador.ForeColor = Color.Orange;
                if (Temporizador.BackColor == Color.White) { Temporizador.BackColor = Color.Red; }
                else if (Temporizador.BackColor == Color.Red) { Temporizador.BackColor = Color.White; }
                textBoxTimeUp.Text = "Time is Up!";
                if (textBoxTimeUp.BackColor == Color.White) { textBoxTimeUp.BackColor = Color.Red; }
                else if (textBoxTimeUp.BackColor == Color.Red) { textBoxTimeUp.BackColor = Color.White; }
                textBoxTimeUp2.Text = "O Tempo Terminou!";
                if (textBoxTimeUp2.BackColor == Color.White) { textBoxTimeUp2.BackColor = Color.Red; }
                else if (textBoxTimeUp2.BackColor == Color.Red) { textBoxTimeUp2.BackColor = Color.White; }
            }
            else if (timeLeft >= 0)
            {
                Temporizador.ReadOnly = true;
                Temporizador.ForeColor = Color.Red;
                Temporizador.BackColor = Color.White;
                textBoxTimeUp.Text = "";
                textBoxTimeUp.BackColor = Color.White;
                textBoxTimeUp2.Text = "";
                textBoxTimeUp2.BackColor = Color.White;
            }


        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHoras_Click(object sender, EventArgs e)
        {
            if(OnOff==false)
            {
                textBoxTimeUp.Text = "";
                textBoxTimeUp.BackColor = Color.White;
                textBoxTimeUp2.Text = "";
                textBoxTimeUp2.BackColor = Color.White;
                buttonStart.Enabled = false;
                buttonReset.Enabled = false;
                buttonStop.Enabled = false;
                buttonExit.Enabled = true;
                buttonHoras.Enabled = true;
                Temporizador.ReadOnly = true;
                textBoxTimeUp.ReadOnly = true;
                textBoxTimeUp2.ReadOnly = true;
                Temporizador.ForeColor = Color.Blue;
                Temporizador.BackColor = Color.White;
                textBoxTimeUp.BackColor = Color.Gray;
                textBoxTimeUp2.BackColor = Color.Gray;
                Temporizador.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
                timer2.Start();
                OnOff = true;
            }
            else if(OnOff==true)
            {
                timer2.Stop();
                buttonStart.Enabled = true;
                buttonReset.Enabled = true;
                buttonStop.Enabled = true;
                buttonExit.Enabled = true;
                buttonHoras.Enabled = true;
                Temporizador.ReadOnly = false;
                textBoxTimeUp.ReadOnly = true;
                textBoxTimeUp2.ReadOnly = true;
                Temporizador.ForeColor = Color.Red;
                Temporizador.BackColor = Color.White;
                Temporizador.Text = "00:00:00";
                OnOff = false;
                textBoxTimeUp.BackColor = Color.White;
                textBoxTimeUp2.BackColor = Color.White;
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Temporizador.Text = DateTime.Now.ToString(@"HH\:mm\:ss");
        }
    }
}
/*
 *ISC License                                                               *
 *                                                                          *
 *Copyright (c) [2020], [Paulo Ricardo Durão Rodrigues (PRDR)]              *
 *                                                                          *
 *Permission to use, copy, modify, and/or distribute this software for any  *
 *purpose with or without fee is hereby granted, provided that the above    *
 *copyright notice and this permission notice appear in all copies.         *
 *                                                                          *
 *THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES  *
 *WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF          *
 *MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR   *
 *ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES    *
 *WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN     *
 *ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF   *
 *OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.            *
 */

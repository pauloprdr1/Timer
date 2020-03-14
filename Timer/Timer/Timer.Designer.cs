namespace Timer
{
    partial class Timer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.TextBox();
            this.buttonHoras = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.começarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.começarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.horasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.começarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.horasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTimeUp = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxTimeUp2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(698, 722);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(29, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStart.Location = new System.Drawing.Point(12, 712);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(63, 44);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "►";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStop.Location = new System.Drawing.Point(81, 712);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(62, 44);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "||";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Blue;
            this.buttonReset.Location = new System.Drawing.Point(149, 712);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(62, 44);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "R";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Font = new System.Drawing.Font("Arial Narrow", 215.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temporizador.ForeColor = System.Drawing.Color.Red;
            this.Temporizador.Location = new System.Drawing.Point(0, 29);
            this.Temporizador.Name = "Temporizador";
            this.Temporizador.Size = new System.Drawing.Size(1024, 337);
            this.Temporizador.TabIndex = 5;
            this.Temporizador.Text = "00:00:00";
            this.Temporizador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonHoras
            // 
            this.buttonHoras.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHoras.Location = new System.Drawing.Point(217, 719);
            this.buttonHoras.Name = "buttonHoras";
            this.buttonHoras.Size = new System.Drawing.Size(76, 37);
            this.buttonHoras.TabIndex = 7;
            this.buttonHoras.Text = "Horas";
            this.buttonHoras.UseVisualStyleBackColor = true;
            this.buttonHoras.Click += new System.EventHandler(this.buttonHoras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.começarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // começarToolStripMenuItem1
            // 
            this.começarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.começarToolStripMenuItem2,
            this.pausaToolStripMenuItem1,
            this.resetToolStripMenuItem1,
            this.sToolStripMenuItem,
            this.horasToolStripMenuItem,
            this.sToolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.começarToolStripMenuItem1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.começarToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.começarToolStripMenuItem1.Name = "começarToolStripMenuItem1";
            this.começarToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.começarToolStripMenuItem1.Text = "Menu";
            // 
            // começarToolStripMenuItem2
            // 
            this.começarToolStripMenuItem2.Name = "começarToolStripMenuItem2";
            this.começarToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.começarToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.começarToolStripMenuItem2.Text = "Começar";
            this.começarToolStripMenuItem2.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pausaToolStripMenuItem1
            // 
            this.pausaToolStripMenuItem1.Name = "pausaToolStripMenuItem1";
            this.pausaToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.pausaToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.pausaToolStripMenuItem1.Text = "Pausa";
            this.pausaToolStripMenuItem1.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(130, 6);
            // 
            // horasToolStripMenuItem
            // 
            this.horasToolStripMenuItem.Name = "horasToolStripMenuItem";
            this.horasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.horasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem.Text = "Horas";
            this.horasToolStripMenuItem.Click += new System.EventHandler(this.buttonHoras_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.começarToolStripMenuItem3,
            this.pausaToolStripMenuItem2,
            this.resetToolStripMenuItem2,
            this.horasToolStripMenuItem1,
            this.horasToolStripMenuItem2,
            this.toolStripMenuItem4,
            this.sairToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 126);
            // 
            // começarToolStripMenuItem3
            // 
            this.começarToolStripMenuItem3.Name = "começarToolStripMenuItem3";
            this.começarToolStripMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.começarToolStripMenuItem3.Size = new System.Drawing.Size(141, 22);
            this.começarToolStripMenuItem3.Text = "Começar";
            this.começarToolStripMenuItem3.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pausaToolStripMenuItem2
            // 
            this.pausaToolStripMenuItem2.Name = "pausaToolStripMenuItem2";
            this.pausaToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.pausaToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.pausaToolStripMenuItem2.Text = "Pausa";
            this.pausaToolStripMenuItem2.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // resetToolStripMenuItem2
            // 
            this.resetToolStripMenuItem2.Name = "resetToolStripMenuItem2";
            this.resetToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.resetToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.resetToolStripMenuItem2.Text = "Reset";
            this.resetToolStripMenuItem2.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // horasToolStripMenuItem1
            // 
            this.horasToolStripMenuItem1.Name = "horasToolStripMenuItem1";
            this.horasToolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // horasToolStripMenuItem2
            // 
            this.horasToolStripMenuItem2.Name = "horasToolStripMenuItem2";
            this.horasToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.horasToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.horasToolStripMenuItem2.Text = "Horas";
            this.horasToolStripMenuItem2.Click += new System.EventHandler(this.buttonHoras_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(138, 6);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // textBoxTimeUp
            // 
            this.textBoxTimeUp.BackColor = System.Drawing.Color.White;
            this.textBoxTimeUp.Font = new System.Drawing.Font("Consolas", 111F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxTimeUp.Location = new System.Drawing.Point(0, 334);
            this.textBoxTimeUp.Name = "textBoxTimeUp";
            this.textBoxTimeUp.Size = new System.Drawing.Size(1024, 181);
            this.textBoxTimeUp.TabIndex = 9;
            this.textBoxTimeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBoxTimeUp2
            // 
            this.textBoxTimeUp2.BackColor = System.Drawing.Color.White;
            this.textBoxTimeUp2.Font = new System.Drawing.Font("Consolas", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeUp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxTimeUp2.Location = new System.Drawing.Point(0, 491);
            this.textBoxTimeUp2.Name = "textBoxTimeUp2";
            this.textBoxTimeUp2.Size = new System.Drawing.Size(1024, 133);
            this.textBoxTimeUp2.TabIndex = 10;
            this.textBoxTimeUp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 75F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 767);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBoxTimeUp2);
            this.Controls.Add(this.textBoxTimeUp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonHoras);
            this.Controls.Add(this.Temporizador);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonExit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox Temporizador;
        private System.Windows.Forms.Button buttonHoras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem começarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem começarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem começarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator horasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.TextBox textBoxTimeUp;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxTimeUp2;
    }
}
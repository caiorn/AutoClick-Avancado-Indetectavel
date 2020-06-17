namespace AutoClickHn
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkAtivar = new System.Windows.Forms.CheckBox();
            this.timer1Click = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.asdfas = new System.Windows.Forms.Label();
            this.chkMovimentMouse = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMinPressed = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPressed = new System.Windows.Forms.NumericUpDown();
            this.lblTotalClicks = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPressed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblNextClick = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer1Active = new System.Windows.Forms.Timer(this.components);
            this.btnClearListView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1Moviment = new System.Windows.Forms.Timer(this.components);
            this.nudMinWait = new System.Windows.Forms.NumericUpDown();
            this.nudMaxWait = new System.Windows.Forms.NumericUpDown();
            this.nudMinWaitMoviment = new System.Windows.Forms.NumericUpDown();
            this.nudMaxWaitMoviment = new System.Windows.Forms.NumericUpDown();
            this.nudMaxDistY = new System.Windows.Forms.NumericUpDown();
            this.nudMaxDistX = new System.Windows.Forms.NumericUpDown();
            this.nudMouseSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPressed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPressed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWaitMoviment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWaitMoviment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDistY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDistX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAtivar
            // 
            this.chkAtivar.AutoSize = true;
            this.chkAtivar.Location = new System.Drawing.Point(210, 170);
            this.chkAtivar.Name = "chkAtivar";
            this.chkAtivar.Size = new System.Drawing.Size(100, 17);
            this.chkAtivar.TabIndex = 2;
            this.chkAtivar.Text = "(F7)Active Click";
            this.chkAtivar.UseVisualStyleBackColor = true;
            this.chkAtivar.CheckedChanged += new System.EventHandler(this.chkAtivar_CheckedChanged);
            // 
            // timer1Click
            // 
            this.timer1Click.Interval = 1000;
            this.timer1Click.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max (ms):";
            this.toolTip1.SetToolTip(this.label2, "Intervalo de tempo máximo para o clique");
            // 
            // asdfas
            // 
            this.asdfas.AutoSize = true;
            this.asdfas.Location = new System.Drawing.Point(11, 23);
            this.asdfas.Name = "asdfas";
            this.asdfas.Size = new System.Drawing.Size(49, 13);
            this.asdfas.TabIndex = 7;
            this.asdfas.Text = "Min (ms):";
            this.toolTip1.SetToolTip(this.asdfas, "Intervalo de tempo minimo para o clique");
            // 
            // chkMovimentMouse
            // 
            this.chkMovimentMouse.AutoSize = true;
            this.chkMovimentMouse.Location = new System.Drawing.Point(210, 193);
            this.chkMovimentMouse.Name = "chkMovimentMouse";
            this.chkMovimentMouse.Size = new System.Drawing.Size(125, 17);
            this.chkMovimentMouse.TabIndex = 16;
            this.chkMovimentMouse.Text = "(F8)Moviment Mouse";
            this.chkMovimentMouse.UseVisualStyleBackColor = true;
            this.chkMovimentMouse.CheckedChanged += new System.EventHandler(this.chkMovimentMouse_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaxDistX);
            this.groupBox2.Controls.Add(this.nudMaxDistY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(211, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 72);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Max pixel distance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Y:";
            this.toolTip1.SetToolTip(this.label5, "A distancia máxima mouse onde será efetuado o clique.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Min (ms):";
            this.toolTip1.SetToolTip(this.label4, "tempo minimo de pressionamento do mouse");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Max (ms):";
            this.toolTip1.SetToolTip(this.label7, "tempo maximo de permanência ao ser pressionado");
            // 
            // nudMinPressed
            // 
            this.nudMinPressed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinPressed.Location = new System.Drawing.Point(66, 19);
            this.nudMinPressed.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nudMinPressed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinPressed.Name = "nudMinPressed";
            this.nudMinPressed.Size = new System.Drawing.Size(58, 20);
            this.nudMinPressed.TabIndex = 21;
            this.nudMinPressed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudMaxPressed
            // 
            this.nudMaxPressed.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxPressed.Location = new System.Drawing.Point(66, 41);
            this.nudMaxPressed.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nudMaxPressed.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMaxPressed.Name = "nudMaxPressed";
            this.nudMaxPressed.Size = new System.Drawing.Size(58, 20);
            this.nudMaxPressed.TabIndex = 22;
            this.nudMaxPressed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblTotalClicks
            // 
            this.lblTotalClicks.AutoSize = true;
            this.lblTotalClicks.Location = new System.Drawing.Point(219, 430);
            this.lblTotalClicks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalClicks.Name = "lblTotalClicks";
            this.lblTotalClicks.Size = new System.Drawing.Size(65, 13);
            this.lblTotalClicks.TabIndex = 25;
            this.lblTotalClicks.Text = "Total Clicks:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(60, 430);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 13);
            this.lblY.TabIndex = 24;
            this.lblY.Text = "Y: ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(9, 430);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 13);
            this.lblX.TabIndex = 23;
            this.lblX.Text = "X: ";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNum,
            this.cMs,
            this.cX,
            this.cY,
            this.cPressed});
            this.listView1.Location = new System.Drawing.Point(3, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(201, 402);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cNum
            // 
            this.cNum.Text = "Nº";
            this.cNum.Width = 25;
            // 
            // cMs
            // 
            this.cMs.Text = "ms";
            this.cMs.Width = 41;
            // 
            // cX
            // 
            this.cX.Text = "X";
            this.cX.Width = 39;
            // 
            // cY
            // 
            this.cY.Text = "Y";
            this.cY.Width = 34;
            // 
            // cPressed
            // 
            this.cPressed.Text = "pressed";
            this.cPressed.Width = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min (ms):";
            this.toolTip1.SetToolTip(this.label3, "Quantos clicks no minimo que deve ser acionado antes do movimento.");
            // 
            // lblNextClick
            // 
            this.lblNextClick.AutoSize = true;
            this.lblNextClick.Location = new System.Drawing.Point(86, 9);
            this.lblNextClick.Name = "lblNextClick";
            this.lblNextClick.Size = new System.Drawing.Size(118, 13);
            this.lblNextClick.TabIndex = 28;
            this.lblNextClick.Text = "Next Click in (ms): 1000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudMinPressed);
            this.groupBox3.Controls.Add(this.nudMaxPressed);
            this.groupBox3.Location = new System.Drawing.Point(211, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 67);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keep Pressed Click";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudMaxWait);
            this.groupBox4.Controls.Add(this.nudMinWait);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.asdfas);
            this.groupBox4.Location = new System.Drawing.Point(210, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 72);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wait Click(ms)";
            // 
            // timer1Active
            // 
            this.timer1Active.Enabled = true;
            this.timer1Active.Interval = 50;
            this.timer1Active.Tick += new System.EventHandler(this.timer1Active_Tick);
            // 
            // btnClearListView
            // 
            this.btnClearListView.Location = new System.Drawing.Point(160, 430);
            this.btnClearListView.Name = "btnClearListView";
            this.btnClearListView.Size = new System.Drawing.Size(44, 20);
            this.btnClearListView.TabIndex = 31;
            this.btnClearListView.Text = "limpar";
            this.btnClearListView.UseVisualStyleBackColor = true;
            this.btnClearListView.Click += new System.EventHandler(this.btnClearListView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Max (ms):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMaxWaitMoviment);
            this.groupBox1.Controls.Add(this.nudMinWaitMoviment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(211, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 72);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wait Movement(ms)";
            // 
            // timer1Moviment
            // 
            this.timer1Moviment.Interval = 1000;
            this.timer1Moviment.Tick += new System.EventHandler(this.timer1Moviment_Tick);
            // 
            // nudMinWait
            // 
            this.nudMinWait.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinWait.Location = new System.Drawing.Point(66, 20);
            this.nudMinWait.Maximum = new decimal(new int[] {
            9900,
            0,
            0,
            0});
            this.nudMinWait.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinWait.Name = "nudMinWait";
            this.nudMinWait.Size = new System.Drawing.Size(59, 20);
            this.nudMinWait.TabIndex = 32;
            this.nudMinWait.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudMaxWait
            // 
            this.nudMaxWait.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxWait.Location = new System.Drawing.Point(67, 46);
            this.nudMaxWait.Maximum = new decimal(new int[] {
            9900,
            0,
            0,
            0});
            this.nudMaxWait.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxWait.Name = "nudMaxWait";
            this.nudMaxWait.Size = new System.Drawing.Size(58, 20);
            this.nudMaxWait.TabIndex = 33;
            this.nudMaxWait.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudMinWaitMoviment
            // 
            this.nudMinWaitMoviment.Location = new System.Drawing.Point(66, 18);
            this.nudMinWaitMoviment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMinWaitMoviment.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinWaitMoviment.Name = "nudMinWaitMoviment";
            this.nudMinWaitMoviment.Size = new System.Drawing.Size(58, 20);
            this.nudMinWaitMoviment.TabIndex = 16;
            this.nudMinWaitMoviment.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudMaxWaitMoviment
            // 
            this.nudMaxWaitMoviment.Location = new System.Drawing.Point(66, 43);
            this.nudMaxWaitMoviment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxWaitMoviment.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxWaitMoviment.Name = "nudMaxWaitMoviment";
            this.nudMaxWaitMoviment.Size = new System.Drawing.Size(58, 20);
            this.nudMaxWaitMoviment.TabIndex = 17;
            this.nudMaxWaitMoviment.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudMaxDistY
            // 
            this.nudMaxDistY.Location = new System.Drawing.Point(66, 19);
            this.nudMaxDistY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDistY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDistY.Name = "nudMaxDistY";
            this.nudMaxDistY.Size = new System.Drawing.Size(58, 20);
            this.nudMaxDistY.TabIndex = 32;
            this.nudMaxDistY.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudMaxDistX
            // 
            this.nudMaxDistX.Location = new System.Drawing.Point(65, 43);
            this.nudMaxDistX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDistX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDistX.Name = "nudMaxDistX";
            this.nudMaxDistX.Size = new System.Drawing.Size(59, 20);
            this.nudMaxDistX.TabIndex = 33;
            this.nudMaxDistX.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudMouseSpeed
            // 
            this.nudMouseSpeed.Location = new System.Drawing.Point(293, 372);
            this.nudMouseSpeed.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMouseSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMouseSpeed.Name = "nudMouseSpeed";
            this.nudMouseSpeed.Size = new System.Drawing.Size(42, 20);
            this.nudMouseSpeed.TabIndex = 32;
            this.nudMouseSpeed.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mouse Speed:";
            this.toolTip1.SetToolTip(this.label9, "Velocidade do cursor do mouse para chegar do ponto A ao ponto B");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 452);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudMouseSpeed);
            this.Controls.Add(this.btnClearListView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblNextClick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTotalClicks);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMovimentMouse);
            this.Controls.Add(this.chkAtivar);
            this.Name = "Form1";
            this.Text = "AutoClick Avançado CAIO";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPressed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPressed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWaitMoviment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWaitMoviment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDistY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDistX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAtivar;
        private System.Windows.Forms.Timer timer1Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label asdfas;
        private System.Windows.Forms.CheckBox chkMovimentMouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMinPressed;
        private System.Windows.Forms.NumericUpDown nudMaxPressed;
        private System.Windows.Forms.Label lblTotalClicks;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cNum;
        private System.Windows.Forms.ColumnHeader cX;
        private System.Windows.Forms.ColumnHeader cY;
        private System.Windows.Forms.ColumnHeader cMs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader cPressed;
        private System.Windows.Forms.Label lblNextClick;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1Active;
        private System.Windows.Forms.Button btnClearListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1Moviment;
        private System.Windows.Forms.NumericUpDown nudMinWait;
        private System.Windows.Forms.NumericUpDown nudMaxWait;
        private System.Windows.Forms.NumericUpDown nudMaxDistX;
        private System.Windows.Forms.NumericUpDown nudMaxDistY;
        private System.Windows.Forms.NumericUpDown nudMaxWaitMoviment;
        private System.Windows.Forms.NumericUpDown nudMinWaitMoviment;
        private System.Windows.Forms.NumericUpDown nudMouseSpeed;
        private System.Windows.Forms.Label label9;
    }
}


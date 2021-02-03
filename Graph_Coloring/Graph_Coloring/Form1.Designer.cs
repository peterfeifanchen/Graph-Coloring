namespace Graph_Coloring {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highDegreeFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowDegreeFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.randomRecolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recolorMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recolorSwapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusVertexLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusEdgeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDensityLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusKineticEnergyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPotentialEnergyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.runButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.stepsUpDown = new System.Windows.Forms.NumericUpDown();
            this.edgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.repsUpDown = new System.Windows.Forms.NumericUpDown();
            this.graphListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vertexUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.newBipartiteGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newBipartiteGraphToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewGraphClick);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveAllClick);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.OnExportClick);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAllToolStripMenuItem.Text = "Export All";
            this.exportAllToolStripMenuItem.Click += new System.EventHandler(this.OnExportAll);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highDegreeFirstToolStripMenuItem,
            this.lowDegreeFirstToolStripMenuItem,
            this.twoColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.randomRecolorToolStripMenuItem,
            this.toolStripSeparator2,
            this.recolorMaxToolStripMenuItem,
            this.recolorSwapToolStripMenuItem,
            this.normalizeToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // highDegreeFirstToolStripMenuItem
            // 
            this.highDegreeFirstToolStripMenuItem.Name = "highDegreeFirstToolStripMenuItem";
            this.highDegreeFirstToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.highDegreeFirstToolStripMenuItem.Text = "High Degree First";
            this.highDegreeFirstToolStripMenuItem.Click += new System.EventHandler(this.OnHDFClick);
            // 
            // lowDegreeFirstToolStripMenuItem
            // 
            this.lowDegreeFirstToolStripMenuItem.Name = "lowDegreeFirstToolStripMenuItem";
            this.lowDegreeFirstToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lowDegreeFirstToolStripMenuItem.Text = "Low Degree First";
            this.lowDegreeFirstToolStripMenuItem.Click += new System.EventHandler(this.OnLDFClick);
            // 
            // twoColorToolStripMenuItem
            // 
            this.twoColorToolStripMenuItem.Name = "twoColorToolStripMenuItem";
            this.twoColorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.twoColorToolStripMenuItem.Text = "Two Color";
            this.twoColorToolStripMenuItem.Click += new System.EventHandler(this.OnTwoColorClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // randomRecolorToolStripMenuItem
            // 
            this.randomRecolorToolStripMenuItem.Name = "randomRecolorToolStripMenuItem";
            this.randomRecolorToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.randomRecolorToolStripMenuItem.Text = "Random Recolor";
            this.randomRecolorToolStripMenuItem.Click += new System.EventHandler(this.OnRandomRecolorClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // recolorMaxToolStripMenuItem
            // 
            this.recolorMaxToolStripMenuItem.Name = "recolorMaxToolStripMenuItem";
            this.recolorMaxToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.recolorMaxToolStripMenuItem.Text = "Recolor Max";
            this.recolorMaxToolStripMenuItem.Click += new System.EventHandler(this.OnRecolorMax);
            // 
            // recolorSwapToolStripMenuItem
            // 
            this.recolorSwapToolStripMenuItem.Name = "recolorSwapToolStripMenuItem";
            this.recolorSwapToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.recolorSwapToolStripMenuItem.Text = "Recolor Swap";
            this.recolorSwapToolStripMenuItem.Click += new System.EventHandler(this.OnRecolorSwap);
            // 
            // normalizeToolStripMenuItem
            // 
            this.normalizeToolStripMenuItem.Name = "normalizeToolStripMenuItem";
            this.normalizeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.normalizeToolStripMenuItem.Text = "Normalize";
            this.normalizeToolStripMenuItem.Click += new System.EventHandler(this.OnNormalizeClick);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkColorsToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // checkColorsToolStripMenuItem
            // 
            this.checkColorsToolStripMenuItem.Name = "checkColorsToolStripMenuItem";
            this.checkColorsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.checkColorsToolStripMenuItem.Text = "Check Colors";
            this.checkColorsToolStripMenuItem.Click += new System.EventHandler(this.OnColorCheckClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVertexLabel,
            this.statusEdgeLabel,
            this.statusDensityLabel,
            this.statusCountLabel,
            this.statusKineticEnergyLabel,
            this.statusPotentialEnergyLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1003);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1949, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusVertexLabel
            // 
            this.statusVertexLabel.Name = "statusVertexLabel";
            this.statusVertexLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusEdgeLabel
            // 
            this.statusEdgeLabel.Name = "statusEdgeLabel";
            this.statusEdgeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusDensityLabel
            // 
            this.statusDensityLabel.Name = "statusDensityLabel";
            this.statusDensityLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusCountLabel
            // 
            this.statusCountLabel.Name = "statusCountLabel";
            this.statusCountLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusKineticEnergyLabel
            // 
            this.statusKineticEnergyLabel.Name = "statusKineticEnergyLabel";
            this.statusKineticEnergyLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusPotentialEnergyLabel
            // 
            this.statusPotentialEnergyLabel.Name = "statusPotentialEnergyLabel";
            this.statusPotentialEnergyLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.seedUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.runButton);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.stepsUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.edgeUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.repsUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.graphListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.vertexUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.drawingPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1949, 979);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnTestClick);
            // 
            // seedUpDown
            // 
            this.seedUpDown.Location = new System.Drawing.Point(237, 74);
            this.seedUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.seedUpDown.Name = "seedUpDown";
            this.seedUpDown.Size = new System.Drawing.Size(90, 20);
            this.seedUpDown.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(234, 177);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.OnRunButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seed";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 302);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(315, 317);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // stepsUpDown
            // 
            this.stepsUpDown.Location = new System.Drawing.Point(237, 138);
            this.stepsUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.stepsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepsUpDown.Name = "stepsUpDown";
            this.stepsUpDown.Size = new System.Drawing.Size(90, 20);
            this.stepsUpDown.TabIndex = 3;
            this.stepsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edgeUpDown
            // 
            this.edgeUpDown.Location = new System.Drawing.Point(237, 40);
            this.edgeUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.edgeUpDown.Name = "edgeUpDown";
            this.edgeUpDown.Size = new System.Drawing.Size(90, 20);
            this.edgeUpDown.TabIndex = 6;
            // 
            // repsUpDown
            // 
            this.repsUpDown.Location = new System.Drawing.Point(237, 112);
            this.repsUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.repsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repsUpDown.Name = "repsUpDown";
            this.repsUpDown.Size = new System.Drawing.Size(90, 20);
            this.repsUpDown.TabIndex = 2;
            this.repsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // graphListBox
            // 
            this.graphListBox.FormattingEnabled = true;
            this.graphListBox.Location = new System.Drawing.Point(12, 14);
            this.graphListBox.Name = "graphListBox";
            this.graphListBox.Size = new System.Drawing.Size(120, 186);
            this.graphListBox.TabIndex = 2;
            this.graphListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedGraphChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Steps";
            // 
            // vertexUpDown
            // 
            this.vertexUpDown.Location = new System.Drawing.Point(237, 14);
            this.vertexUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vertexUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vertexUpDown.Name = "vertexUpDown";
            this.vertexUpDown.Size = new System.Drawing.Size(90, 20);
            this.vertexUpDown.TabIndex = 5;
            this.vertexUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reps";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(315, 68);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "M";
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(0, 0);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(1606, 979);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDrawingPanelPaint);
            // 
            // newBipartiteGraphToolStripMenuItem
            // 
            this.newBipartiteGraphToolStripMenuItem.Name = "newBipartiteGraphToolStripMenuItem";
            this.newBipartiteGraphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBipartiteGraphToolStripMenuItem.Text = "New Bipartite Graph";
            this.newBipartiteGraphToolStripMenuItem.Click += new System.EventHandler(this.OnNewBipartiteClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1949, 1025);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coloring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown edgeUpDown;
        private System.Windows.Forms.ListBox graphListBox;
        private System.Windows.Forms.NumericUpDown vertexUpDown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.ToolStripStatusLabel statusVertexLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusEdgeLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusDensityLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusKineticEnergyLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusPotentialEnergyLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.NumericUpDown stepsUpDown;
        private System.Windows.Forms.NumericUpDown repsUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem highDegreeFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowDegreeFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomRecolorToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolorMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recolorSwapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem newBipartiteGraphToolStripMenuItem;
    }
}


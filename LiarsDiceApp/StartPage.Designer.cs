namespace LiarsDiceApp
{
    partial class StartPage
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
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dicePerPlayer = new System.Windows.Forms.NumericUpDown();
            this.playerCount = new System.Windows.Forms.NumericUpDown();
            this.myPosition = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._TopPanel = new System.Windows.Forms.Panel();
            this._MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label_playerTurn = new System.Windows.Forms.Label();
            this.groupBox_claimRequest = new System.Windows.Forms.GroupBox();
            this.groupBox_resolution = new System.Windows.Forms.GroupBox();
            this.computerDiceDisplay = new System.Windows.Forms.ListView();
            this.falseClaim = new System.Windows.Forms.Button();
            this.trueClaim = new System.Windows.Forms.Button();
            this.callLiar = new System.Windows.Forms.Button();
            this.SubmitClaim = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox_diceValue = new System.Windows.Forms.GroupBox();
            this.DiceValue5 = new System.Windows.Forms.RadioButton();
            this.DiceValue6 = new System.Windows.Forms.RadioButton();
            this.DiceValue4 = new System.Windows.Forms.RadioButton();
            this.DiceValue2 = new System.Windows.Forms.RadioButton();
            this.DiceValue3 = new System.Windows.Forms.RadioButton();
            this.DiceValue1 = new System.Windows.Forms.RadioButton();
            this.label_quantity = new System.Windows.Forms.Label();
            this.groupBox_diceDisplay = new System.Windows.Forms.GroupBox();
            this.listView_playerDiceCount = new System.Windows.Forms.ListView();
            this.claimListView = new System.Windows.Forms.ListView();
            this.label_roundNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dicePerPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosition)).BeginInit();
            this._TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._MainSplitContainer)).BeginInit();
            this._MainSplitContainer.Panel1.SuspendLayout();
            this._MainSplitContainer.Panel2.SuspendLayout();
            this._MainSplitContainer.SuspendLayout();
            this.groupBox_claimRequest.SuspendLayout();
            this.groupBox_resolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.groupBox_diceValue.SuspendLayout();
            this.groupBox_diceDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(283, 10);
            this.playBtn.Margin = new System.Windows.Forms.Padding(2);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 41);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play!";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dice per player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dicePerPlayer
            // 
            this.dicePerPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dicePerPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dicePerPlayer.Location = new System.Drawing.Point(150, 50);
            this.dicePerPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.dicePerPlayer.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dicePerPlayer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dicePerPlayer.Name = "dicePerPlayer";
            this.dicePerPlayer.Size = new System.Drawing.Size(100, 26);
            this.dicePerPlayer.TabIndex = 2;
            this.dicePerPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dicePerPlayer.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // playerCount
            // 
            this.playerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCount.Location = new System.Drawing.Point(150, 10);
            this.playerCount.Margin = new System.Windows.Forms.Padding(0);
            this.playerCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playerCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playerCount.Name = "playerCount";
            this.playerCount.Size = new System.Drawing.Size(100, 26);
            this.playerCount.TabIndex = 4;
            this.playerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.playerCount.ValueChanged += new System.EventHandler(this.PlayerCount_ValueChanged);
            // 
            // myPosition
            // 
            this.myPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPosition.Location = new System.Drawing.Point(150, 90);
            this.myPosition.Margin = new System.Windows.Forms.Padding(0);
            this.myPosition.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.myPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.myPosition.Name = "myPosition";
            this.myPosition.Size = new System.Drawing.Size(100, 26);
            this.myPosition.TabIndex = 6;
            this.myPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.myPosition.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer Position";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _TopPanel
            // 
            this._TopPanel.BackColor = System.Drawing.Color.Maroon;
            this._TopPanel.Controls.Add(this.myPosition);
            this._TopPanel.Controls.Add(this.label3);
            this._TopPanel.Controls.Add(this.playerCount);
            this._TopPanel.Controls.Add(this.dicePerPlayer);
            this._TopPanel.Controls.Add(this.label2);
            this._TopPanel.Controls.Add(this.label1);
            this._TopPanel.Controls.Add(this.playBtn);
            this._TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._TopPanel.Location = new System.Drawing.Point(0, 0);
            this._TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this._TopPanel.Name = "_TopPanel";
            this._TopPanel.Size = new System.Drawing.Size(400, 130);
            this._TopPanel.TabIndex = 7;
            // 
            // _MainSplitContainer
            // 
            this._MainSplitContainer.BackColor = System.Drawing.Color.Brown;
            this._MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._MainSplitContainer.Location = new System.Drawing.Point(0, 130);
            this._MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this._MainSplitContainer.Name = "_MainSplitContainer";
            // 
            // _MainSplitContainer.Panel1
            // 
            this._MainSplitContainer.Panel1.Controls.Add(this.label_playerTurn);
            this._MainSplitContainer.Panel1.Controls.Add(this.groupBox_claimRequest);
            // 
            // _MainSplitContainer.Panel2
            // 
            this._MainSplitContainer.Panel2.Controls.Add(this.groupBox_diceDisplay);
            this._MainSplitContainer.Panel2.Controls.Add(this.claimListView);
            this._MainSplitContainer.Panel2.Controls.Add(this.label_roundNumber);
            this._MainSplitContainer.Size = new System.Drawing.Size(400, 490);
            this._MainSplitContainer.SplitterDistance = 200;
            this._MainSplitContainer.SplitterWidth = 3;
            this._MainSplitContainer.TabIndex = 0;
            // 
            // label_playerTurn
            // 
            this.label_playerTurn.BackColor = System.Drawing.Color.RosyBrown;
            this.label_playerTurn.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_playerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerTurn.Location = new System.Drawing.Point(0, 0);
            this.label_playerTurn.Margin = new System.Windows.Forms.Padding(0);
            this.label_playerTurn.Name = "label_playerTurn";
            this.label_playerTurn.Size = new System.Drawing.Size(200, 30);
            this.label_playerTurn.TabIndex = 1;
            this.label_playerTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_claimRequest
            // 
            this.groupBox_claimRequest.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_claimRequest.Controls.Add(this.groupBox_resolution);
            this.groupBox_claimRequest.Controls.Add(this.callLiar);
            this.groupBox_claimRequest.Controls.Add(this.SubmitClaim);
            this.groupBox_claimRequest.Controls.Add(this.quantity);
            this.groupBox_claimRequest.Controls.Add(this.groupBox_diceValue);
            this.groupBox_claimRequest.Controls.Add(this.label_quantity);
            this.groupBox_claimRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_claimRequest.Location = new System.Drawing.Point(0, 0);
            this.groupBox_claimRequest.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_claimRequest.Name = "groupBox_claimRequest";
            this.groupBox_claimRequest.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_claimRequest.Size = new System.Drawing.Size(200, 490);
            this.groupBox_claimRequest.TabIndex = 0;
            this.groupBox_claimRequest.TabStop = false;
            this.groupBox_claimRequest.Visible = false;
            // 
            // groupBox_resolution
            // 
            this.groupBox_resolution.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_resolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_resolution.Controls.Add(this.computerDiceDisplay);
            this.groupBox_resolution.Controls.Add(this.falseClaim);
            this.groupBox_resolution.Controls.Add(this.trueClaim);
            this.groupBox_resolution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_resolution.Location = new System.Drawing.Point(0, 220);
            this.groupBox_resolution.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_resolution.Name = "groupBox_resolution";
            this.groupBox_resolution.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_resolution.Size = new System.Drawing.Size(200, 270);
            this.groupBox_resolution.TabIndex = 13;
            this.groupBox_resolution.TabStop = false;
            this.groupBox_resolution.Visible = false;
            // 
            // computerDiceDisplay
            // 
            this.computerDiceDisplay.BackColor = System.Drawing.Color.Firebrick;
            this.computerDiceDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.computerDiceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.computerDiceDisplay.HideSelection = false;
            this.computerDiceDisplay.Location = new System.Drawing.Point(2, 63);
            this.computerDiceDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.computerDiceDisplay.Name = "computerDiceDisplay";
            this.computerDiceDisplay.Size = new System.Drawing.Size(196, 205);
            this.computerDiceDisplay.TabIndex = 4;
            this.computerDiceDisplay.UseCompatibleStateImageBehavior = false;
            this.computerDiceDisplay.View = System.Windows.Forms.View.List;
            // 
            // falseClaim
            // 
            this.falseClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.falseClaim.Location = new System.Drawing.Point(10, 20);
            this.falseClaim.Margin = new System.Windows.Forms.Padding(2);
            this.falseClaim.Name = "falseClaim";
            this.falseClaim.Size = new System.Drawing.Size(85, 30);
            this.falseClaim.TabIndex = 3;
            this.falseClaim.Text = "False Claim";
            this.falseClaim.UseVisualStyleBackColor = true;
            this.falseClaim.Click += new System.EventHandler(this.falseClaim_Click);
            // 
            // trueClaim
            // 
            this.trueClaim.Location = new System.Drawing.Point(105, 20);
            this.trueClaim.Margin = new System.Windows.Forms.Padding(2);
            this.trueClaim.Name = "trueClaim";
            this.trueClaim.Size = new System.Drawing.Size(85, 30);
            this.trueClaim.TabIndex = 2;
            this.trueClaim.Text = "True Claim";
            this.trueClaim.UseVisualStyleBackColor = true;
            this.trueClaim.Click += new System.EventHandler(this.trueClaim_Click);
            // 
            // callLiar
            // 
            this.callLiar.BackColor = System.Drawing.Color.Yellow;
            this.callLiar.Enabled = false;
            this.callLiar.Location = new System.Drawing.Point(105, 180);
            this.callLiar.Margin = new System.Windows.Forms.Padding(2);
            this.callLiar.Name = "callLiar";
            this.callLiar.Size = new System.Drawing.Size(85, 30);
            this.callLiar.TabIndex = 12;
            this.callLiar.Text = "Call Liar";
            this.callLiar.UseVisualStyleBackColor = false;
            this.callLiar.Click += new System.EventHandler(this.CallLiar_Click);
            // 
            // SubmitClaim
            // 
            this.SubmitClaim.BackColor = System.Drawing.Color.Chartreuse;
            this.SubmitClaim.Location = new System.Drawing.Point(10, 180);
            this.SubmitClaim.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitClaim.Name = "SubmitClaim";
            this.SubmitClaim.Size = new System.Drawing.Size(85, 30);
            this.SubmitClaim.TabIndex = 11;
            this.SubmitClaim.Text = "Submit Claim";
            this.SubmitClaim.UseVisualStyleBackColor = false;
            this.SubmitClaim.Click += new System.EventHandler(this.SubmitClaim_Click);
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(120, 140);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(70, 26);
            this.quantity.TabIndex = 9;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.ValueChanged += new System.EventHandler(this.ValidateClaim);
            // 
            // groupBox_diceValue
            // 
            this.groupBox_diceValue.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_diceValue.Controls.Add(this.DiceValue5);
            this.groupBox_diceValue.Controls.Add(this.DiceValue6);
            this.groupBox_diceValue.Controls.Add(this.DiceValue4);
            this.groupBox_diceValue.Controls.Add(this.DiceValue2);
            this.groupBox_diceValue.Controls.Add(this.DiceValue3);
            this.groupBox_diceValue.Controls.Add(this.DiceValue1);
            this.groupBox_diceValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox_diceValue.Location = new System.Drawing.Point(10, 40);
            this.groupBox_diceValue.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_diceValue.Name = "groupBox_diceValue";
            this.groupBox_diceValue.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_diceValue.Size = new System.Drawing.Size(180, 90);
            this.groupBox_diceValue.TabIndex = 10;
            this.groupBox_diceValue.TabStop = false;
            this.groupBox_diceValue.Text = "Dice value";
            // 
            // DiceValue5
            // 
            this.DiceValue5.AutoSize = true;
            this.DiceValue5.Location = new System.Drawing.Point(70, 55);
            this.DiceValue5.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue5.Name = "DiceValue5";
            this.DiceValue5.Size = new System.Drawing.Size(31, 17);
            this.DiceValue5.TabIndex = 11;
            this.DiceValue5.Text = "5";
            this.DiceValue5.UseVisualStyleBackColor = true;
            this.DiceValue5.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // DiceValue6
            // 
            this.DiceValue6.AutoSize = true;
            this.DiceValue6.Location = new System.Drawing.Point(120, 55);
            this.DiceValue6.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue6.Name = "DiceValue6";
            this.DiceValue6.Size = new System.Drawing.Size(31, 17);
            this.DiceValue6.TabIndex = 10;
            this.DiceValue6.Text = "6";
            this.DiceValue6.UseVisualStyleBackColor = true;
            this.DiceValue6.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // DiceValue4
            // 
            this.DiceValue4.AutoSize = true;
            this.DiceValue4.Location = new System.Drawing.Point(20, 55);
            this.DiceValue4.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue4.Name = "DiceValue4";
            this.DiceValue4.Size = new System.Drawing.Size(31, 17);
            this.DiceValue4.TabIndex = 9;
            this.DiceValue4.Text = "4";
            this.DiceValue4.UseVisualStyleBackColor = true;
            this.DiceValue4.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // DiceValue2
            // 
            this.DiceValue2.AutoSize = true;
            this.DiceValue2.Location = new System.Drawing.Point(70, 25);
            this.DiceValue2.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue2.Name = "DiceValue2";
            this.DiceValue2.Size = new System.Drawing.Size(31, 17);
            this.DiceValue2.TabIndex = 8;
            this.DiceValue2.Text = "2";
            this.DiceValue2.UseVisualStyleBackColor = true;
            this.DiceValue2.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // DiceValue3
            // 
            this.DiceValue3.AutoSize = true;
            this.DiceValue3.Location = new System.Drawing.Point(120, 25);
            this.DiceValue3.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue3.Name = "DiceValue3";
            this.DiceValue3.Size = new System.Drawing.Size(31, 17);
            this.DiceValue3.TabIndex = 7;
            this.DiceValue3.Text = "3";
            this.DiceValue3.UseVisualStyleBackColor = true;
            this.DiceValue3.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // DiceValue1
            // 
            this.DiceValue1.AutoSize = true;
            this.DiceValue1.Checked = true;
            this.DiceValue1.Location = new System.Drawing.Point(20, 25);
            this.DiceValue1.Margin = new System.Windows.Forms.Padding(2);
            this.DiceValue1.Name = "DiceValue1";
            this.DiceValue1.Size = new System.Drawing.Size(31, 17);
            this.DiceValue1.TabIndex = 6;
            this.DiceValue1.TabStop = true;
            this.DiceValue1.Text = "1";
            this.DiceValue1.UseVisualStyleBackColor = true;
            this.DiceValue1.Click += new System.EventHandler(this.DiceValue_Click);
            // 
            // label_quantity
            // 
            this.label_quantity.BackColor = System.Drawing.Color.MistyRose;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_quantity.Location = new System.Drawing.Point(10, 140);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Padding = new System.Windows.Forms.Padding(3);
            this.label_quantity.Size = new System.Drawing.Size(100, 30);
            this.label_quantity.TabIndex = 8;
            this.label_quantity.Text = "Quantity";
            this.label_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_diceDisplay
            // 
            this.groupBox_diceDisplay.Controls.Add(this.listView_playerDiceCount);
            this.groupBox_diceDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_diceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox_diceDisplay.Location = new System.Drawing.Point(0, 390);
            this.groupBox_diceDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox_diceDisplay.Name = "groupBox_diceDisplay";
            this.groupBox_diceDisplay.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox_diceDisplay.Size = new System.Drawing.Size(197, 100);
            this.groupBox_diceDisplay.TabIndex = 2;
            this.groupBox_diceDisplay.TabStop = false;
            this.groupBox_diceDisplay.Text = "Player Dice Count";
            // 
            // listView_playerDiceCount
            // 
            this.listView_playerDiceCount.BackColor = System.Drawing.Color.Firebrick;
            this.listView_playerDiceCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_playerDiceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listView_playerDiceCount.HideSelection = false;
            this.listView_playerDiceCount.Location = new System.Drawing.Point(0, 19);
            this.listView_playerDiceCount.Margin = new System.Windows.Forms.Padding(0);
            this.listView_playerDiceCount.Name = "listView_playerDiceCount";
            this.listView_playerDiceCount.Size = new System.Drawing.Size(197, 81);
            this.listView_playerDiceCount.TabIndex = 0;
            this.listView_playerDiceCount.UseCompatibleStateImageBehavior = false;
            this.listView_playerDiceCount.View = System.Windows.Forms.View.List;
            // 
            // claimListView
            // 
            this.claimListView.BackColor = System.Drawing.Color.IndianRed;
            this.claimListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.claimListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.claimListView.HideSelection = false;
            this.claimListView.Location = new System.Drawing.Point(0, 30);
            this.claimListView.Margin = new System.Windows.Forms.Padding(0);
            this.claimListView.Name = "claimListView";
            this.claimListView.Size = new System.Drawing.Size(197, 460);
            this.claimListView.TabIndex = 1;
            this.claimListView.UseCompatibleStateImageBehavior = false;
            this.claimListView.View = System.Windows.Forms.View.List;
            // 
            // label_roundNumber
            // 
            this.label_roundNumber.BackColor = System.Drawing.Color.RosyBrown;
            this.label_roundNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_roundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_roundNumber.Location = new System.Drawing.Point(0, 0);
            this.label_roundNumber.Margin = new System.Windows.Forms.Padding(0);
            this.label_roundNumber.Name = "label_roundNumber";
            this.label_roundNumber.Size = new System.Drawing.Size(197, 30);
            this.label_roundNumber.TabIndex = 0;
            this.label_roundNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(400, 620);
            this.Controls.Add(this._MainSplitContainer);
            this.Controls.Add(this._TopPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartPage";
            this.ShowIcon = false;
            this.Text = "Liars Dice 1.0";
            this.TransparencyKey = System.Drawing.Color.Olive;
            ((System.ComponentModel.ISupportInitialize)(this.dicePerPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosition)).EndInit();
            this._TopPanel.ResumeLayout(false);
            this._MainSplitContainer.Panel1.ResumeLayout(false);
            this._MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._MainSplitContainer)).EndInit();
            this._MainSplitContainer.ResumeLayout(false);
            this.groupBox_claimRequest.ResumeLayout(false);
            this.groupBox_resolution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.groupBox_diceValue.ResumeLayout(false);
            this.groupBox_diceValue.PerformLayout();
            this.groupBox_diceDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dicePerPlayer;
        private System.Windows.Forms.NumericUpDown playerCount;
        private System.Windows.Forms.NumericUpDown myPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel _TopPanel;
        private System.Windows.Forms.SplitContainer _MainSplitContainer;
        private System.Windows.Forms.GroupBox groupBox_claimRequest;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.GroupBox groupBox_diceValue;
        private System.Windows.Forms.RadioButton DiceValue5;
        private System.Windows.Forms.RadioButton DiceValue6;
        private System.Windows.Forms.RadioButton DiceValue4;
        private System.Windows.Forms.RadioButton DiceValue2;
        private System.Windows.Forms.RadioButton DiceValue3;
        private System.Windows.Forms.RadioButton DiceValue1;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Button callLiar;
        private System.Windows.Forms.Button SubmitClaim;
        private System.Windows.Forms.Label label_roundNumber;
        private System.Windows.Forms.GroupBox groupBox_resolution;
        private System.Windows.Forms.Button falseClaim;
        private System.Windows.Forms.Button trueClaim;
        private System.Windows.Forms.Label label_playerTurn;
        private System.Windows.Forms.ListView claimListView;
        private System.Windows.Forms.GroupBox groupBox_diceDisplay;
        private System.Windows.Forms.ListView listView_playerDiceCount;
        private System.Windows.Forms.ListView computerDiceDisplay;
    }
}


namespace isaacEdit
{
    partial class isaacEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(isaacEditForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.OpenFileDialog();
            this.itemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemSprite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemCache = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemCoins = new System.Windows.Forms.NumericUpDown();
            this.itemBombs = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.NumericUpDown();
            this.itemCharges = new System.Windows.Forms.NumericUpDown();
            this.itemAchievement = new System.Windows.Forms.NumericUpDown();
            this.itemDevil = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.itemCooldown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonStore = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.itemHearts = new System.Windows.Forms.NumericUpDown();
            this.itemMaxHearts = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.itemBlackHearts = new System.Windows.Forms.NumericUpDown();
            this.itemSoulHearts = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.itemKeys = new System.Windows.Forms.NumericUpDown();
            this.itemType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAchievement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDevil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMaxHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBlackHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSoulHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // itemOpen
            // 
            this.itemOpen.FileName = "items.xml";
            resources.ApplyResources(this.itemOpen, "itemOpen");
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            resources.ApplyResources(this.itemList, "itemList");
            this.itemList.Name = "itemList";
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // itemName
            // 
            resources.ApplyResources(this.itemName, "itemName");
            this.itemName.Name = "itemName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // itemDescription
            // 
            resources.ApplyResources(this.itemDescription, "itemDescription");
            this.itemDescription.Name = "itemDescription";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // itemSprite
            // 
            resources.ApplyResources(this.itemSprite, "itemSprite");
            this.itemSprite.Name = "itemSprite";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // itemCache
            // 
            resources.ApplyResources(this.itemCache, "itemCache");
            this.itemCache.Name = "itemCache";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // itemCoins
            // 
            resources.ApplyResources(this.itemCoins, "itemCoins");
            this.itemCoins.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.itemCoins.Name = "itemCoins";
            // 
            // itemBombs
            // 
            resources.ApplyResources(this.itemBombs, "itemBombs");
            this.itemBombs.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.itemBombs.Name = "itemBombs";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // itemID
            // 
            resources.ApplyResources(this.itemID, "itemID");
            this.itemID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemID.Name = "itemID";
            // 
            // itemCharges
            // 
            resources.ApplyResources(this.itemCharges, "itemCharges");
            this.itemCharges.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.itemCharges.Name = "itemCharges";
            // 
            // itemAchievement
            // 
            resources.ApplyResources(this.itemAchievement, "itemAchievement");
            this.itemAchievement.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemAchievement.Name = "itemAchievement";
            // 
            // itemDevil
            // 
            resources.ApplyResources(this.itemDevil, "itemDevil");
            this.itemDevil.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.itemDevil.Name = "itemDevil";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // itemCooldown
            // 
            resources.ApplyResources(this.itemCooldown, "itemCooldown");
            this.itemCooldown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemCooldown.Name = "itemCooldown";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // buttonStore
            // 
            resources.ApplyResources(this.buttonStore, "buttonStore");
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // itemHearts
            // 
            resources.ApplyResources(this.itemHearts, "itemHearts");
            this.itemHearts.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.itemHearts.Name = "itemHearts";
            // 
            // itemMaxHearts
            // 
            resources.ApplyResources(this.itemMaxHearts, "itemMaxHearts");
            this.itemMaxHearts.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.itemMaxHearts.Name = "itemMaxHearts";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // itemBlackHearts
            // 
            resources.ApplyResources(this.itemBlackHearts, "itemBlackHearts");
            this.itemBlackHearts.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.itemBlackHearts.Name = "itemBlackHearts";
            // 
            // itemSoulHearts
            // 
            resources.ApplyResources(this.itemSoulHearts, "itemSoulHearts");
            this.itemSoulHearts.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.itemSoulHearts.Name = "itemSoulHearts";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // itemKeys
            // 
            resources.ApplyResources(this.itemKeys, "itemKeys");
            this.itemKeys.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.itemKeys.Name = "itemKeys";
            // 
            // itemType
            // 
            this.itemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.itemType, "itemType");
            this.itemType.FormattingEnabled = true;
            this.itemType.Items.AddRange(new object[] {
            resources.GetString("itemType.Items"),
            resources.GetString("itemType.Items1"),
            resources.GetString("itemType.Items2")});
            this.itemType.Name = "itemType";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // isaacEditForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.itemKeys);
            this.Controls.Add(this.itemSoulHearts);
            this.Controls.Add(this.itemBlackHearts);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itemMaxHearts);
            this.Controls.Add(this.itemHearts);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.itemCooldown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.itemDevil);
            this.Controls.Add(this.itemAchievement);
            this.Controls.Add(this.itemCharges);
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.itemBombs);
            this.Controls.Add(this.itemCoins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemCache);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemSprite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "isaacEditForm";
            this.Load += new System.EventHandler(this.isaacEditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAchievement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDevil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMaxHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBlackHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSoulHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog itemOpen;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemSprite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemCache;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown itemCoins;
        private System.Windows.Forms.NumericUpDown itemBombs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown itemID;
        private System.Windows.Forms.NumericUpDown itemCharges;
        private System.Windows.Forms.NumericUpDown itemAchievement;
        private System.Windows.Forms.NumericUpDown itemDevil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown itemCooldown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown itemHearts;
        private System.Windows.Forms.NumericUpDown itemMaxHearts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown itemBlackHearts;
        private System.Windows.Forms.NumericUpDown itemSoulHearts;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown itemKeys;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox itemType;
        private System.Windows.Forms.Label label17;
    }
}


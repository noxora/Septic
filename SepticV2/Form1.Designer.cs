namespace SepticV2
{
    partial class Form1
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
            this.AddButton1 = new System.Windows.Forms.Button();
            this.ruleNametb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RuleListLB = new System.Windows.Forms.ListBox();
            this.addDescripButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compareCB = new System.Windows.Forms.ComboBox();
            this.specificCB = new System.Windows.Forms.ComboBox();
            this.descripCB = new System.Windows.Forms.ComboBox();
            this.actiongb = new System.Windows.Forms.GroupBox();
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.sizeL = new System.Windows.Forms.Label();
            this.volumeTB = new System.Windows.Forms.TextBox();
            this.volumeL = new System.Windows.Forms.Label();
            this.alertL = new System.Windows.Forms.Label();
            this.alertTB = new System.Windows.Forms.TextBox();
            this.actionColorButton = new System.Windows.Forms.Button();
            this.actionCB = new System.Windows.Forms.ComboBox();
            this.addActionButton = new System.Windows.Forms.Button();
            this.descripLB = new System.Windows.Forms.ListBox();
            this.actionCD = new System.Windows.Forms.ColorDialog();
            this.actionLB = new System.Windows.Forms.ListBox();
            this.testButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.descripRemoveButton = new System.Windows.Forms.Button();
            this.removeActionButton = new System.Windows.Forms.Button();
            this.ruleRemoveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.actiongb.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(898, 45);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(114, 28);
            this.AddButton1.TabIndex = 0;
            this.AddButton1.Text = "AddRule";
            this.AddButton1.UseVisualStyleBackColor = true;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // ruleNametb
            // 
            this.ruleNametb.Location = new System.Drawing.Point(898, 17);
            this.ruleNametb.Name = "ruleNametb";
            this.ruleNametb.Size = new System.Drawing.Size(100, 22);
            this.ruleNametb.TabIndex = 2;
            // 
            // RuleListLB
            // 
            this.RuleListLB.FormattingEnabled = true;
            this.RuleListLB.ItemHeight = 16;
            this.RuleListLB.Location = new System.Drawing.Point(12, 17);
            this.RuleListLB.Name = "RuleListLB";
            this.RuleListLB.Size = new System.Drawing.Size(516, 132);
            this.RuleListLB.TabIndex = 3;
            this.RuleListLB.SelectedIndexChanged += new System.EventHandler(this.RuleListLB_SelectedIndexChanged);
            // 
            // addDescripButton
            // 
            this.addDescripButton.Location = new System.Drawing.Point(32, 115);
            this.addDescripButton.Name = "addDescripButton";
            this.addDescripButton.Size = new System.Drawing.Size(86, 29);
            this.addDescripButton.TabIndex = 4;
            this.addDescripButton.Text = "Add";
            this.addDescripButton.UseVisualStyleBackColor = true;
            this.addDescripButton.Click += new System.EventHandler(this.addDescripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compareCB);
            this.groupBox1.Controls.Add(this.specificCB);
            this.groupBox1.Controls.Add(this.descripCB);
            this.groupBox1.Controls.Add(this.addDescripButton);
            this.groupBox1.Location = new System.Drawing.Point(566, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // compareCB
            // 
            this.compareCB.FormattingEnabled = true;
            this.compareCB.Items.AddRange(new object[] {
            "[Comparator]",
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.compareCB.Location = new System.Drawing.Point(3, 48);
            this.compareCB.Name = "compareCB";
            this.compareCB.Size = new System.Drawing.Size(121, 24);
            this.compareCB.TabIndex = 7;
            this.compareCB.SelectedIndexChanged += new System.EventHandler(this.compareCB_SelectedIndexChanged);
            // 
            // specificCB
            // 
            this.specificCB.FormattingEnabled = true;
            this.specificCB.Location = new System.Drawing.Point(3, 85);
            this.specificCB.Name = "specificCB";
            this.specificCB.Size = new System.Drawing.Size(121, 24);
            this.specificCB.TabIndex = 6;
            // 
            // descripCB
            // 
            this.descripCB.FormattingEnabled = true;
            this.descripCB.Items.AddRange(new object[] {
            "Item Level",
            "Drop Level",
            "Quality",
            "Rarity",
            "Class",
            "Sockets",
            "Linked Sockets",
            "Socket Group",
            "Height",
            "Width"});
            this.descripCB.Location = new System.Drawing.Point(3, 18);
            this.descripCB.Name = "descripCB";
            this.descripCB.Size = new System.Drawing.Size(121, 24);
            this.descripCB.TabIndex = 5;
            this.descripCB.SelectedIndexChanged += new System.EventHandler(this.descripCB_SelectedIndexChanged);
            // 
            // actiongb
            // 
            this.actiongb.Controls.Add(this.sizeTB);
            this.actiongb.Controls.Add(this.sizeL);
            this.actiongb.Controls.Add(this.volumeTB);
            this.actiongb.Controls.Add(this.volumeL);
            this.actiongb.Controls.Add(this.alertL);
            this.actiongb.Controls.Add(this.alertTB);
            this.actiongb.Controls.Add(this.actionColorButton);
            this.actiongb.Controls.Add(this.actionCB);
            this.actiongb.Controls.Add(this.addActionButton);
            this.actiongb.Location = new System.Drawing.Point(722, 17);
            this.actiongb.Name = "actiongb";
            this.actiongb.Size = new System.Drawing.Size(132, 150);
            this.actiongb.TabIndex = 6;
            this.actiongb.TabStop = false;
            this.actiongb.Text = "Action";
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(77, 57);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(38, 22);
            this.sizeTB.TabIndex = 8;
            // 
            // sizeL
            // 
            this.sizeL.AutoSize = true;
            this.sizeL.Location = new System.Drawing.Point(32, 60);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(39, 17);
            this.sizeL.TabIndex = 7;
            this.sizeL.Text = "Size:";
            // 
            // volumeTB
            // 
            this.volumeTB.Location = new System.Drawing.Point(77, 85);
            this.volumeTB.Name = "volumeTB";
            this.volumeTB.Size = new System.Drawing.Size(37, 22);
            this.volumeTB.TabIndex = 6;
            // 
            // volumeL
            // 
            this.volumeL.AutoSize = true;
            this.volumeL.Location = new System.Drawing.Point(12, 88);
            this.volumeL.Name = "volumeL";
            this.volumeL.Size = new System.Drawing.Size(59, 17);
            this.volumeL.TabIndex = 5;
            this.volumeL.Text = "Volume:";
            // 
            // alertL
            // 
            this.alertL.AutoSize = true;
            this.alertL.Location = new System.Drawing.Point(18, 60);
            this.alertL.Name = "alertL";
            this.alertL.Size = new System.Drawing.Size(53, 17);
            this.alertL.TabIndex = 4;
            this.alertL.Text = "Alert #:";
            // 
            // alertTB
            // 
            this.alertTB.Location = new System.Drawing.Point(77, 57);
            this.alertTB.Name = "alertTB";
            this.alertTB.Size = new System.Drawing.Size(37, 22);
            this.alertTB.TabIndex = 3;
            // 
            // actionColorButton
            // 
            this.actionColorButton.Location = new System.Drawing.Point(33, 61);
            this.actionColorButton.Name = "actionColorButton";
            this.actionColorButton.Size = new System.Drawing.Size(68, 24);
            this.actionColorButton.TabIndex = 2;
            this.actionColorButton.Text = "Color...";
            this.actionColorButton.UseVisualStyleBackColor = true;
            this.actionColorButton.Click += new System.EventHandler(this.actionColorButton_Click);
            // 
            // actionCB
            // 
            this.actionCB.FormattingEnabled = true;
            this.actionCB.Items.AddRange(new object[] {
            "Set Border Color",
            "Set Text Color",
            "Set Background Color",
            "Play Alert Sound",
            "Set Font Size"});
            this.actionCB.Location = new System.Drawing.Point(15, 24);
            this.actionCB.Name = "actionCB";
            this.actionCB.Size = new System.Drawing.Size(100, 24);
            this.actionCB.TabIndex = 1;
            this.actionCB.SelectedIndexChanged += new System.EventHandler(this.actionCB_SelectedIndexChanged);
            // 
            // addActionButton
            // 
            this.addActionButton.Location = new System.Drawing.Point(30, 115);
            this.addActionButton.Name = "addActionButton";
            this.addActionButton.Size = new System.Drawing.Size(72, 28);
            this.addActionButton.TabIndex = 0;
            this.addActionButton.Text = "Add";
            this.addActionButton.UseVisualStyleBackColor = true;
            this.addActionButton.Click += new System.EventHandler(this.addActionButton_Click);
            // 
            // descripLB
            // 
            this.descripLB.FormattingEnabled = true;
            this.descripLB.ItemHeight = 16;
            this.descripLB.Location = new System.Drawing.Point(12, 190);
            this.descripLB.Name = "descripLB";
            this.descripLB.Size = new System.Drawing.Size(516, 100);
            this.descripLB.TabIndex = 7;
            // 
            // actionLB
            // 
            this.actionLB.FormattingEnabled = true;
            this.actionLB.ItemHeight = 16;
            this.actionLB.Location = new System.Drawing.Point(13, 335);
            this.actionLB.Name = "actionLB";
            this.actionLB.Size = new System.Drawing.Size(515, 100);
            this.actionLB.TabIndex = 8;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(898, 320);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(81, 44);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "View Sample";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(898, 378);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 42);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Filter";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // descripRemoveButton
            // 
            this.descripRemoveButton.Location = new System.Drawing.Point(441, 296);
            this.descripRemoveButton.Name = "descripRemoveButton";
            this.descripRemoveButton.Size = new System.Drawing.Size(86, 26);
            this.descripRemoveButton.TabIndex = 11;
            this.descripRemoveButton.Text = "Remove";
            this.descripRemoveButton.UseVisualStyleBackColor = true;
            this.descripRemoveButton.Click += new System.EventHandler(this.descripRemoveButton_Click);
            // 
            // removeActionButton
            // 
            this.removeActionButton.Location = new System.Drawing.Point(441, 441);
            this.removeActionButton.Name = "removeActionButton";
            this.removeActionButton.Size = new System.Drawing.Size(82, 24);
            this.removeActionButton.TabIndex = 12;
            this.removeActionButton.Text = "Remove";
            this.removeActionButton.UseVisualStyleBackColor = true;
            this.removeActionButton.Click += new System.EventHandler(this.removeActionButton_Click);
            // 
            // ruleRemoveButton
            // 
            this.ruleRemoveButton.Location = new System.Drawing.Point(441, 155);
            this.ruleRemoveButton.Name = "ruleRemoveButton";
            this.ruleRemoveButton.Size = new System.Drawing.Size(85, 26);
            this.ruleRemoveButton.TabIndex = 13;
            this.ruleRemoveButton.Text = "Remove";
            this.ruleRemoveButton.UseVisualStyleBackColor = true;
            this.ruleRemoveButton.Click += new System.EventHandler(this.ruleRemoveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 477);
            this.Controls.Add(this.ruleRemoveButton);
            this.Controls.Add(this.removeActionButton);
            this.Controls.Add(this.descripRemoveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.actionLB);
            this.Controls.Add(this.descripLB);
            this.Controls.Add(this.actiongb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RuleListLB);
            this.Controls.Add(this.ruleNametb);
            this.Controls.Add(this.AddButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.actiongb.ResumeLayout(false);
            this.actiongb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.TextBox ruleNametb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        protected internal System.Windows.Forms.ListBox RuleListLB;
        private System.Windows.Forms.Button addDescripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox descripCB;
        private System.Windows.Forms.ComboBox specificCB;
        private System.Windows.Forms.GroupBox actiongb;
        private System.Windows.Forms.Button addActionButton;
        private System.Windows.Forms.ComboBox compareCB;
        private System.Windows.Forms.ListBox descripLB;
        private System.Windows.Forms.ComboBox actionCB;
        private System.Windows.Forms.ColorDialog actionCD;
        private System.Windows.Forms.Button actionColorButton;
        private System.Windows.Forms.ListBox actionLB;
        private System.Windows.Forms.Label alertL;
        private System.Windows.Forms.TextBox alertTB;
        private System.Windows.Forms.TextBox volumeTB;
        private System.Windows.Forms.Label volumeL;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.Label sizeL;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button descripRemoveButton;
        private System.Windows.Forms.Button removeActionButton;
        private System.Windows.Forms.Button ruleRemoveButton;
    }
}


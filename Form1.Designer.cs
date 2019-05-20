namespace CompArchitecture
{
    partial class Parent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secondTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bimodalPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinedBranchPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agreePredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalBranchPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalBranchPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YAGSPredictor = new System.Windows.Forms.ToolStripMenuItem();
            this.selectorPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSharePredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pentium4Predictor = new System.Windows.Forms.ToolStripMenuItem();
            this.AthalonArchPredictor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secondTabToolStripMenuItem,
            this.bimodalPredictorToolStripMenuItem,
            this.combinedBranchPredictorToolStripMenuItem,
            this.agreePredictorToolStripMenuItem,
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem,
            this.LocalBranchPredictorToolStripMenuItem,
            this.globalBranchPredictorToolStripMenuItem,
            this.YAGSPredictor,
            this.selectorPredictorToolStripMenuItem,
            this.gSharePredictorToolStripMenuItem,
            this.Pentium4Predictor,
            this.AthalonArchPredictor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1297, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked_1);
            // 
            // secondTabToolStripMenuItem
            // 
            this.secondTabToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.secondTabToolStripMenuItem.Name = "secondTabToolStripMenuItem";
            this.secondTabToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.secondTabToolStripMenuItem.Text = "Static Predictor";
            this.secondTabToolStripMenuItem.Click += new System.EventHandler(this.SecondTabToolStripMenuItem_Click);
            // 
            // bimodalPredictorToolStripMenuItem
            // 
            this.bimodalPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.bimodalPredictorToolStripMenuItem.Name = "bimodalPredictorToolStripMenuItem";
            this.bimodalPredictorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.bimodalPredictorToolStripMenuItem.Text = "Bimodal Predictor";
            this.bimodalPredictorToolStripMenuItem.Click += new System.EventHandler(this.BimodalPredictorToolStripMenuItem_Click);
            // 
            // combinedBranchPredictorToolStripMenuItem
            // 
            this.combinedBranchPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.combinedBranchPredictorToolStripMenuItem.Name = "combinedBranchPredictorToolStripMenuItem";
            this.combinedBranchPredictorToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.combinedBranchPredictorToolStripMenuItem.Text = "Combined  Predictor";
            this.combinedBranchPredictorToolStripMenuItem.Click += new System.EventHandler(this.CombinedBranchPredictorToolStripMenuItem_Click);
            // 
            // agreePredictorToolStripMenuItem
            // 
            this.agreePredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.agreePredictorToolStripMenuItem.Name = "agreePredictorToolStripMenuItem";
            this.agreePredictorToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.agreePredictorToolStripMenuItem.Text = "Agree Predictor";
            this.agreePredictorToolStripMenuItem.Click += new System.EventHandler(this.AgreePredictorToolStripMenuItem_Click);
            // 
            // twoLevelAdaptiveBranchPredictorToolStripMenuItem
            // 
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem.Name = "twoLevelAdaptiveBranchPredictorToolStripMenuItem";
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem.Text = "Two Level AdaptivePredictor";
            this.twoLevelAdaptiveBranchPredictorToolStripMenuItem.Click += new System.EventHandler(this.TwoLevelAdaptiveBranchPredictorToolStripMenuItem_Click);
            // 
            // LocalBranchPredictorToolStripMenuItem
            // 
            this.LocalBranchPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.LocalBranchPredictorToolStripMenuItem.Name = "LocalBranchPredictorToolStripMenuItem";
            this.LocalBranchPredictorToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.LocalBranchPredictorToolStripMenuItem.Text = "Local Predictor";
            this.LocalBranchPredictorToolStripMenuItem.Click += new System.EventHandler(this.LocalBranchPredictorToolStripMenuItem_Click);
            // 
            // globalBranchPredictorToolStripMenuItem
            // 
            this.globalBranchPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.globalBranchPredictorToolStripMenuItem.Name = "globalBranchPredictorToolStripMenuItem";
            this.globalBranchPredictorToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.globalBranchPredictorToolStripMenuItem.Text = "Global  Predictor";
            this.globalBranchPredictorToolStripMenuItem.Click += new System.EventHandler(this.GlobalBranchPredictorToolStripMenuItem_Click);
            // 
            // YAGSPredictor
            // 
            this.YAGSPredictor.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.YAGSPredictor.Name = "YAGSPredictor";
            this.YAGSPredictor.Size = new System.Drawing.Size(82, 20);
            this.YAGSPredictor.Text = "YAGS predictor";
            this.YAGSPredictor.Click += new System.EventHandler(this.YAGSPredictorToolStripMenuItem_Click);
            // 
            // selectorPredictorToolStripMenuItem
            // 
            this.selectorPredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.selectorPredictorToolStripMenuItem.Name = "selectorPredictorToolStripMenuItem";
            this.selectorPredictorToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.selectorPredictorToolStripMenuItem.Text = "Selector Predictor";
            this.selectorPredictorToolStripMenuItem.Click += new System.EventHandler(this.SelectorPredictorToolStripMenuItem_Click);
            // 
            // gSharePredictorToolStripMenuItem
            // 
            this.gSharePredictorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gSharePredictorToolStripMenuItem.Name = "gSharePredictorToolStripMenuItem";
            this.gSharePredictorToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.gSharePredictorToolStripMenuItem.Text = "gShare Predictor";
            this.gSharePredictorToolStripMenuItem.Click += new System.EventHandler(this.GSharePredictorToolStripMenuItem_Click);
            // 
            // Pentium4Predictor
            // 
            this.Pentium4Predictor.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.Pentium4Predictor.Name = "Pentium4Predictor";
            this.Pentium4Predictor.Size = new System.Drawing.Size(101, 20);
            this.Pentium4Predictor.Text = "Pentium4 predictor";
            this.Pentium4Predictor.Click += new System.EventHandler(this.Pentium4Predictor_Click);
            // 
            // AthalonArchPredictor
            // 
            this.AthalonArchPredictor.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.AthalonArchPredictor.Name = "AthalonArchPredictor";
            this.AthalonArchPredictor.Size = new System.Drawing.Size(123, 20);
            this.AthalonArchPredictor.Text = "Athlon Archict. Predictor";
            this.AthalonArchPredictor.Click += new System.EventHandler(this.AthalonArchPredictor_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Parent";
            this.Text = "MainTab";
            this.Load += new System.EventHandler(this.Parent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secondTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bimodalPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinedBranchPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agreePredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoLevelAdaptiveBranchPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalBranchPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalBranchPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YAGSPredictor;
        private System.Windows.Forms.ToolStripMenuItem selectorPredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gSharePredictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pentium4Predictor;
        private System.Windows.Forms.ToolStripMenuItem AthalonArchPredictor;
    }
}


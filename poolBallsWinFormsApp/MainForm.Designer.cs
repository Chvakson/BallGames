namespace PoolBallsWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rightGreenBallLabel = new System.Windows.Forms.Label();
            this.upRedBallLabel = new System.Windows.Forms.Label();
            this.upGreenBallLabel = new System.Windows.Forms.Label();
            this.downGreenBallLabel = new System.Windows.Forms.Label();
            this.leftGreenBallLabel = new System.Windows.Forms.Label();
            this.leftRedBallLabel = new System.Windows.Forms.Label();
            this.rightRedBallLabel = new System.Windows.Forms.Label();
            this.downRedBallLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(57, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createToolStripButton
            // 
            this.createToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripButton.Image")));
            this.createToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStripButton.Name = "createToolStripButton";
            this.createToolStripButton.Size = new System.Drawing.Size(54, 22);
            this.createToolStripButton.Text = "Создать";
            this.createToolStripButton.Click += new System.EventHandler(this.createToolStripButton_Click);
            // 
            // rightGreenBallLabel
            // 
            this.rightGreenBallLabel.AutoSize = true;
            this.rightGreenBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightGreenBallLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rightGreenBallLabel.Location = new System.Drawing.Point(658, 400);
            this.rightGreenBallLabel.Name = "rightGreenBallLabel";
            this.rightGreenBallLabel.Size = new System.Drawing.Size(14, 15);
            this.rightGreenBallLabel.TabIndex = 1;
            this.rightGreenBallLabel.Text = "0";
            // 
            // upRedBallLabel
            // 
            this.upRedBallLabel.AutoSize = true;
            this.upRedBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upRedBallLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.upRedBallLabel.Location = new System.Drawing.Point(326, 15);
            this.upRedBallLabel.Name = "upRedBallLabel";
            this.upRedBallLabel.Size = new System.Drawing.Size(14, 15);
            this.upRedBallLabel.TabIndex = 6;
            this.upRedBallLabel.Text = "0";
            // 
            // upGreenBallLabel
            // 
            this.upGreenBallLabel.AutoSize = true;
            this.upGreenBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.upGreenBallLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.upGreenBallLabel.Location = new System.Drawing.Point(326, 0);
            this.upGreenBallLabel.Name = "upGreenBallLabel";
            this.upGreenBallLabel.Size = new System.Drawing.Size(14, 15);
            this.upGreenBallLabel.TabIndex = 9;
            this.upGreenBallLabel.Text = "0";
            // 
            // downGreenBallLabel
            // 
            this.downGreenBallLabel.AutoSize = true;
            this.downGreenBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downGreenBallLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.downGreenBallLabel.Location = new System.Drawing.Point(326, 731);
            this.downGreenBallLabel.Name = "downGreenBallLabel";
            this.downGreenBallLabel.Size = new System.Drawing.Size(14, 15);
            this.downGreenBallLabel.TabIndex = 10;
            this.downGreenBallLabel.Text = "0";
            // 
            // leftGreenBallLabel
            // 
            this.leftGreenBallLabel.AutoSize = true;
            this.leftGreenBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftGreenBallLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.leftGreenBallLabel.Location = new System.Drawing.Point(0, 401);
            this.leftGreenBallLabel.Name = "leftGreenBallLabel";
            this.leftGreenBallLabel.Size = new System.Drawing.Size(14, 15);
            this.leftGreenBallLabel.TabIndex = 11;
            this.leftGreenBallLabel.Text = "0";
            // 
            // leftRedBallLabel
            // 
            this.leftRedBallLabel.AutoSize = true;
            this.leftRedBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftRedBallLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.leftRedBallLabel.Location = new System.Drawing.Point(0, 415);
            this.leftRedBallLabel.Name = "leftRedBallLabel";
            this.leftRedBallLabel.Size = new System.Drawing.Size(14, 15);
            this.leftRedBallLabel.TabIndex = 12;
            this.leftRedBallLabel.Text = "0";
            // 
            // rightRedBallLabel
            // 
            this.rightRedBallLabel.AutoSize = true;
            this.rightRedBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightRedBallLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.rightRedBallLabel.Location = new System.Drawing.Point(658, 415);
            this.rightRedBallLabel.Name = "rightRedBallLabel";
            this.rightRedBallLabel.Size = new System.Drawing.Size(14, 15);
            this.rightRedBallLabel.TabIndex = 13;
            this.rightRedBallLabel.Text = "0";
            // 
            // downRedBallLabel
            // 
            this.downRedBallLabel.AutoSize = true;
            this.downRedBallLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downRedBallLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.downRedBallLabel.Location = new System.Drawing.Point(326, 746);
            this.downRedBallLabel.Name = "downRedBallLabel";
            this.downRedBallLabel.Size = new System.Drawing.Size(14, 15);
            this.downRedBallLabel.TabIndex = 14;
            this.downRedBallLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.rightGreenBallLabel);
            this.Controls.Add(this.leftGreenBallLabel);
            this.Controls.Add(this.upGreenBallLabel);
            this.Controls.Add(this.downGreenBallLabel);
            this.Controls.Add(this.rightRedBallLabel);
            this.Controls.Add(this.leftRedBallLabel);
            this.Controls.Add(this.upRedBallLabel);
            this.Controls.Add(this.downRedBallLabel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton createToolStripButton;
        private Label rightGreenBallLabel;
        private Label upRedBallLabel;
        private Label upGreenBallLabel;
        private Label downGreenBallLabel;
        private Label leftGreenBallLabel;
        private Label leftRedBallLabel;
        private Label rightRedBallLabel;
        private Label downRedBallLabel;
    }
}
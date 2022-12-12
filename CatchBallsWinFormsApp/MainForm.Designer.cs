namespace CatchBallsWinFormsApp
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
            this.createBallsStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.restartToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.countBallsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBallsStripButton,
            this.stopToolStripButton,
            this.restartToolStripButton,
            this.countBallsToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createBallsStripButton
            // 
            this.createBallsStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createBallsStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createBallsStripButton.Image")));
            this.createBallsStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createBallsStripButton.Name = "createBallsStripButton";
            this.createBallsStripButton.Size = new System.Drawing.Size(54, 22);
            this.createBallsStripButton.Text = "Создать";
            this.createBallsStripButton.Click += new System.EventHandler(this.createBallsStripButton_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.stopToolStripButton.Text = "Остановить";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
            // 
            // restartToolStripButton
            // 
            this.restartToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.restartToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("restartToolStripButton.Image")));
            this.restartToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.restartToolStripButton.Name = "restartToolStripButton";
            this.restartToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.restartToolStripButton.Text = "Рестарт";
            this.restartToolStripButton.Click += new System.EventHandler(this.restartToolStripButton_Click);
            // 
            // countBallsToolStripLabel
            // 
            this.countBallsToolStripLabel.Margin = new System.Windows.Forms.Padding(60, 1, 0, 2);
            this.countBallsToolStripLabel.Name = "countBallsToolStripLabel";
            this.countBallsToolStripLabel.Size = new System.Drawing.Size(124, 22);
            this.countBallsToolStripLabel.Text = "Поймано шариков: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton createBallsStripButton;
        private ToolStripButton stopToolStripButton;
        private ToolStripButton restartToolStripButton;
        private ToolStripLabel countBallsToolStripLabel;
    }
}
namespace Grid_BottomNewItemRow
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
            this.gridSplitContainerDescendant1 = new Grid_BottomNewItemRow.GridSplitContainerDescendant();
            this.gridSplitContainerDescendant1Grid = new Grid_BottomNewItemRow.GridControlDescendant();
            this.gridSplitContainerDescendant1View = new Grid_BottomNewItemRow.GridViewDescendant();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1)).BeginInit();
            this.gridSplitContainerDescendant1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainerDescendant1
            // 
            this.gridSplitContainerDescendant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainerDescendant1.Grid = this.gridSplitContainerDescendant1Grid;
            this.gridSplitContainerDescendant1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainerDescendant1.Name = "gridSplitContainerDescendant1";
            this.gridSplitContainerDescendant1.Panel1.Controls.Add(this.gridSplitContainerDescendant1Grid);
            this.gridSplitContainerDescendant1.Panel1.Text = "Panel1";
            this.gridSplitContainerDescendant1.Panel2.Text = "Panel2";
            this.gridSplitContainerDescendant1.Size = new System.Drawing.Size(408, 432);
            this.gridSplitContainerDescendant1.TabIndex = 0;
            this.gridSplitContainerDescendant1.Text = "gridSplitContainerDescendant1";
            // 
            // gridSplitContainerDescendant1Grid
            // 
            this.gridSplitContainerDescendant1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainerDescendant1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainerDescendant1Grid.MainView = this.gridSplitContainerDescendant1View;
            this.gridSplitContainerDescendant1Grid.Name = "gridSplitContainerDescendant1Grid";
            this.gridSplitContainerDescendant1Grid.Size = new System.Drawing.Size(408, 432);
            this.gridSplitContainerDescendant1Grid.TabIndex = 0;
            this.gridSplitContainerDescendant1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainerDescendant1View});
            // 
            // gridSplitContainerDescendant1View
            // 
            this.gridSplitContainerDescendant1View.GridControl = this.gridSplitContainerDescendant1Grid;
            this.gridSplitContainerDescendant1View.Name = "gridSplitContainerDescendant1View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 432);
            this.Controls.Add(this.gridSplitContainerDescendant1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1)).EndInit();
            this.gridSplitContainerDescendant1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainerDescendant1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridSplitContainerDescendant gridSplitContainerDescendant1;
        private GridControlDescendant gridSplitContainerDescendant1Grid;
        private GridViewDescendant gridSplitContainerDescendant1View;






    }
}


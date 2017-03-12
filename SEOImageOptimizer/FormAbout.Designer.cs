namespace SEOImageOptimizer
{
	partial class FormAbout
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
			this.label1 = new System.Windows.Forms.Label();
			this._LinkLabelKawaii = new System.Windows.Forms.LinkLabel();
			this._ButtonClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a free application. If you like anime, check out my anime-related blog.";
			// 
			// _LinkLabelKawaii
			// 
			this._LinkLabelKawaii.AutoSize = true;
			this._LinkLabelKawaii.Location = new System.Drawing.Point(12, 32);
			this._LinkLabelKawaii.Name = "_LinkLabelKawaii";
			this._LinkLabelKawaii.Size = new System.Drawing.Size(124, 13);
			this._LinkLabelKawaii.TabIndex = 2;
			this._LinkLabelKawaii.TabStop = true;
			this._LinkLabelKawaii.Text = "http://kawaii-mobile.com";
			this._LinkLabelKawaii.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._LinkLabelKawaii_LinkClicked);
			// 
			// _ButtonClose
			// 
			this._ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._ButtonClose.Location = new System.Drawing.Point(345, 89);
			this._ButtonClose.Name = "_ButtonClose";
			this._ButtonClose.Size = new System.Drawing.Size(75, 23);
			this._ButtonClose.TabIndex = 5;
			this._ButtonClose.Text = "Close";
			this._ButtonClose.UseVisualStyleBackColor = true;
			// 
			// FormAbout
			// 
			this.AcceptButton = this._ButtonClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._ButtonClose;
			this.ClientSize = new System.Drawing.Size(432, 124);
			this.Controls.Add(this._ButtonClose);
			this.Controls.Add(this._LinkLabelKawaii);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel _LinkLabelKawaii;
		private System.Windows.Forms.Button _ButtonClose;
	}
}
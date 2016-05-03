using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEOImageOptimizer
{
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
		}

		void _OpenURL(string link)
		{
			try
			{
				System.Diagnostics.Process.Start(link);
			}
			catch (Exception)
			{							
			}
		}

		private void _LinkLabelFossLook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			_OpenURL(_LinkLabelFossLook.Text);
		}

		private void _LinkLabelKawaii_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			_OpenURL(_LinkLabelKawaii.Text);
		}
	}
}

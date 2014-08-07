using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breadcrumbs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;

			breadCrumbs.Push(tabControl1.SelectedTab);
		}

		Stack<TabPage> breadCrumbs = new Stack<TabPage>();

		private void SwitchTabs(TabPage page)
		{
			breadCrumbs.Push(tabControl1.SelectedTab);
			tabControl1.SelectedTab = page;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SwitchTabs(tabPage1);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SwitchTabs(tabPage2);
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SwitchTabs(tabPage3);
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if(breadCrumbs.Count == 0)
				return;

			var lastTab = breadCrumbs.Pop();
			tabControl1.SelectedTab = lastTab;
		}
	}
}

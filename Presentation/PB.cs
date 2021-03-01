using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class PB : Form
	{
		public PB()
		{
			InitializeComponent();
		}

		private void Close(object sender, EventArgs e)
		{
			Close();
		}

		private void Min(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void TrayIn(object sender, EventArgs e)
		{
			this.Hide();
			notifyIcon1.ShowBalloonTip(5000);
		}

		private void TrayOut(object sender, EventArgs e)
		{
			this.Show();
		}

		Point point;

		private void MMouseDown(object sender, MouseEventArgs Mouse)
		{
			point = new Point(Mouse.X, Mouse.Y);
		}

		private void MMouseMove(object sender, MouseEventArgs Mouse)
		{
			if (Mouse.Button == MouseButtons.Left)
			{
				this.Left += Mouse.X - point.X;
				this.Top += Mouse.Y - point.Y;
			}
		}
		
		private void Button4_Click(object sender, EventArgs e)
		{
			button4.Enabled = false;
			for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
			{
					progressBar1.Value = i;
			}
			button4.Enabled = true;
		}
	}
}

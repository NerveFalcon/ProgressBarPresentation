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

namespace ProgressBar
{
	public partial class Form3 : Form
	{
		private readonly string pathToJson = 
					$"{Environment.CurrentDirectory}\\Data.json";
		private string[] Data;
		private readonly Random random = new Random();

		public Form3()
		{
			InitializeComponent();
		}

		private void Form_Load(object sender, EventArgs e)
		{
			try
			{
				var data = File.ReadAllText(pathToJson);
				Data = JsonConvert.DeserializeObject<string[]>(data);
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}
			finally
			{
				if (Data == null)
				{
					MessageBox.Show("Пустой файл с данными");
					Application.Exit();
				}
				else if (Data.Length == 0)
				{
					MessageBox.Show("Отсутствуют строки");
					Application.Exit();
				}
			}
		}

		private void Close(object sender, EventArgs e)
		{
			Application.Exit();
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
		
		private async void Button4_Click(object sender, EventArgs e)
		{
			button4.Enabled = false;
			float range = progressBar1.Maximum - progressBar1.Minimum;
			string str = title.Text;
			await Task.Run(() =>
			{
				for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
				{
					this.Invoke(new Action(() =>
					{
						progressBar1.Value = i;
						title.Text = str + " "
									+ ((progressBar1.Value - progressBar1.Minimum)
									/ range)
									.ToString("##0.00%");
					}));
					Thread.Sleep(100);
				}
			});
			MessageBox.Show(Data[random.Next(Data.Length)] + "!");
			progressBar1.Value = 0;
			title.Text = str;
			button4.Enabled = true;
		}
	}
}

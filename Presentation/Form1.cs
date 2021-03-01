using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Header header = new Header();
			header.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			PB PB = new PB();
			PB.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			MsgForm msgForm = new MsgForm();
			msgForm.Show();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			SleepForm sleepForm = new SleepForm();
			sleepForm.Show();
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			SndForm sndForm = new SndForm();
			sndForm.Show();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			TitleForm titleForm = new TitleForm();
			titleForm.Show();
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			JsonForm jsonForm = new JsonForm();
			jsonForm.Show();
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			JsonWForm jsonWForm = new JsonWForm();
			jsonWForm.Show();
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			JsonEForm jsonEForm = new JsonEForm();
			jsonEForm.Show();
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			JsonEAForm jsonEAForm = new JsonEAForm();
			jsonEAForm.Show();
		}
	}
}

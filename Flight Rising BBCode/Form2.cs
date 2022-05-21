using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Rising_BBCode
{
	public partial class Form2 : Form
	{
		Dragon dragons = new Dragon();
		public Form2()
		{
			InitializeComponent();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtDragonID.Text = "";
			lblCode.Text = "";
		}

		private void btnAvatar_Click(object sender, EventArgs e)
		{
			string id = txtDragonID.Text.TrimEnd(' ');
			string batchNum = GetBatchNumber(id);
			

			string imgLink = GetImgLink("portraits", batchNum, id, "p.png", dragons);

			string url = "";

			if (chkURL.Checked)
			{
				url = GetURL(id, dragons);
				generateCode(imgLink, url, dragons);
			}
			generateCode(imgLink, url, dragons);
		}

		private void generateCode(string imgLink, string url, Dragon dragons)
		{
			if (chkURL.Checked)
			{
				lblCode.Text = dragons.WithURL(imgLink, url);
			}
			else
			{
				lblCode.Text = "[img]" + imgLink + "[/img]";
			}
		}

		private string GetURL(string id, Dragon dragons)
		{
			return dragons.GetURL(id);
		}

		private string GetImgLink(string type, string batchNum, string id, string ext, Dragon dragons)
		{
			return dragons.ImgURL(type, batchNum, id, ext);
		}

		private string GetBatchNumber(string id)
		{
			Dragon dragon = new Dragon();

			//return the batch num to a string
			return dragon.FindBatchNum(id).ToString();
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblCode.Text);
		}

		private void btnSmall_Click(object sender, EventArgs e)
		{
			string id = txtDragonID.Text.TrimEnd(' ');

			string batchNum = GetBatchNumber(id.Trim());

			string imgLink = GetImgLink("avatars", batchNum, id, ".png", dragons);

			string url = "";

			if (chkURL.Checked)
			{
				url = GetURL(id, dragons);
				generateCode(imgLink, url, dragons);
			}
			generateCode(imgLink, url, dragons);

		}

		private void btnLarge_Click(object sender, EventArgs e)
		{
			string id = txtDragonID.Text.TrimEnd(' ');

			string batchNum = GetBatchNumber(id.Trim());

			string imgLink = GetImgLink("350", batchNum, id, "_350.png",dragons);

			string url = "";

			if (chkURL.Checked)
			{
				url = GetURL(id, dragons);
				generateCode(imgLink, url, dragons);
			}
			generateCode(imgLink, url, dragons);

		}
	}
}

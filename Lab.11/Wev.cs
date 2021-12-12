using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._11
{
    public partial class Web : Form
    {
        int i = 0;
        public Web()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("New Page");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

         void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
            else
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
            else
                Application.Exit();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
        }

        private void Kitsune_Load(object sender, EventArgs e)
        {

        }

       

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Web-браузер розробив студент гр. IPZ-42 Ліхван Дмитро Юрійович e-mail whitedragon@ukr.net", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Нажимаючи на стрілочку вліво вас повертає на одну сторінку назад. \r " +
                "2. Нажимаючи на стрілоку вправо вас перекидає на сторінку вперед. \r" +
                "3. Нажимаєте на заокруглену стрілочку , сторінка оновлюється. \r" +
                "4. Нажимаєте на кнопку пошуку виконується пошук.Нажимаюте на плюс ,відкривається нова вкладка. \r" +
                "5. Нажимаєте на мінус ,вкладка закривається.", "Manual", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
    }


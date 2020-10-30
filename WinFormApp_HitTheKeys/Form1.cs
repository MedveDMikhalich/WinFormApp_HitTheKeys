using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp_HitTheKeys
{
  public partial class Form1 : Form
  {
    Random random = new Random();
    public Form1()
    {
      InitializeComponent();
      timer1.Enabled = true; //Делаем таймер активным
      timer1.Start(); //Запускаем таймер
    }
    
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void correctLabel_Click(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {

    }
  }
}

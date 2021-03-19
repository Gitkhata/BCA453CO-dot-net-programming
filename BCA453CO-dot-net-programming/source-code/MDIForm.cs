using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      IsMdiContainer = true;
    }
    private void menu1ToolStripMenuItem_Click(object sender, EventArgs e) {
      Form2 frm2 = new Form2();
      frm2.Show();
      frm2.MdiParent = this;
    }
    private void menu2ToolStripMenuItem_Click(object sender, EventArgs e) {
      Form3 frm3 = new Form3();
      frm3.Show();
      frm3.MdiParent = this;
    }
  }
}
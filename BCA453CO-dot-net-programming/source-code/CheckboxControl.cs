using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e) {
      string msg = "";

      if (checkBox1.Checked == true) {
        msg = "Java => SpringBoot";
      }

      if (checkBox2.Checked == true) {
        msg = msg + "C# => .NET";
      }

      if (checkBox3.Checked == true) {
        msg = msg + "Python => Django";
      }

      if (msg.Length > 0) {
        MessageBox.Show(msg + " selected ");
      } else {
        MessageBox.Show("No checkbox selected");
      }

      checkBox1.ThreeState = true;
    }
  }
}
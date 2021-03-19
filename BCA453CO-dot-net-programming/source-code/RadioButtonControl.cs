using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      radioButton1.Checked = true;
    }
    private void button1_Click(object sender, EventArgs e) {
      if (radioButton1.Checked == true) {
        MessageBox.Show("You've selected Taplejung !! ");
        return;
      } else if (radioButton2.Checked == true) {
        MessageBox.Show("You've selected Jhapa !! ");
        return;
      } else {
        MessageBox.Show("You've selected Sunsari !! ");
        return;
      }
    }
  }
}
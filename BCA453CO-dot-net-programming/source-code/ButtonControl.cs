using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      button1.Text = "Click Here";
    }
    private void button1_Click(object sender, EventArgs e) {
      MessageBox.Show("BCA-VIII::2077");
    }
  }
}
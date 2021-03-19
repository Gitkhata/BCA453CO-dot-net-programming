using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      label1.Text = "This is my first label";
      label1.BorderStyle = BorderStyle.FixedSingle;
      label1.TextAlign = ContentAlignment.MiddleCenter;
    }
  }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      textBox1.Width = 250;
      textBox1.Height = 50;
      textBox1.Multiline = true;
      textBox1.BackColor = Color.Blue;
      textBox1.ForeColor = Color.White;
      textBox1.BorderStyle = BorderStyle.Fixed3D;
    }
    private void button1_Click(object sender, EventArgs e) {
      string val;
      val = textBox1.Text;
      MessageBox.Show(val);
    }
  }
}
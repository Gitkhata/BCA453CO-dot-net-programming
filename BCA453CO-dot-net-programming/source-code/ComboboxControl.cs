using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      comboBox1.Items.Add("Taplejung");
      comboBox1.Items.Add("Panchthar");
      comboBox1.Items.Add("Ilam");
      comboBox1.Items.Add("Jhapa");
      comboBox1.SelectedIndex = comboBox1.FindStringExact("Taplejung");

    }
    private void button1_Click(object sender, EventArgs e) {
      string var;
      var = comboBox1.Text;
      MessageBox.Show(var);
    }
  }
}
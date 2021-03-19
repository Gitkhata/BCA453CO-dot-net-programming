using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e) {
      dateTimePicker1.Format = DateTimePickerFormat.Short;
      dateTimePicker1.Value = DateTime.Today;
    }
    private void button1_Click(object sender, EventArgs e) {
      DateTime iDate;
      iDate = dateTimePicker1.Value;
      MessageBox.Show("Selected date is " + iDate);
    }
  }
}
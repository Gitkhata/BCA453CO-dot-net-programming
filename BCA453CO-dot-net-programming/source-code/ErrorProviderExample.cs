using System;
using System.Windows.Forms;
namespace WindowsFormsApplication8 {
  public partial class Form1: Form {
    public Form1() {
      InitializeComponent();
    }
    private void textBox1_TextChanged(object sender, EventArgs e) {
      // Determine if the TextBox has a digit character.
      string text = textBox1.Text;
      bool hasDigit = false;
      foreach(char letter in text) {
        if (char.IsDigit(letter)) {
          hasDigit = true;
          break;
        }
      }
      // Call SetError or Clear on the ErrorProvider.
      if (!hasDigit) {
        errorProvider1.SetError(textBox1, "Needs to contain a digit");
      } else {
        errorProvider1.Clear();
      }
    }
  }
}
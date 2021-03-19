<%@ Page Language="C#" %>
<script runat="server">
  protected void Button1_Click(Object sender, EventArgs e) {
    if (Page.IsValid) {
      Label1.Text = "VALID ENTRY!";
    }
  }
  void ValidateNumber(object source, ServerValidateEventArgs args) { 
    try {
      int num = int.Parse(args.Value);
      args.IsValid = ((num%5) == 0);
    }
    catch(Exception ex) {
      args.IsValid = false;
    }
  }
</script>
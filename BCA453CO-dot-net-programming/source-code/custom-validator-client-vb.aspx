<%@ Page Language="VB" %>
<script runat="server">
  Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
      Label1.Text = "VALID NUMBER!"
  End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
  <head runat="server">
    <title>CustomValidator</title>
    <script language="JavaScript">
      function validateNumber(oSrc, args) {
          args.IsValid = (args.Value % 5 == 0);
      }
    </script>
  </head>
  <body>
    <form id="form1" runat="server">
      <div>
        <p>
          Number:
          <asp:TextBox ID="TextBox1"
            Runat="server"></asp:TextBox>
          &nbsp;
          <asp:CustomValidator ID="CustomValidator1"
            Runat="server" ControlToValidate="TextBox1"
            ErrorMessage="Number must be divisible by 5"
            ClientValidationFunction="validateNumber">
          </asp:CustomValidator>
        </p>
        <p>
          <asp:Button ID="Button1" OnClick="Button1_Click"
            Runat="server" Text="Button"></asp:Button>
        </p>
        <p>
          <asp:Label ID="Label1" Runat="server"></asp:Label>
        </p>
      </div>
    </form>
  </body>
</html>
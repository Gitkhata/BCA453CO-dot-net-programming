<%@ Page Language="VB" %>
<script runat="server">
   Protected Sub Button1_Click(sender As Object, e As EventArgs)
   Label1.Text = "Passwords match"
   End Sub
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
   <head runat="server">
      <title>CompareFieldValidator</title>
   </head>
   <body>
      <form runat="server">
         <p>
            Password<br>
            <asp:TextBox ID="TextBox1" Runat="server"
               TextMode="Password"></asp:TextBox>
            &nbsp;
            <asp:CompareValidator ID="CompareValidator1"
               Runat="server" ErrorMessage="Passwords do not match!"
               ControlToValidate="TextBox2"
               ControlToCompare="TextBox1"></asp:CompareValidator>
         </p>
         <p>
            Confirm Password<br>
            <asp:TextBox ID="TextBox2" Runat="server"
               TextMode="Password"></asp:TextBox>
         </p>
         <p>
            <asp:Button ID="Button1" OnClick="Button1_Click"
               Runat="server" Text="Login"></asp:Button>
         </p>
         <p>
            <asp:Label ID="Label1" Runat="server"></asp:Label>
         </p>
      </form>
   </body>
</html>
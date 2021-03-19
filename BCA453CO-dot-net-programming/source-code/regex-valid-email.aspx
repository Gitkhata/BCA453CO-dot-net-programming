Email:
<asp:TextBox ID="TextBox1" Runat="server"></asp:TextBox>
&nbsp;
<asp:RegularExpressionValidator ID="RegularExpressionValidator1"
Runat="server" ControlToValidate="TextBox1"
ErrorMessage="You must enter an email address"
ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
</asp:RegularExpressionValidator>
<p>
    First name
    <asp:TextBox ID="TextBox1" Runat="server"></asp:TextBox>
    &nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
      Runat="server" ErrorMessage="You must enter your first name"
      ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
  </p>
  <p>
    Last name
    <asp:TextBox ID="TextBox2" Runat="server"></asp:TextBox>
    &nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
      Runat="server" ErrorMessage="You must enter your last name"
      ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
  </p>
  <p>
    <asp:Button ID="Button1" OnClick="Button1_Click" Runat="server"
      Text="Submit"></asp:Button>
  </p>
  <p>
    <asp:ValidationSummary ID="ValidationSummary1" Runat="server"
      HeaderText="You received the following errors:"></asp:ValidationSummary>
  </p>
  <p>
    <asp:Label ID="Label1" Runat="server"></asp:Label>
  </p>
<%@ Page Language="C#" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e) {
        RangeValidator1.MinimumValue = DateTime.Now.ToShortDateString();
        RangeValidator1.MaximumValue =
        DateTime.Now.AddDays(14).ToShortDateString();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e){
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
    }
    protected void Button1_Click(object sender, EventArgs e){
        if (Page.IsValid){
            Label1.Text = "You are set to arrive on: " + TextBox1.Text.ToString();
        }
    }
</script>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="ASP.net_Calender.Calender" %>

<!DOCTYPE html>
<html>
<body>

<form runat="server">
<asp:Calendar DayNameFormat="Full" runat="server"
SelectionMode="DayWeekMonth"
SelectMonthText="<*>"
SelectWeekText="<->"/>
   <SelectorStyle BackColor="#f5f5f5" />
</asp:Calendar>
</form>

</body>
</html>
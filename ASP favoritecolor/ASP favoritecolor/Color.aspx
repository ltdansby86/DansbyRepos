<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Color.aspx.cs" Inherits="ASP_favoritecolor.Color" %>

<script  runat="server">
Sub submit(Source As Object, e As EventArgs)
if r1.Checked=True then
   p1.InnerHtml="Your favorite color is red"
else
   if r2.Checked=True then
     p1.InnerHtml="Your favorite color is green"
   else
     if r3.Checked=True then
       p1.InnerHtml="Your favorite color is blue"
     end if
   end if
end if
End Sub
</script>

<!DOCTYPE html>
<html>
<body>

<form runat="server">
<p>Select your favorite color:
<br>
<input id="r1" name="col" type="radio" runat="server">Red</input>
<br>
<input id="r2" name="col" type="radio" runat="server">Green</input>
<br>
<input id="r3" name="col" type="radio" runat="server">Blue</input>
<br>
<input type="button" value="Submit" OnServerClick="submit" runat="server"/>
<p id="p1" runat="server" />
</form>

</body>
</html>
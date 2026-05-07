<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PersonalityAnalyzer.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personality Analyzer</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 40px; background-color: #f4f7f6; }
        .container { background: white; padding: 30px; border-radius: 8px; box-shadow: 0 4px 8px rgba(0,0,0,0.1); max-width: 500px; margin: auto; text-align: center; }
        img { max-width: 100%; height: auto; border-radius: 4px; margin-bottom: 20px; }
        .result { margin-top: 20px; font-weight: bold; color: #2c3e50; font-size: 1.2em; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Personality Analyzer</h2>
            <p>Look at the image below. What did you see first?</p>
            
            <asp:Image ID="imgIllusion1" runat="server" ImageUrl="~/Images/illusion1.jpg" AlternateText="Optical Illusion 1" />
            <br />
            
            <asp:RadioButtonList ID="rblIllusion1" runat="server" RepeatDirection="Horizontal" style="margin: 0 auto; text-align: left;">
                <asp:ListItem Value="Duck">A Duck</asp:ListItem>
                <asp:ListItem Value="Rabbit">A Rabbit</asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <asp:Button ID="btnAnalyze" runat="server" Text="Analyze Personality" OnClick="btnAnalyze_Click" BackColor="#3498db" ForeColor="White" BorderStyle="None" Padding="10" />
            
            <div class="result">
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
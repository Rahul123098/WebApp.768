<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="UserRegistrationform.aspx.cs" Inherits="WebApp._768.UserRegistrationform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        
        <tr>
            <td>name :</td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>        
        </tr>

         <tr>
            <td>Gender :</td>
            <td><asp:RadioButtonList ID="rblgender" runat="server" RepeatColumns="3" ></asp:RadioButtonList></td>        
        </tr>

         <tr>
            <td>country :</td>
            <td><asp:RadioButtonList ID="rblcountry" runat="server" RepeatColumns="3" OnSelectedIndexChanged="rblcountry_SelectedIndexChanged" AutoPostBack="true"></asp:RadioButtonList></td>        
        </tr>

        <tr>
            <td>state :</td>
            <td><asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>        
        </tr>

        <tr>
            <td>city :</td>
            <td><asp:DropDownList ID="ddlcity" runat="server"></asp:DropDownList></td>        
        </tr>

         <tr>
            <td>Email :</td>
            <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>        
        </tr>

        <tr>
            <td>Password :</td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>        
        </tr>

        <tr>
            <td>Qualification :</td>
            <td><asp:DropDownList ID="ddlqualification" runat="server"></asp:DropDownList></td>        
        </tr>

         <tr>
            <td></td>
            <td><asp:Button ID="btnsubmit" runat="server" Text="submit" BackColor="Red" ForeColor="White" Width="70px" Height="25px" OnClick="btnsubmit_Click" /></td>        
        </tr>
    </table>


</asp:Content>

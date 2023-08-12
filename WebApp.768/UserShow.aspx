<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="UserShow.aspx.cs" Inherits="WebApp._768.UserShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <a href="UserRegistrationform.aspx">Add New User</a>
            </td>
        </tr>

        <tr>
            <td>
                <asp:TextBox ID ="txtsearch" runat="server"></asp:TextBox>
                <asp:Button ID ="btnsearch" runat="server" Text="Search" BackColor="Red" ForeColor="White" Width="70px" Height="25px" OnClick="btnsearch_Click" />

            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblmsg" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
            </td>
        </tr>


        <tr>
            <td>
                <asp:GridView ID="gvusers" runat="server" AutoGenerateColumns="false" OnRowCommand="gvusers_RowCommand" OnSelectedIndexChanged="gvusers_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="UserId">
                           <ItemTemplate>
                            <%#Eval("uid") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User name">
                           <ItemTemplate>
                            <%#Eval("uname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User gender">
                           <ItemTemplate>
                            <%#Eval("gname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Country">
                           <ItemTemplate>
                            <%#Eval("Cname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User State">
                           <ItemTemplate>
                            <%#Eval("sname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User City">
                           <ItemTemplate>
                            <%#Eval("cityname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User email">
                           <ItemTemplate>
                            <%#Eval("uemail") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User password">
                           <ItemTemplate>
                            <%#Eval("upassword") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User qualification">
                           <ItemTemplate>
                            <%#Eval("qname") %>
                           </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Delete">
                           <ItemTemplate>
                            <asp:Button ID="btndelete" runat="server" Text="Delete" CommandName="A" CommandArgument='<%#Eval("uid") %>'></asp:Button>
                           </ItemTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField>
                           <ItemTemplate>
                            <asp:Button ID="btnedit" runat="server" Text="Edit" CommandName="B" CommandArgument='<%#Eval("uid") %>'></asp:Button>
                           </ItemTemplate>
                        </asp:TemplateField>
                              
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
    </asp:Content>


               
        
                    


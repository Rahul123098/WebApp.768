<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp._768.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome Home.....</h1>
    <table>
        <tr>
            <td>
              <asp:GridView ID="gvusers" runat="server" AutoGenerateColumns="false">


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
      

     


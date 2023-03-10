<%@ Page Title="AddData" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="EmployeeWebApplication.AddData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add Data Page</h1>
    <h3>Please fill in the textboxes below</h3>
    <div>
        <br />
    <table>
       <tb>
            <tr>
               <td><asp:Label ID="NameLabel" runat="server" Text="Employee Name:"></asp:Label><br/>
              <asp:TextBox ID="NameTxtbox" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red"
                ControlToValidate="NameTxtbox" ErrorMessage="Employee Name must be  a string" 
                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator></td>
               
           </tr>
         
           <tr>
               <td><br/><asp:Label ID="SurnameLabel" runat="server" Text="Employee Surname:"></asp:Label><br/>
              <asp:TextBox ID="Surnametxtbox" runat="server"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red"
                ControlToValidate="Surnametxtbox" ErrorMessage="Employee Surname must be  a string" 
                ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator></td>     
           </tr>
            <tr>
               <td><br/><asp:Label ID="Label1" runat="server" Text="Date of birth:"></asp:Label><br/>
              <asp:TextBox ID="DOBtxtBox" runat="server" TextMode="Date"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
               ControlToValidate="DOBtxtBox"  ErrorMessage="Date of birth is  required ."  ForeColor="Red"></asp:RequiredFieldValidator></td>  
 

   
           </tr>

           <tr>
               <td><br/><asp:Label ID="Label2" runat="server" Text="Employee status:"></asp:Label><br/>
                   <asp:DropDownList ID="EmployeeStatus" runat="server" Height="16px" Width="125px">
                       <asp:ListItem>Suspended</asp:ListItem>
                       <asp:ListItem>Inactive</asp:ListItem>
                       <asp:ListItem>Active</asp:ListItem>
                       <asp:ListItem>Retired</asp:ListItem>
                   </asp:DropDownList>
           </tr>

       </tb> 
    </table> 
    </div>
    <br />
    <div >
         <table class="center">
            
                <tr>
                    <td>
                     
                        <asp:Button ID="SubmitBtn" runat="server" Text="SUBMIT" CssClass="button" Height="48px" Width="189px" OnClick="SubmitBtn_Click" />
                          <asp:Button ID="Clearbtn" runat="server" Text="CLEAR" CssClass="button" Height="48px" Width="189px" OnClick="Clearbtn_Click" />

                    </td>
                </tr>
             
           
        </table>
    </div>
     <div>
        <br />
              <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" >
                  <AlternatingRowStyle BackColor="#CCCCCC" />
                  <FooterStyle BackColor="#CCCCCC" />
                  <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                  <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                  <SortedAscendingHeaderStyle BackColor="#808080" />
                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                  <SortedDescendingHeaderStyle BackColor="#383838" />
              </asp:GridView>
    </div>
    
</asp:Content>

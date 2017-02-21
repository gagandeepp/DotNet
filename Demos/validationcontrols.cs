<asp:RequiredFieldValidator ID="rfvcandidate" 
   runat="server" ControlToValidate ="ddlcandidate"
   ErrorMessage="Please choose a candidate" 
   InitialValue="Please choose a candidate">
   
</asp:RequiredFieldValidator>

<asp:RangeValidator ID="rvclass" runat="server" ControlToValidate="txtclass" 
   ErrorMessage="Enter your class (6 - 12)" MaximumValue="12" 
   MinimumValue="6" Type="Integer">
   
</asp:RangeValidator>

 <asp:RegularExpressionValidator ID="remail" runat="server" 
               ControlToValidate="txtemail" ErrorMessage="Enter your email" 
               ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>

<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
   DisplayMode = "BulletList" ShowSummary = "true" HeaderText="Errors:" />
   
   <asp:CustomValidator ID="CustomValidator1" runat="server" 
   ClientValidationFunction=.cvf_func. ErrorMessage="CustomValidator">
   
</asp:CustomValidator>
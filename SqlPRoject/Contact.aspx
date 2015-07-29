<%@ Page Title="Contact" EnableEventValidation="true" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SqlPRoject.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
 <a name="about"></a>

            <div class="container">

                <div class="row">
                    <div class="col-lg-12 text-center">
                            <div class="intro-message">
                            <h2>Add a Tech, Cap, and Vend</h2>

                            <hr class="intro-divider">
                           </div>
                    

            </div>
               
            <div class="row">

                </div>
                <div class="col-lg-4">
                   
                     <h3>Add a tech</h3>
                     <div class="form-group">
    <label for="exampleInputEmail1">Tech Name</label>

     <asp:TextBox runat="server"  class="form-control" id="TechName" placeholder="Enter tech Name"></asp:TextBox>
  
    <label for="exampleInputPassword1">Domain Name</label>
    
     <asp:Label ID="Label3" runat="server" Text="Select a Domain"></asp:Label>
        <asp:DropDownList class="form-control" ID="DropDownList5" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" >
            <asp:ListItem Value="-1">Choose Domain</asp:ListItem>
        </asp:DropDownList>

     <asp:Label ID="Label1" runat="server" Text="Select a Vendor"></asp:Label>
        <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" AutoPostBack="True" >
            <asp:ListItem Value="-1">Choose Vendor</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="Select a Service"></asp:Label>
        <asp:DropDownList class="form-control" ID="DropDownList2" runat="server" AutoPostBack="True" >
            <asp:ListItem Value="-1">Choose Service</asp:ListItem>
        </asp:DropDownList>


   
   <div class="checkbox">
    <label>
      <asp:CheckBox runat="server" type="checkbox" /> Practioner gacing
    </label>
  </div>

    
  
  <label>Status</label>    
  <select class="form-control" id="">
  <option>Current</option>
  <option>Future</option>
  <option>New</option>
   <option>Retired</option>
</select>

  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ></asp:SqlDataSource>

        Category:
        <asp:DropDownList ID="DropDownList3" runat="server" Class="form-control"  DataTextField="Category" DataValueField="Category" AppendDataBoundItems="true">
        </asp:DropDownList>
 
        Capability: 
        <asp:DropDownList ID="DropDownList4" runat="server" class="form-control"  DataTextField="CapabilityName" DataValueField="CapabilityID" AppendDataBoundItems="true">
        </asp:DropDownList>
       
    
    
    <label for="exampleInputPassword1">Product Version</label>
    <asp:TextBox runat="server"  class="form-control" id="ProductVersion" placeholder="Enter tech info"></asp:TextBox>

   <div class="checkbox">
    <label>
      <input type="checkbox" id="cloud"> External Cloud
    </label>
  </div>
  </div>
                              <div class="row">
                <div class="col-lg-12 text-center">
                   <asp:Button runat="server" value="Submit"  class="btn btn-block btn-primary center-block" OnClick="Unnamed3_Click"></asp:Button> 
                </div>
            </div>
  
                    
      
            
            </div>
           
    </div>
</asp:Content>

<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SqlPRoject.Contact" %>

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

            </div>
            <div class="row">
                <div class="col-lg-4">
                    <form>
                     <h3>Add a tech</h3>
                     <div class="form-group">
    <label for="exampleInputEmail1">Tech Name</label>
    <input type="text" class="form-control" id="TechName" placeholder="Email">
  
  
    <label for="exampleInputPassword1">Domain Name</label>
    <input type="text" class="form-control" id="DomainName" placeholder="Enter tech info">

    <label for="exampleInputPassword1">Category</label>
    <input type="text" class="form-control" id="Category" placeholder="Enter tech info">

    <label for="exampleInputPassword1">Capability Name</label>
    <input type="text" class="form-control" id="Capability" placeholder="Enter tech info">

   <div class="checkbox">
    <label>
      <input type="checkbox"> Practioner gacing
    </label>
  </div>

    <label for="exampleInputPassword1">Service</label>
    <input type="text" class="form-control" id="Service" placeholder="Enter tech info">

    <label for="exampleInputPassword1">Vendor Name</label>
    <input type="text" class="form-control" id="Vendor" placeholder="Enter tech info">
  <label>Status</label>    
  <select class="form-control" id="">
  <option>Current</option>
  <option>Future</option>
  <option>New</option>
   <option>Retired</option>
</select>
    
    
    <label for="exampleInputPassword1">Product Version</label>
    <input type="text" class="form-control" id="productVersion" placeholder="Enter tech info">

   <div class="checkbox">
    <label>
      <input type="checkbox" id="cloud"> External Cloud
    </label>
  </div>
  </div>
 
                    
                </div>
                <div class="col-lg-4">
                <h3>Add a Capibalties</h3>
                    
                     <div class="form-group">
    <label for="exampleInputEmail1">Capiabilties Name</label>
    <input type="text" class="form-control" id="exampleInputEmail1"placeholder="Enter tech info">
  </div>

 
                    
                </div>
                <div class="col-lg-4">
                    <h3>Add a vendor</h3>
                     <div class="form-group">
    <label for="exampleInputEmail1">Vendor Name</label>
    <input type="text" class="form-control" id="exampleInputEmail1"placeholder="Enter tech info">
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Cool Stuff</label>
    <input type="text" class="form-control" id="exampleInputPassword1"placeholder="Enter tech info">
      <input type="submit" id="submit" />
  </div>       
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <button class="btn btn-block btn-primary center-block">WHAT ARE THOOSE</button>
                    </form>
                </div>
            </div>
            
            </div>
           
</asp:Content>

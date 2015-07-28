<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SqlPRoject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <a name="about"></a>

            <div class="container">

                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="intro-message">
                            <h2>Search for a Vendor or Technology</h2>

                            <hr class="intro-divider">
                            <form class="form-group">
                              <input type="text" class="form-control" id="exampleInputEmail1" placeholder="Search for a Vendor or Tech">
                              <button class="btn btn-primary  btn-lg">Search</button>
                            </form>

                      
                                <table class="table table-bordered">
                                    <tr>
                                      <th>Company</th><th>Number of Tech</th><th>Year</th>
                                    </tr>
                                    <tr>
                                      <td>Microsoft</td> <td>23</td> <td>1996</td>
                                    </tr>
                                    <tr>
                                      <td>Microsoft</td> <td>23</td> <td>1996</td>
                                    </tr>
                                    <tr>
                                      <td>Microsoft</td> <td>23</td> <td>1996</td>
                                    </tr>
                                    <tr>
                                      <td>Microsoft</td> <td>23</td> <td>1996</td>
                                    </tr>
                                </table>

                        </div>
                        </div>
                    </div>
                </div>

</asp:Content>

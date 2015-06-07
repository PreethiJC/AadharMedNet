﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book Appointment.aspx.cs" Inherits="AadharMedNet.Book_Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height:100%">
<head id="Head1" runat="server">
    <title></title>
    <link href="App_Themes/Themes/MyHome.css" rel="stylesheet" />
</head>
<body style="height: 100%; background: #f3f1f5;">
    <form id="form1" runat="server" style="height:100%; width: 100%;">   
       
        <div class="box">
            <div style="height:4%" class="bar">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
            </div> 
            <div style="height: 100%; width:20%;float:left;">
                <ul id="cssmenu" style="height: 96%">
                    <li>
                        <asp:HyperLink ID="MedPrfl" runat="server" NavigateUrl="~/Home_Prfl.aspx">Medical Profile</asp:HyperLink>
                    </li>
                    <li> 
                        <asp:HyperLink ID="MedSrvcs" runat="server" NavigateUrl="~/Medical Service.aspx">Medical Services</asp:HyperLink>
                    </li>
                    <li> 
                        <asp:HyperLink ID="MyReq" runat="server" NavigateUrl="~/My Requests.aspx">My Requests</asp:HyperLink>
                    </li>                    
                    <li>
                        <asp:HyperLink ID="MyApntmnt" runat="server" NavigateUrl="~/My Appointments.aspx">My Appointments</asp:HyperLink>
                    </li>
                    <li style="background: white">
                        <asp:HyperLink ID="BkApntmnt" runat="server" BackColor="White" ForeColor="#0BD3FF">Book Appointment</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="UpldCrtfct" runat="server" NavigateUrl="~/Upload Certificates.aspx">Upload Certificates</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="Srch" runat="server" NavigateUrl="~/Search.aspx">Search</asp:HyperLink>
                    </li>
                    <li>
                        <asp:HyperLink ID="Stngs" runat="server" NavigateUrl="~/Settings.aspx">Settings</asp:HyperLink>
                    </li>
                </ul>
            </div>             
            <div style="float:right; width:80%; font-family:gisha;">
                <asp:Table ID="TblBkApntmnt" runat="server" Width="100%">                    
                    <asp:TableRow ID="TblBkApntmntRw1" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellHsptl" runat="server">Hospital:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellHsptlVal" runat="server">
                            <asp:DropDownList ID="CmbBxHsptl" runat="server" CssClass="ddl" Font-Names="Gisha">
                                <asp:ListItem>Hospital 1</asp:ListItem>
                                <asp:ListItem>Hospital 2</asp:ListItem>
                                <asp:ListItem>Hospital 3</asp:ListItem>                                
                            </asp:DropDownList>
                        </asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TblBkApntmntRw2" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellDt" runat="server">Date:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellDtVal" runat="server">
                            <asp:TextBox ID="TxtBxDate" runat="server" TextMode="Date" CssClass="ddl"></asp:TextBox>
                        </asp:TableCell>                        
                    </asp:TableRow>
                    <asp:TableRow ID="TblBkApntmntRw3" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellTm" runat="server">Time:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellTmVal" runat="server">
                            <asp:TextBox ID="TxtBxTm" runat="server" TextMode="Time" CssClass="ddl"></asp:TextBox>
                        </asp:TableCell>                        
                    </asp:TableRow>  
                    <asp:TableRow ID="TblBkApntmntRw4" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellAdd" runat="server">Address:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellAddVal" runat="server">

                        </asp:TableCell>                        
                    </asp:TableRow> 
                    <asp:TableRow ID="TblBkApntmntRw5" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellRsn" runat="server">Address:</asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellRsnVal" runat="server">
                            <asp:TextBox ID="TxtBxRsn" runat="server" CssClass="field" TextMode="MultiLine"></asp:TextBox>
                        </asp:TableCell>                        
                    </asp:TableRow>  
                    <asp:TableRow ID="TblBkApntmntRw6" runat="server" HorizontalAlign="Left">
                        <asp:TableCell ID="TblBkApntmntCellBtn" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TblBkApntmntCellBtnVal" runat="server">
                            <asp:Button ID="BtnBkApntmnt" runat="server" Text="Book Appointment" CssClass="btn" />
                        </asp:TableCell>                        
                    </asp:TableRow>                                                                   
                </asp:Table>
            </div>
        </div>        
    </form>
</body>
</html>

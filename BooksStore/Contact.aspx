<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="BooksStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container row d-flex align-items-center">
        <div class="col-6">
            <label>Book title</label>
            <asp:TextBox
                ValidationGroup="book"
                ID="txtBookTitle"
                class="form-control"
                runat="server" />
            <asp:RequiredFieldValidator
                Display="Static"
                CssClass="fa fa-asterisk"
                Style="color: red"
                ValidationGroup="book"
                ID="txtBookTitleValidator"
                ErrorMessage="This field is required"
                ControlToValidate="txtBookTitle"
                runat="server" />
        </div>
        <div class="col-6">
            <label>Image (URL)</label>
            <asp:TextBox
                ValidationGroup="book"
                ID="txtBookImage"
                class="form-control"
                runat="server" />
            <asp:RequiredFieldValidator
                Display="Static"
                CssClass="fa fa-asterisk"
                Style="color: red"
                ValidationGroup="book"
                ID="RequiredFieldValidator16"
                ErrorMessage="This field is required"
                ControlToValidate="txtBookImage"
                runat="server" />
        </div>
        <div class="col-6">
            <label>Synopsis</label>
            <asp:TextBox
                ValidationGroup="book"
                ID="txtBookSynopsis"
                class="form-control"
                runat="server" />
            <asp:RequiredFieldValidator
                Display="Static"
                CssClass="fa fa-asterisk"
                Style="color: red"
                ValidationGroup="book"
                ID="txtBookSynopsisValidator"
                ErrorMessage="This field is required"
                ControlToValidate="txtBookSynopsis"
                runat="server" />
        </div>

        <div class="col-6" id="divGenresContainer" runat="server">
        </div>
        <div class="col-3">
            <asp:Button
                OnClick="SendBookData_Click"
                ValidationGroup="dish"
                Text="SEND"
                class="btn btn-primary"
                ID="SendBookData"
                runat="server" />
        </div>
    </div>



</asp:Content>

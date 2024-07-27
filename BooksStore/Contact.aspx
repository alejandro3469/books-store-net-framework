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
            <asp:FileUpload
                class="form-control"
                ID="imbBookhImageFile"
                runat="server" accept=".png,.jpg,.jpeg" onchange="ShowImage()" />
            <asp:HiddenField ID="hfImage" runat="server" />
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
            <asp:CheckBox
                class="form-check-input"
                ID="cbCat1"
                runat="server" />
            <label class="form-check-label" for="flexCheckDefault">
                Sci-fi
            </label>
            <asp:CheckBox
                class="form-check-input"
                ID="cbCat2"
                runat="server" />
            <label class="form-check-label" for="flexCheckDefault">
                Action
            </label>
            <asp:CheckBox
                class="form-check-input"
                ID="cbCat3"
                runat="server" />
            <label class="form-check-label" for="flexCheckDefault">
                Drama
            </label>
        </div>
        <div class="col-3">
            <button type="submit" class="btn btn-primary">Submit</button>
        </div>
    </div>



</asp:Content>

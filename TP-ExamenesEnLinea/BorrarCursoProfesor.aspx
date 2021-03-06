﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="BorrarCursoProfesor.aspx.cs" Inherits="TP_ExamenesEnLinea.BorrarCursoProfesor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="nav-tabs breadcrumb col-md-offset-0">
        <h3>
            Borrar curso</h3>
        <div class="breadcrumb col-mg-2">
            <div class="table table-striped table-hover">
                <div>
                            ¿Esta seguro que desea borrar este curso?
                </div>
                <div class="nav-pills">
                            <p>
                                <asp:Button ID="Button1" runat="server" Text="Borrar" CssClass="btn  btn-success" />
                                <asp:Button ID="Button2" runat="server" Text="Cancelar" CssClass="btn  btn-inverse" PostBackUrl="~/CursosProfesor.aspx"/>
                         </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

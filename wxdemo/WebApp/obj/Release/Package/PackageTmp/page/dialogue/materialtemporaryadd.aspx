﻿<%@ Page Title="新增临时素材" Language="C#" MasterPageFile="~/layout/page.Master" AutoEventWireup="true" CodeBehind="materialtemporaryadd.aspx.cs" Inherits="WebApp.page.dialogue.materialtemporaryadd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form action="/handler/dialogueHandler.aspx?action=materialtemporaryadd" method="post" enctype="multipart/form-data" name="media">
        <div style="text-align:center;">
             <br />

            <select name="type">
                <option value="image">图片</option>
                <option value="voice">语音</option>
                <option value="video">视频</option>
                <option value="thumb">缩略图</option>
            </select>
              <br />
        <input type="file" name="media" />
        <br />
        <br />
        <input type="submit"  value="提交" class="button" />
        </div>
       
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

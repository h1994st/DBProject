﻿<%@ Page Title="发布信息 | 失物招领管理系统" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="PostLostInfo.aspx.cs" Inherits="L_FMS.PostLostInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CustomStylesheetContent" runat="server">
    <!-- Custom Stylesheets -->
  <webopt:bundlereference runat="server" path="~/stylesheets/Post" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
  <main class="post-screen">
    <div class="login-icon">
      <img src="images/icons/svg/paper-bag.svg" alt="Welcome th L&FMS">
      <h4>Complete the <small>information</small></h4>
    </div>
    <form class="login-form" name="loginForm" action="" method="POST" runat="server" enctype="multipart/form-data">
      <div class="form-group">
        <label for="post-name" style="color: #bfc9ca;">物品名</label>
        <input type="text" class="form-control login-field" placeholder="物品名" name="item-name" id="post-name" required autofocus>
        <label for="post-name" class="login-field-icon fui-search"></label>
      </div>
      <div class="form-group">
        <label for="post-place" style="color: #bfc9ca;">地点</label>
            <input type="text" class="form-control login-field" placeholder="地点" name="item-place" id="post-place" required>
        <label for="post-place" class="login-field-icon fui-location"></label>
      </div>
      <div class="form-group">
        <label for="post-image" style="color: #bfc9ca;">图片</label>
        <input type="file" class="form-control login-field filestyle" name="item-image" id="post-image" accept="image/*"  required >
      </div>
      <div class="form-group">
        <label for="post-tags" style="color: #bfc9ca;">标签</label>
        <input class="form-control login-field tagsinput" placeholder="标签"  name="item-tags" id="post-tags" >
      </div>
      <div class="form-group">
        <label for="post-description" style="color: #bfc9ca;">物品描述</label>
        <textarea class="form-control login-field" name="item-description" id="post-description" cols="30" rows="5" placeholder="物品描述"></textarea>
      </div>
      <asp:Button CssClass="btn btn-danger btn-lg btn-block" runat="server" OnClick="postButton" Text="提交"/>
    </form>
  </main>
</asp:Content>

<asp:Content ContentPlaceHolderID="CustomScriptContent" runat="server">
  <%: Scripts.Render("~/scripts/Post") %>
  <script type="text/javascript">
    $("select").selectpicker({ style: 'btn-hg btn-primary', menuStyle: 'dropdown-inverse' });
    $(".tagsinput").tagsInput();
  </script>
</asp:Content>

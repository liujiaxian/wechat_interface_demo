﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using WebApp.handler;

namespace WebApp.page.dialogue
{
    public partial class moveusergroup : baseHandler
    {
        public string openid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo user = getUserInfo();
            openid = user.openid;
        }
    }
}
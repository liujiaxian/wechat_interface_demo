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
    public partial class menuaddtwo : baseHandler
    {
        public List<wx_menu_type> typelist = new List<wx_menu_type>();
        public List<wx_menu> menulist = new List<wx_menu>();
        protected void Page_Load(object sender, EventArgs e)
        {
            typelist = db.wx_menu_type.Where(c => true).ToList();

            menulist = db.wx_menu.Where(c => c.pID == 0).ToList();
        }
    }
}
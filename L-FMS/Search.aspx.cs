﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Entity.Infrastructure;

namespace L_FMS
{
    public partial class Search : System.Web.UI.Page
    {
        protected DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("name");
            dt.Columns.Add("date");
            dt.Columns.Add("place");
            String SearchMessage = "张睿";
            ItemEx[] itemMessage = DBModel.GetInstance().GetItemBySearchString(SearchMessage);
            foreach (var i in itemMessage)
            {
                object[] dr = new object[3];
                dr[0] = i.ITEM_NAME;
                dr[1] = i.PUBLISH_DATE.ToString();
                dr[2] = i.PLACE;
                dt.Rows.Add(dr);
                this.searchItem.DataSource = dt;
                this.searchItem.DataBind();
            }

        }
        protected void runtoSearch(object sender, EventArgs e)
        {


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrders = new clsOrders();
        //capture the devively type
        AnOrders.DeliveryType = txtDeliveryType.Text;
        //store the orders in the session object
        Session["AnOrders"] = AnOrders;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}
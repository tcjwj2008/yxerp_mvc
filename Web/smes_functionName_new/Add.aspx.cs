﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace yinxiang.Web.smes_functionName_new
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtorgId.Text.Trim().Length==0)
			{
				strErr+="orgId不能为空！\\n";	
			}
			if(this.txtfunctionGroup.Text.Trim().Length==0)
			{
				strErr+="functionGroup不能为空！\\n";	
			}
			if(this.txtfunctionCode.Text.Trim().Length==0)
			{
				strErr+="functionCode不能为空！\\n";	
			}
			if(this.txtfunctionName.Text.Trim().Length==0)
			{
				strErr+="functionName不能为空！\\n";	
			}
			if(this.txtfunctionPath.Text.Trim().Length==0)
			{
				strErr+="functionPath不能为空！\\n";	
			}
			if(this.txtmemo.Text.Trim().Length==0)
			{
				strErr+="memo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string orgId=this.txtorgId.Text;
			string functionGroup=this.txtfunctionGroup.Text;
			string functionCode=this.txtfunctionCode.Text;
			string functionName=this.txtfunctionName.Text;
			string functionPath=this.txtfunctionPath.Text;
			string memo=this.txtmemo.Text;

			yinxiang.Model.smes_functionName_new model=new yinxiang.Model.smes_functionName_new();
			model.orgId=orgId;
			model.functionGroup=functionGroup;
			model.functionCode=functionCode;
			model.functionName=functionName;
			model.functionPath=functionPath;
			model.memo=memo;

			yinxiang.BLL.smes_functionName_new bll=new yinxiang.BLL.smes_functionName_new();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

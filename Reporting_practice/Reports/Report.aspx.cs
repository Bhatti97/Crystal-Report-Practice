using CrystalDecisions.CrystalReports.Engine;
using Reporting_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reporting_practice.Reports
{
    public partial class Report : System.Web.UI.Page
    {
        ApplicationDbContext db = new ApplicationDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["value"] == "AllEmployeeReport")
            {
                AllEmployeeReport rpt = new AllEmployeeReport();
                rpt.SetDataSource(db.Employees.ToList());
                CrystalReportViewer1.ReportSource = rpt;
            }
            else if (Request.QueryString["value"] == "EmployeeDatewise")
            {
                EmployeeDatewise rpt = new EmployeeDatewise();
                rpt.SetDataSource(db.Employees.ToList());
                CrystalReportViewer1.ReportSource = rpt;
            }
            else if (Request.QueryString["value"] == "EmployeeSalarywise")
            {
                EmployeeSalarywise rpt = new EmployeeSalarywise();
                rpt.SetDataSource(db.Employees.ToList());
                CrystalReportViewer1.ReportSource = rpt;
            }
            else if (Request.QueryString["value"] == "IndividualReport" && Request.QueryString["E_id"] != null)
            {
                IndivdualReport rpt = new IndivdualReport();
                int id = Convert.ToInt32(Request.QueryString["E_id"]);
                rpt.SetDataSource(db.Employees.Where(m=>m.Employee_id== id).ToList());
                CrystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                CrystalReportViewer1.ReportSource = null;
                CrystalReportViewer1.Visible = false;
            }
        }

       
    }
}
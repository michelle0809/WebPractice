using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjTestDashboard.Models;
using prjTestDashboard.ViewModel;

namespace prjTestDashboard.Controllers
{
    public class HomeController : Controller
    {
        readonly dbDashboardEntities db = new dbDashboardEntities();
        // GET: Home
        public ActionResult Index()
        {
            var tables = new dbViewModel
            {
                staff = db.t_staff.ToList(),
                tools = db.t_tool.ToList(),

                // A 產線人員在各區的分配人數
                staff_dist = (
                    from a in db.t_staff.Where(u => u.dept == "產線單位")
                    join b in db.t_tool
                    on a.tool_id equals b.tool_id
                    group a by b.area into c
                    select new t_staff_dist
                    {
                        area = c.Key,
                        user_cnt = c.Count()
                    }),

                // B 機台在區域的分佈
                tool_dist = (
                    from a in db.t_tool
                    group a by a.area into c
                    select new t_tool_dist
                    {
                        area = c.Key,
                        tool_cnt = c.Count()
                    }),

                // C 機台目前的狀態統計
                status_dist = (
                    from a in db.t_tool
                    group a by a.status into c
                    select new t_status_dist
                    {
                        status = c.Key,
                        tool_cnt = c.Count()
                    }),

                // D 當日機台生產總量統計
                total_move = (int)db.t_tool.Sum(t => t.move),

                // E 目前當機中的機台與清單
                down_tools = db.t_tool.Where(t => t.status == "當機").OrderBy(t => t.status_time).ToList(),

                // F 機台目前分配給不同人員單位的分佈
                dept_dist = (
                    from a in db.t_staff
                    join b in db.t_tool
                    on a.tool_id equals b.tool_id
                    group a by a.dept into c
                    select new t_dept_dist
                    {
                        dept = c.Key,
                        user_cnt = c.Count()
                    })

            };

            return View(tables);
        }
    }
}
using prjTestDashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjTestDashboard.ViewModel
{
    public class dbViewModel
    {
        public IEnumerable<t_staff> staff { get; set; }
        public IEnumerable<t_tool> tools { get; set; }
        public IEnumerable<t_staff_dist> staff_dist { get; set; } // A 產線人員在各區的分配人數
        public IEnumerable<t_tool_dist> tool_dist { get; set; } // B 機台在區域的分佈
        public IEnumerable<t_status_dist> status_dist { get; set; } // C 機台目前的狀態統計
        public int total_move { get; set; } // D 當日機台生產總量統計
        public IEnumerable<t_tool> down_tools { get; set; } // E 目前當機中的機台與清單
        public IEnumerable<t_dept_dist> dept_dist { get; set; } // F 機台目前分配給不同人員單位的分佈

    }

    public partial class t_staff_dist // A 產線人員在各區的分配人數
    {
        public string area { get; set; }
        public int user_cnt { get; set; }
    }

    public partial class t_tool_dist // B 機台在區域的分佈
    {
        public string area { get; set; }
        public int tool_cnt { get; set; }
    }

    public partial class t_status_dist // C 機台目前的狀態統計
    {
        public string status { get; set; }
        public int tool_cnt { get; set; }
    }

    public partial class t_dept_dist // F 機台目前分配給不同人員單位的分佈
    {
        public string dept { get; set; }
        public int user_cnt { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelper
{
    internal class Student
    {
        [DisplayName("學生姓名")]
        public string Name { get; set; }

        [DisplayName("學生編號")]
        public string Id { get; set; }

        [DisplayName("學生成績")]
        public string Grade {  get; set; }
    }
}

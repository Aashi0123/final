using System;
using System.Collections.Generic;
using System.Text;

namespace class_diagram
{
    public interface Salary : Employee
    {
        int basepay { get; set; }
        int overtimehours { get; set; }
        int overtimepay { get; set; }
        int unitpay { get; set; }
        int grosspay { get; set; }

        void calculate_salary();
    }
}
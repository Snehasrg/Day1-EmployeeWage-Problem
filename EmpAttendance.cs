﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpAttendance
    {
        public static void EmpComputation()
        {
            int Is_Full_Time = 1;
            Random R = new Random();
            int empCheck = R.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}

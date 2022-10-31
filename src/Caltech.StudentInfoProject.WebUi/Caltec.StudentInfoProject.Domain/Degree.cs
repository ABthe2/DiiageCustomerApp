﻿using Caltec.StudentInfoProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caltec.StudentInfoProject.Domain
{
    public class Degree : EntityBase
    {
        public Degree()
        {
            StudentClasses = new List<StudentClass>();
        }
        public string? Name { get; set; }
        public int NbYear { get; set; }
        public decimal FeesPerYearPerStudent { get; set; }
        public int NbPayment { get; set; }

        public List<StudentClass> StudentClasses { get; set; }
       
    }
}

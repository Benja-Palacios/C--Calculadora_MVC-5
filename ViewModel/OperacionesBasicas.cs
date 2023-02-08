using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionCalculadora.ViewModel
{
    public class OperacionesBasicas
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public bool opSuma { get; set; }
        public bool opResta { get; set; }
        public bool opMulti { get; set; }
        public bool opDivicion { get; set; }
    }
}
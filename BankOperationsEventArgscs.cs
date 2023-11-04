using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary
{
    public class BankOperationsEventArgs
    {
        public string Message { get; }
        public double Sum { get; }
        public BankOperationsEventArgs(string message, double sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
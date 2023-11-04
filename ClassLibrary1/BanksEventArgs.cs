using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryBanking
{
    public class BanksEventArgs
    {
        public string Message { get; }
        public BanksEventArgs(string message)
        {
            Message = message;
        }
    }
}

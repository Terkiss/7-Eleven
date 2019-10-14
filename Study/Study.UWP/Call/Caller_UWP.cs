using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Study.Models;
using Xamarin.Forms;
using Study.UWP.Call;

[assembly: Dependency(typeof(Caller_UWP))]
namespace Study.UWP.Call
{
    class Caller_UWP : IDialer 
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("UWP 에서 전화를 걸고 있습니다.");
                return true;
        }
    }
}

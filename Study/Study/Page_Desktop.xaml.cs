using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Study.Models;

namespace Study
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_Desktop : ContentPage
    {
        public Page_Desktop()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("버튼이 눌림!");

            // 재생 관련 처리
            JeongSound jeong = DependencyService.Get<JeongSound>();

            if (jeong == null)
            {
                System.Diagnostics.Debug.WriteLine(" 빈객체 입니다.");
            }
            else
            {
                jeong.SoundPlayer("scanAudio.wav");
      
                System.Diagnostics.Debug.WriteLine("사운드 재생중");
            }
        }
    }
}
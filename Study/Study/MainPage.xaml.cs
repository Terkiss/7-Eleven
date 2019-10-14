//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace Study
//{
//    // Learn more about making custom code visible in the Xamarin.Forms previewer
//    // by visiting https://aka.ms/xamarinforms-previewer
//    [DesignTimeVisible(false)]
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();
//        }
//    }
//}



using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Xamarin.Forms;

using Study.Models;


namespace Study

{

    public partial class MainPage : ContentPage

    {

        public MainPage()

        {
            
            InitializeComponent();
        
        }

        //private void InitializeComponent()
        //{
        //    global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(App));
        //}


        private void Button_Clicked(object sender, EventArgs e)

        {

            System.Diagnostics.Debug.WriteLine("버튼이 눌림!");

        }
        private void Csll_Dial(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("전화를 겁니다 ");
            IDialer dialer = DependencyService.Get<IDialer>();
            if (dialer == null)
            {
                System.Diagnostics.Debug.WriteLine(" 빈객체 입니다.");
            }
            else
            {
                dialer.dial("010 - 7535 - 7836");
                System.Diagnostics.Debug.WriteLine("010 - 7535 - 7836 번호로 전화를 겁니다");
            }

            JeongSound sound = DependencyService.Get<JeongSound>();

            if (sound == null)
            {
                System.Diagnostics.Debug.WriteLine("빈객체 입니다.");

            }
            else
            {
                sound.SoundPlayer("asd");
            }


        }

    }

}


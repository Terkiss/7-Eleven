using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Media;
using Xamarin.Forms;
using Study.Droid.Script;
using Study.Models;

[assembly: Dependency(typeof(SoundPlay_Android))]
namespace Study.Droid.Script
{

    class SoundPlay_Android : JeongSound
    {
        MediaPlayer player;
        public bool SoundPlayer(string FileName)
        {
            if (player == null)
            {
                player = MediaPlayer.Create(Android.App.Application.Context, Resource.Raw.scanAudio);
            }
            if (FileName.Length == 0)
            {
                return false;
            }
            playsAsync(FileName);

            return false;

        }
 
        private  void playsAsync(string FileName)
        {           
            player.Start();
        }
    }
}
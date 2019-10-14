using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Study.Models;
using Study.UWP.SoundPlayer;
using Xamarin.Forms;


using Windows.Media.Playback;
using Windows.Media.Core;
[assembly: Dependency(typeof(SoundPlayer_UWP))]
namespace Study.UWP.SoundPlayer
{
    class SoundPlayer_UWP : JeongSound
    {
        MediaPlayer player =null ;
        MediaSource source = null;
        public bool SoundPlayer(string FileName)
        {
            if (player == null)
            {
                player = new MediaPlayer();
            }
            if (source == null)
            {
                playsAsync(FileName);
            }

            player.Play();

            return false;

        }
        private async void playsAsync(string FileName)
        {

            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            
            System.Diagnostics.Debug.WriteLine("folder \n"+folder);
            Windows.Storage.StorageFile file = await folder.GetFileAsync("ScanAudio.m4a");



            player.AutoPlay = false;
            source = MediaSource.CreateFromStorageFile(file);
            player.Source = source;
      

          //  player.Play();
        }
      
    }
}

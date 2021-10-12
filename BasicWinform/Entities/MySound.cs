using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities
{
    class MySound
    {
        public MySound(string fname)
        {
            FileName = fname;
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public void Play()
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(FileName);
                player.Play();
            }
            catch(Exception e){
                e.Message.ToString();
            }
        }
    }
}

using System;
using System.IO;
using VideoLibrary;

namespace Youtube_Downloader_Mp4_and_Mp3
{
    internal class Downloader
    {
        public string VideoName { get; set; }
        public int Audio_bitrate { get; set; }
        public int Cozunurluk { get; set; }

        private string Url;

        public Downloader(string url)
        {
            Url = url;
            GetInfo();
        }

        private void GetInfo()
        {
            try
            {
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(Url);

                VideoName = vid.FullName;
                Cozunurluk = vid.Resolution;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool VideoDownload(string path)
        {
            try
            {
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(Url);

                File.WriteAllBytes(path + vid.FullName, vid.GetBytes());
                GC.Collect();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
    }
}

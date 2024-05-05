using MediaToolkit;
using MediaToolkit.Model;
using System;

namespace Youtube_Downloader_Mp4_and_Mp3
{
    internal class Donustur
    {
        public bool Mp4toMp3(string Path, string VideFullName)
        {
            try
            {
                var inputFile = new MediaFile { Filename = Path + "\\" + VideFullName };
                var outputFile = new MediaFile { Filename = $"{Path + "\\" + VideFullName.Replace(".mp4", "")}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }



                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

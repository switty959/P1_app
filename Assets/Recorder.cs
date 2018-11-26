using UnityEditor.Media;
using UnityEngine;
using Unity.Collections;
using System.IO;

public class Recorder : MonoBehaviour
{
    public void RecordMovie()
    {
        var videoAttr = new VideoTrackAttributes
        {
            frameRate = new MediaRational(50),
            width = 320,
            height = 200,
            includeAlpha = false
        };

        var audioAttr = new AudioTrackAttributes
        {
            sampleRate = new MediaRational(48000),
            channelCount = 2,
            language = "fr"
        };

        int sampleFramesPerVideoFrame = audioAttr.channelCount *
            audioAttr.sampleRate.numerator / videoAttr.frameRate.numerator;

        var encodedFilePath = Path.Combine(Path.GetTempPath(), "my_movie.mp4");

        Texture2D tex = new Texture2D((int)videoAttr.width, (int)videoAttr.height, TextureFormat.RGBA32, false);

        using (var encoder = new MediaEncoder(encodedFilePath, videoAttr, audioAttr))
        using (var audioBuffer = new NativeArray<float>(sampleFramesPerVideoFrame, Allocator.Temp))
        {
            for (int i = 0; i < 100; ++i)
            {
                // Fill 'tex' with the video content to be encoded into the file for this frame.
                // ...
                encoder.AddFrame(tex);

                // Fill 'audioBuffer' with the audio content to be encoded into the file for this frame.
                // ...
                encoder.AddSamples(audioBuffer);
            }
        }
    }
   
 }
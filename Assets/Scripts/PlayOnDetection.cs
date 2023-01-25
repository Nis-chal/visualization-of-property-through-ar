using UnityEngine;
using UnityEngine.Video;

public class PlayOnDetection : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void OnTargetFound()
    {
        videoPlayer.Play();
    }
}

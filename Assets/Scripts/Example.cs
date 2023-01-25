using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Vuforia;

public class Example : MonoBehaviour
{
   
    public VirtualButtonBehaviour vb;
    public VirtualButtonBehaviour vbpause;
    public VirtualButtonBehaviour vbstop;


    public VideoPlayer videoPlayer;
 

    void Start()
    {
      
        // vbBtnObj?.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vbpause.RegisterOnButtonPressed(OnButtonPressed2);
        vbstop.RegisterOnButtonPressed(OnButtonPressed3);


       
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        PlayVideo();
    }

     public void OnButtonPressed2(VirtualButtonBehaviour vb)
    {
        PauseVideo();
    }

     public void OnButtonPressed3(VirtualButtonBehaviour vb)
    {
        StopVideo();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // you can add some action here if you want
    }

    void PlayVideo()
    {
        videoPlayer.Play();
    }

    void PauseVideo()
    {
        videoPlayer.Pause();
    }

     void StopVideo()
    {
        videoPlayer.Stop();
    }



}

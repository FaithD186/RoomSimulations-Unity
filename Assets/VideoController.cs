using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public string url;
    public VideoPlayer vidplayer;
    public GameObject StartButton;
    public GameObject PauseIcon;
    // Start is called before the first frame update
    void Start()
    {
    //    vidplayer = GetComponent<VideoPlayer>();
       vidplayer.url = url;
    }

    public void StartVideo(){
        vidplayer.time = 0;
        vidplayer.Play();
        StartButton.SetActive(false);
        PauseIcon.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private long lastFrame;
    public GameObject PausePanel;
    public GameObject Resume;
    public GameObject BacktoMenu;
    public GameObject Replay;
    public GameObject StartButton;
    public GameObject PauseButton;
    // Start is called before the first frame update
    void Start(){
        PausePanel.SetActive(false);
        PauseButton.SetActive(false);
    }
    public void PauseClicked(){
        PausePanel.SetActive(true);
        videoPlayer.Pause();
       
    }
    public void StartVideo(){
        videoPlayer.Play();
        StartButton.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void ResumeClicked(){
        PausePanel.SetActive(false);
        videoPlayer.Play();
        
    }
    public void BacktoMenuClicked(){
        // go back to main menu
        SceneManager.LoadScene("Main Menu");
    }
    public void ReplayScene(){
        PausePanel.gameObject.SetActive(false);
        videoPlayer.time = 0;
        videoPlayer.Play();
    }
}

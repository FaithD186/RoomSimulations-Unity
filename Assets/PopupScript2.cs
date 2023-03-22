using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PopupScript2 : MonoBehaviour
{
   public VideoPlayer VideoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
   public GameObject Panel;
   public GameObject wrongAnswer;
   public GameObject rightAnswer;
   public GameObject ChoiceA;
   public GameObject ChoiceB;
   public GameObject ChoiceC;
   public GameObject ChoiceD;
   public GameObject Submit;
   public GameObject Continue;
   public GameObject PauseButton;
   public GameObject Replay;
   private string chosenButtonName;


    void Start()
    {
        VideoPlayer.loopPointReached += LoadPanel;
        Panel.gameObject.SetActive(false);
        // PauseButton.SetActive(false);
        chosenButtonName = "None";
    }
    public void OnButtonAClick()
    {
        chosenButtonName = "A";
        wrongAnswer.SetActive(false);
        rightAnswer.SetActive(false);
        Continue.SetActive(false);
    }

    public void OnButtonBClick()
    {
        chosenButtonName = "B";
        wrongAnswer.SetActive(false);
        rightAnswer.SetActive(false);
        Continue.SetActive(false);
    }

    public void OnButtonCClick()
    {
        chosenButtonName = "C";
        wrongAnswer.SetActive(false);
        rightAnswer.SetActive(false);
        Continue.SetActive(false);
    }
    public void OnButtonDClick()
    {
        chosenButtonName = "D";
        wrongAnswer.SetActive(false);
        rightAnswer.SetActive(false);
        Continue.SetActive(false);
    }

    public void LoadPanel(VideoPlayer vp)
    {
        Panel.gameObject.SetActive(true);
        chosenButtonName = "None";
        PauseButton.SetActive(false);

    }

    public void CheckAnswer(){
        if (chosenButtonName == "None"){
            rightAnswer.SetActive(false);
            wrongAnswer.SetActive(false);
            Continue.SetActive(false);
        }
        else if (chosenButtonName != "B"){
            wrongAnswer.SetActive(true);
        }else{
            rightAnswer.SetActive(true);
            Continue.SetActive(true);
        }
    }
    public void ContinueScene(){
        Panel.gameObject.SetActive(false);
        SceneManager.LoadScene("NextScene");
        // replace with SceneManager and go to the next video
    }
    public void ReplayClicked(){
        chosenButtonName = "None";
        rightAnswer.SetActive(false);
        wrongAnswer.SetActive(false);
        Panel.gameObject.SetActive(false);
        Continue.SetActive(false);
        PauseButton.SetActive(true);
        VideoPlayer.time = 0;
        VideoPlayer.Play();
    }
}
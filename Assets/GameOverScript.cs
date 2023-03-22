using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject BacktoMenu;
    public GameObject Replay;
    public void BackMenu(){
        // go back to main menu
        SceneManager.LoadScene("Main Menu");
    }

    public void ReplayScene(){
        SceneManager.LoadScene("Game");
    }
}

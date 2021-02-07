using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
    
{
    public GameObject mainmenu;
     public void playGame() {
        SceneManager.LoadScene(1);
    }
 
 
    public void exitGame() {
        Application.Quit();
    }
}

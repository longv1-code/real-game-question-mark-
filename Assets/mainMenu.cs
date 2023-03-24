using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//testing...plz work. hello if you see this. hehe. <3 toot toot
public class mainMenu : MonoBehaviour
{
    
    public void playGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {   
        Debug.Log("Quit!");
        Application.Quit();
    }

}

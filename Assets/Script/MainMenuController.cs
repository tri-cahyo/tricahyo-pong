using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("created by tri");
    }

    public void OpenAuthor()
    {
        Debug.Log("created by love");
    }
        
    
}

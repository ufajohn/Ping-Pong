using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoaderScenes : MonoBehaviour
{    
    public void LoadOnlineScene()
    {
        SceneManager.LoadScene("OnlineScene"); 
    }
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    } public void LoadSinglePlayerScene()
    {
        SceneManager.LoadScene("SinglePlayerScene");
    }
}

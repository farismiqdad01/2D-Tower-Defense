using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void GotoGameplay(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void DoExitGame()
    {
        Application.Quit();
    }
}

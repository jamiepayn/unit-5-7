using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadScene (string level)
    {
        SceneManager.LoadScene(level);
    }

    public void quitgame ()
    {
        Application.Quit();
    }
}

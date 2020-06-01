using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mam : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}

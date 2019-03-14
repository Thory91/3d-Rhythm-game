using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void menu()
    {
        Time.timeScale = 1;
        GameManager.instance.tilenum = 1;
        SceneManager.LoadScene("Menu 3D");
    }

    public void song1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Song1");
    }

    public void song2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Song2");
    }
}

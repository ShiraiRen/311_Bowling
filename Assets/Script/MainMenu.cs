using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Enterthebattlefield()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void Leavethebattlefield()
    {
        Application.Quit();
    }
}
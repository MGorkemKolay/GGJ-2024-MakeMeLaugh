using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class MainMenu : MonoBehaviour
{
    public void ordu()
{
    SceneManager.LoadScene("Level1");
}
    public void konya()
{
    SceneManager.LoadScene("Level2");
}
    public void kocaeli()
{
    SceneManager.LoadScene("Level3");
}
    public void izmir()
{
    SceneManager.LoadScene("Level4");
}
    public void istanbul()
{
    SceneManager.LoadScene("Level5");
}
    public void QuitGame()
{
    Debug.Log("Oyundan cikildi");
    Application.Quit();
}
    public void ReturnToMainMenu()
{
    SceneManager.LoadScene("MainMenu");
}
}

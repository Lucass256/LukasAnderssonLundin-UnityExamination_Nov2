using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void StartScene1()
    {
        SceneManager.LoadScene("NextScene");
    }

    public void StartScene2()
    {
        SceneManager.LoadScene("Background");
    }
    
    
    
}

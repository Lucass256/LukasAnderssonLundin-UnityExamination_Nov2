using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void StartScene1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void StartScene2()
    {
        SceneManager.LoadScene("TestScene");
    }
    
    
    
}

using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBindTest : MonoBehaviour
{
    public InputActionAsset stevensPlayerAction;
    public Animator stevensAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stevensPlayerAction.FindAction("Move").IsPressed()) 
        {
            stevensAnimator.SetBool("isMoving", true);
        }
        else stevensAnimator.SetBool("isMoving", false);
    }
}

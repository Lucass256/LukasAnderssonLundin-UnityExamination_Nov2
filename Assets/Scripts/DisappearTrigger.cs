using UnityEngine;

public class DisappearTrigger : MonoBehaviour
{
    public GameObject objectToDisappear;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            objectToDisappear.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

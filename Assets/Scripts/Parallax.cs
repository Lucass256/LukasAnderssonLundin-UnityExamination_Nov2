using UnityEngine;

// For distant background layers (e.g. far-away houses) that should barely move with the camera.
public class DistantParallax : MonoBehaviour
{
    private float startPos;
    [SerializeField] private GameObject cam;
    [SerializeField, Range(0f, 1f), Tooltip("0 = fully static, 1 = moves with the camera. Keep small for distant layers.")]
    private float parallaxEffect = 0.05f;

    void Start()
    {
        startPos = transform.position.x;
    }

    // FixedUpdate keeps this in step with the physics-driven camera target, avoiding the stutter LateUpdate shows at high frame rates.
    void FixedUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
    }
}

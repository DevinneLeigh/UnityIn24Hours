using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float moveSpeed = .1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis ("Horizontal") * moveSpeed;
        float zMovement = Input.GetAxis ("Vertical") * moveSpeed;
        transform.Translate(xMovement, 0f, zMovement);
            
    }
}

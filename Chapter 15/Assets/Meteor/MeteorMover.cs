using UnityEngine;

public class MeteorMover : MonoBehaviour
{
    public float speed = -2f;

    private Rigidbody2D _rigidBody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.linearVelocity = new Vector2(0, speed);
    }

}

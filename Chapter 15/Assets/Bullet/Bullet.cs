using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    GameManager _gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = GameObject.FindFirstObjectByType<GameManager>();
        
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.linearVelocity = new Vector2(0f, speed);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        _gameManager.AddScore();
        Destroy(gameObject);
    }
}

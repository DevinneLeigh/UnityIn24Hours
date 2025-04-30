using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;
    private float _elapsedTime;
    
    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal");
        transform.Translate (xInput * speed * Time.deltaTime, 0f, 0f);
        
        Vector3 position = transform.position;
        position.x = Mathf.Clamp (position.x, -xLimit, xLimit);
        transform.position = position;

        if (Input.GetButton("Jump") && _elapsedTime > reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0f, 1.2f, 0f);
            Instantiate (bulletPrefab, spawnPos, Quaternion.identity);

            _elapsedTime = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.PlayerDied();
    }
}

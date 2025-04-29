using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    // A reference to the scene camera. 
    public GameObject mainCamera;
    
    public float moveSpeed = .5f;
    public float rotateSpeed = 3f;
    
    Vector3 _originalScale;
    Vector3 _doubleScale;
    bool _isEnlarged;

    void Start()
    {
        _originalScale = transform.localScale;
        _doubleScale = _originalScale * 2;
        _isEnlarged = false;
    }

    void Update ()
    {
        float xMovement = Input.GetAxis ("Horizontal") * moveSpeed;
        float zMovement = Input.GetAxis ("Vertical") * moveSpeed;
        transform.Translate(xMovement, 0f, zMovement);

        float camRotation = Input.GetAxis ("Mouse Y") * rotateSpeed;
        float cubeRotation = -Input.GetAxis ("Mouse X") * rotateSpeed;
        transform.Rotate(0f, cubeRotation, 0f);
        mainCamera.transform.Rotate(camRotation, 0f, 0f);

        if (Input.GetKeyDown (KeyCode.M))
        {
            if (_isEnlarged)
            {
                _isEnlarged = false;
                transform.localScale = _originalScale;
            }
            else
            {
                _isEnlarged = true;
                transform.localScale = _doubleScale;
            }
        }
    }
}


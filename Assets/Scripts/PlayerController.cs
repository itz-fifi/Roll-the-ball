using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    float xInput;
    float yInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update() //mainly used for input
    {
        if (transform.position.y < -5) //if the ball falls off the platform
        {
            SceneManager.LoadScene("Game"); //reloads the current scene
        }
    }
    
    private void FixedUpdate() //mainly used for physics properties. gives us smoother movements
    {
        xInput = Input.GetAxis("Horizontal"); //left and right arrow keys
        yInput = Input.GetAxis("Vertical"); //up and down arrow keys
        
        rb.AddForce(xInput * speed, 0, yInput * speed); //to move the ball
    }
}

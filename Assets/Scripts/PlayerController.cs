using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    float xInput;
    float yInput;

    int score = 0;
    public int winningScore = 5; 

    public gameObject winText; //reference to the win text object



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

    private void OnTriggerEnter(Collider other) //other variable stores the object that collides with the player(object is coin)
    {
        if (other.gameObject.tag == "Coin") //if the player collides with a coin
        {
            other.gameObject.SetActive(false); //deactivates the coin
            score++; //increments the score by 1

            if(score >= winningScore) //if the score is greater than or equal to the winning score
            {
                winText.SetActive(true); //activates the win text
            }
        }
    }
}

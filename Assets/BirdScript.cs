using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D rigidbody2d;
    public float flapSpeed;
    public LogicScript logicScript; // Reference to the LogicScript
    public bool isPlaying = true; // Flag to check if the game is over

    public void flap()
    {
        Debug.Log("fly");
        rigidbody2d.linearVelocity = new Vector2(0, flapSpeed);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Bird";
        logicScript = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isPlaying)
        {
            // Debug.Log("Space pressed!");
            flap(); // Call the flap method when space is pressed
        }

        if (transform.position.y < -16f || transform.position.y > 14)
        {
            Debug.Log("Bird off the screen, game over!");
            logicScript.gameOver(); // Call game over method from LogicScript
            isPlaying = false; // Set the flag to false to stop further flapping
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.layer == 6) // let Layer 6 for pipes
        {
            Debug.Log("Game Over!");
            logicScript.gameOver(); // Call game over method from LogicScript
            isPlaying = false; // Set the flag to false to stop further flapping
        }
    }
}


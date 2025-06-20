using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -24f)
        {
            Debug.Log("Pipe is off-screen, destroying it.");
            Destroy(gameObject); // Destroy the pipe if it goes off-screen
        }
    }
}

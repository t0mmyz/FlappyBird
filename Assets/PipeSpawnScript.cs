using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipePrefab; // Reference to the pipe prefab
    public float spawnInterval = 2f; // Time interval between spawns
    public float upSpawnRange = 7.5f;
    public float downSpawnRange = 3f;

    private float timer = 0f; // Timer to track spawn time

    private void spawen(float yPos)
    {
        Instantiate(pipePrefab, new Vector3(transform.position.x, yPos, transform.position.z), transform.rotation);

    }

    private float randomY()
    {
        float highest = transform.position.y + upSpawnRange;
        float loweest = transform.position.y - downSpawnRange;

        return Random.Range(loweest, highest);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawen(randomY());
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnInterval)
        {
            timer += Time.deltaTime;
        }
        else {
            
            spawen(randomY());
            timer = 0f; // Reset the timer after spawning
        }



    }

    
}

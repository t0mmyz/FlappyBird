using UnityEngine;


public class ScoreTriggerScript : MonoBehaviour
{

    public LogicScript logicScript; // Reference to the logic script

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicScript.updateScore(1); // Call the updateScore method from LogicScript when the trigger is entered
        }
    }
}

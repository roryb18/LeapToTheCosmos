using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{

    [SerializeField] private GameObject[] checkpoints;
    private int currentCheckpointIndex = 0;

    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(checkpoints[currentCheckpointIndex].transform.position, transform.position) < .05f)
        {
            currentCheckpointIndex++;
            if (currentCheckpointIndex >= checkpoints.Length)
            {
                currentCheckpointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, checkpoints[currentCheckpointIndex].transform.position, Time.deltaTime * speed);
    }
}

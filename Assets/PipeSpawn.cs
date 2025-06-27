using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;

    // 2 seconds between each pipe spawn
    public float spawnRate = 1.5f;

    public float timer = 0;

    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        // spawn a pipe immediately
        spawnPipe();

    }

    // Update is called once per frame
    void Update()
    {
        
        // make pipes spawn every 2 seconds
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // spawn a pipe
            spawnPipe();

            // reset the timer
            timer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        
    }
}


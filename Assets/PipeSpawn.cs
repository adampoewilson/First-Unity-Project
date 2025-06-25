using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;

    // 2 seconds between each pipe spawn
    public float spawnRate = 2;

    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
    

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

            Instantiate(pipe, transform.position, transform.rotation);

            timer = 0;
        }

        
        
    }
}

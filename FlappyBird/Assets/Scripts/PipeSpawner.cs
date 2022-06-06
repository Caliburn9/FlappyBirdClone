using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    float timer = 0;
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    void spawnPipe()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newpipe, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            spawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}

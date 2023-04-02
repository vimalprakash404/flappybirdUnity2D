using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawn : MonoBehaviour
{
    //Pipe Gameobject or Prefab
    public GameObject pipe;
    public float spawnrate = 2;
    public float hieght = 10;
    private float timer = 0;
    // Update is called once per frame
     void Start()
    {
        spawnpipe();
    }
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawnpipe();
            timer = 0;
        }
       
    }
    void spawnpipe()
    {
        float lowest = transform.position.y - hieght;
        float highest = transform.position.y + hieght;
        Instantiate(pipe,  new Vector3(transform.position.x,Random.Range(lowest,highest),0), transform.rotation);
    }
}

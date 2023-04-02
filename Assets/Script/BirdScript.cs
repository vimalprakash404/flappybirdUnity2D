using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Rigidbody2D rigidbody2D;
    public float strength;
    public Logic Logic;
    public bool birdAlive = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&birdAlive)
        {
            rigidbody2D.velocity = Vector2.up * strength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        Logic.gameover();
    }
}

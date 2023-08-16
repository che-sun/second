using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manbou : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("manbou");
        rb = player.GetComponent<Rigidbody2D>();
    }
    void playercontroller()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            rb.velocity = new Vector2(0, 10);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            rb.velocity = new Vector2(-10, 0);
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            rb.velocity = new Vector2(0, -10);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rb.velocity = new Vector2(10, 0);
        }
        if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.A) == true)
        {
            rb.velocity = new Vector2(-10, 10);
        }
        if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.D) == true)
        {
            rb.velocity = new Vector2(10, 10);
        }
        if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.A) == true)
        {
            rb.velocity = new Vector2(-10, -10);
        }
        if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.D) == true)
        {
            rb.velocity = new Vector2(10, -10);
        }
    }
    // Update is called once per frame
    void Update()
    {
        playercontroller();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fish : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject gamemaster;
    gm gm;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(10, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "fish";
            SceneManager.LoadScene("gameover");
        }
    }
}
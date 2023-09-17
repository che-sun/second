using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buble : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject gamemaster;
    gm gm;
    Transform manboutrans;
    GameObject player;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 10);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "buble";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
    }
}

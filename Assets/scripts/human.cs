using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class human : MonoBehaviour
{
    float timer;
    GameObject gamemaster;
    gm gm;
    Rigidbody2D rb;
    Transform manboutrans;
    GameObject player;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        gm = gamemaster.GetComponent<gm>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 2)
        {
            rb.velocity = new Vector2(0, -10);
        }
        if (timer >= 10)
        {
            rb.velocity = new Vector2(0, 10);
        }
        if (timer >= 12)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "human";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
    }
}

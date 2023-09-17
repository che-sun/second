using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manbou : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr=null;
    GameObject player;
    GameObject gamemaster;
    gm gm;
    Transform manboutrans;
    public bool muteki = false;
    void Start()
    {
        player = GameObject.Find("manbou");
        rb = player.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        manboutrans = player.GetComponent<Transform>();
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
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            rb.velocity = new Vector2(0, -10);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rb.velocity = new Vector2(10, 0);
            sr.flipX = true;
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
    IEnumerator manboujyumyou()
    {
        yield return new WaitForSeconds(15);
        gm.sibouflug = "muteki";
        gm.siboubasyo = manboutrans.position;
        SceneManager.LoadScene("sibougenba");
    }
    void Update()
    {
        playercontroller();
        if (muteki == true)
        {
            this.tag = "muteki";
            StartCoroutine("manboujyumyou");
        }
       
    }
}

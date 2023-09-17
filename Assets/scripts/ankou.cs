using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ankou : MonoBehaviour
{
    float time1;
    bool flug = false;
    bool flug1 = false; 
    GameObject gamemaster;
    gm gm;
    Rigidbody2D rb;
    GameObject player;
    manbou playerscript;
    Transform manboutrans;
    Transform ankoutrans;
    Vector2 ankoupos;
    Vector2 manboupos;
    // スピード
    public float speed = 1.0F;


    void Start()
    {
        player = GameObject.Find("manbou");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        playerscript = player.GetComponent<manbou>();
        manboutrans = player.GetComponent<Transform>();
        ankoutrans = this.GetComponent<Transform>();
        StartCoroutine("ankoujyumyou");

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            playerscript.enabled = false;
            ankoupos = ankoutrans.position;
            manboupos = manboutrans.position;
            time1 = Time.time;
            flug = true;
        }
        if (other.CompareTag("muteki"))
        {
            time1 = Time.time;
            flug1 = true;
            
        }
    }
    IEnumerator ankoujyumyou()
    {
        yield return new WaitForSeconds(15);
        Destroy(this.gameObject);
    }
 
    void Update()
    {
        if (flug == true)
        {
            float present_Location = Mathf.Clamp01(((Time.time - time1) * speed) / 3);
            manboutrans.position = Vector2.Lerp(manboupos, ankoupos, present_Location);
        }
        if(flug==true&&Time.time - time1 > 3)
        {
            gm.sibouflug = "ankou";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
        if (flug1 == true && Time.time - time1 < 3)
        {
            rb.velocity = new Vector2(-20, 10);
        }
        if (flug1 == true && Time.time - time1 > 3)
        {
            Destroy(this.gameObject);
        }

    }
}


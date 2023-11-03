using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fish : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject gamemaster;
    gm gm;
    Transform manboutrans;
    GameObject player;
    float time1;
    bool flug1=false;
    int a=1;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        StartCoroutine("fishjyumyou");
        if (bgmflug.hardflug >= 10)
        {
            a = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flug1 == false)
        {
            rb.velocity = new Vector2(20*a, 0);
        }
        if (flug1 == true && Time.time - time1 < 3)
        {
            rb.velocity = new Vector2(-20*a, 10*a);
        }
        if (flug1 == true && Time.time - time1 > 3)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator fishjyumyou()
    {
        yield return new WaitForSeconds(20);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "fish";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
        if (other.CompareTag("muteki"))
        {
            time1 = Time.time;
            flug1 = true;
        }
        if (other.CompareTag("tan"))
        {
            time1 = Time.time;
            flug1 = true;
        }
    }
}

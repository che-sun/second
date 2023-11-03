using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class shark : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject gamemaster;
    gm gm;
    bool flug1=false;
    float time1;
    int a=1;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        StartCoroutine("sharkjyumyou");
        if (bgmflug.hardflug >= 10)
        {
            a = 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flug1 == true && Time.time - time1 < 3)
        {
            rb.velocity = new Vector2(20*a, 10*a);
        }
        if (flug1 == true && Time.time - time1 > 3)
        {
            Destroy(this.gameObject);
        }
        if (flug1 == false)
        {
            rb.velocity = new Vector2(-20*a, 0);
        }
    }
    IEnumerator sharkjyumyou()
    {
        yield return new WaitForSeconds(20);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "shark";
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

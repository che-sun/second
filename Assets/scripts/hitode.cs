using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hitode : MonoBehaviour
{
    Rigidbody2D rb;
    PolygonCollider2D hcollider;
    GameObject gamemaster;
    gm gm;
    bool flug = false;
    bool flug1 = false;
    float time1;
    Transform manboutrans;
    GameObject player;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        hcollider = this.gameObject.GetComponent<PolygonCollider2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        StartCoroutine("hitodehantei");
        rb.AddForce(new Vector2(6, 10), ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

        if (flug1 == true && Time.time - time1 < 3)
        {
            rb.velocity = new Vector2(20, 10);
        }
        if (flug1 == true && Time.time - time1 > 3)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator hitodehantei()
    {
        yield return new WaitForSeconds(0.5f);
        hcollider.enabled = true;
        yield return new WaitForSeconds(15);
        Destroy(this.gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="yuka"&&flug==false)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector2(6, 10), ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "yuka" && flug == true)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector2(-6, 10), ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "migi")
        {
            flug = true;
        }
        if (collision.gameObject.tag == "hidari")
        {
            flug = false;
        }
        if (collision.gameObject.tag == "manbou")
        {
            gm.sibouflug = "hitode";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
        if (collision.gameObject.tag == "muteki")
        {
            time1 = Time.time;
            hcollider.enabled = false;
            flug1 = true;
        }
    }
}

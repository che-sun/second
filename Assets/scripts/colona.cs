using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class colona : MonoBehaviour
{
    
    PolygonCollider2D hcollider;
    GameObject gamemaster;
    gm gm;
    bool flug = false;
    bool flug1 = false;
    bool flug2 = false;
    bool flug3 = false;
    float time1;
    Transform colonatrans;
    Transform manboutrans;
    GameObject player;
    Rigidbody2D rb;
    Vector2 colonapos;
    Vector2 manboupos;
    Vector2 up;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        colonatrans = this.gameObject.GetComponent<Transform>();
        hcollider = this.gameObject.GetComponent<PolygonCollider2D>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        StartCoroutine("colonajyumyou");
        StartCoroutine("action");

    }
    IEnumerator action()
    {

        while (true)
        {
            colonapos = colonatrans.position;
            time1 = Time.time;
            flug3 = true;
            yield return new WaitForSeconds(2f);
            flug3 = false;
            colonapos = colonatrans.position;
            manboupos = manboutrans.position;
            time1 = Time.time;
            flug = true;
            yield return new WaitForSeconds(0.5f);
            flug = false;
            colonapos = colonatrans.position;
            up = new Vector2(colonatrans.position.x, 2f);
            time1 = Time.time;
            flug2 = true;
            yield return new WaitForSeconds(1f);
            flug2 = false;
            
        }

    }
    IEnumerator colonajyumyou()
    {
        yield return new WaitForSeconds(20);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            if(gm.sibouflug != "colona-b")
            {
                gm.sibouflug = "colona";
            }
            SceneManager.LoadScene("sibougenba");
        }
        if (other.CompareTag("baria"))
        {
            gm.sibouflug = "colona-a";
            SceneManager.LoadScene("sibougenba");
        }
        if (other.CompareTag("tan"))
        {
            gm.sibouflug = "colona-b";
        }
        if (other.CompareTag("muteki"))
        {
            time1 = Time.time;
            flug1 = true;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (flug1 == true && (Time.time - time1) < 3)
        {
            rb.velocity = new Vector2(20, 10);
        }
        if (flug1 == true && (Time.time - time1) > 3)
        {
            Destroy(this.gameObject);
        }
        if (flug1 == false&&(Time.time - time1) < 0.5f && flug==true)
        {
            float present_Location = Mathf.Clamp01((Time.time - time1) / 0.5f);
            colonatrans.position = Vector2.Lerp(colonapos, manboupos, present_Location);
        }
        if (flug1 == false && (Time.time - time1) < 1 && flug2 == true)
        {
            float present_Location = Mathf.Clamp01((Time.time - time1) / 1);
            colonatrans.position = Vector2.Lerp(colonapos, up, present_Location);
        }
        if (flug1 == false && (Time.time - time1) < 2 && flug3 == true)
        {
            colonatrans.RotateAround(new Vector2(colonapos.x+3, colonapos.y), Vector3.forward, 720 / 2 * Time.deltaTime);
        }
        

    }
}

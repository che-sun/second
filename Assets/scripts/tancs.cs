using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tancs : MonoBehaviour
{
    Rigidbody2D rb;
    bool a;
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        a = bgmflug.flip;
        StartCoroutine("jyumyou");
    }
    IEnumerator jyumyou()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        if (a == false)
        {
            rb.velocity = new Vector2(-15, 0);
        }
        if (a == true)
        {
            rb.velocity = new Vector2(15, 0);
        }
    }
}

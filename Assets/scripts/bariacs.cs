using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bariacs : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    Transform manboutrans;
    Vector2 manboupos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        StartCoroutine("jyumyou");
    }
    IEnumerator jyumyou()
    {
        player.tag = "baria";
        yield return new WaitForSeconds(5);
        player.tag = "manbou";
        Destroy(this.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        manboupos = manboutrans.position;
        this.gameObject.transform.position = manboupos;

    }
}

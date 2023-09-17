using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jumpzone : MonoBehaviour
{
    GameObject gamemaster;
    gm gm;
    Transform manboutrans;
    GameObject player;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "jump";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");
        }
        if (other.CompareTag("buble"))
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        
    }
}

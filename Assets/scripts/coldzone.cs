using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class coldzone : MonoBehaviour
{
    float timer;
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
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            timer = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (timer >= 5)
        {
            gm.sibouflug = "cold";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");

        } 
    }
}

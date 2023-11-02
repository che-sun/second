using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class coldzone : MonoBehaviour
{
    float timer;
    float limit;
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
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            limit = 8;
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            limit = 5;
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            limit = 3.5f;
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            limit = 4;
        }
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
        if (timer >= limit)
        {
            gm.sibouflug = "cold";
            gm.siboubasyo = manboutrans.position;
            SceneManager.LoadScene("sibougenba");

        } 
    }
}

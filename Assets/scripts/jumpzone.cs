using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jumpzone : MonoBehaviour
{
    GameObject gamemaster;
    gm gm;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            gm.sibouflug = "jump";
            SceneManager.LoadScene("gameover");
        }
    }
    void Update()
    {
        
    }
}

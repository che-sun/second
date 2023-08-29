using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class coldzone : MonoBehaviour
{
    float timer;
    GameObject gamemaster;
    gm gm;
    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
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
            SceneManager.LoadScene("gameover");

        } 
    }
}

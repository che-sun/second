using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protein : MonoBehaviour
{
    
    GameObject player;
    manbou playerscript;
    void Start()
    {
        player = GameObject.Find("manbou");
        playerscript = player.GetComponent<manbou>();
        StartCoroutine("proteinjyumyou");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            playerscript.muteki = true;
            bgmflug.mutekibgmflug = true;
            Destroy(this.gameObject);
        }
    }
    IEnumerator proteinjyumyou()
    {
        yield return new WaitForSeconds(30);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

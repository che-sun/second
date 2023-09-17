using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protein : MonoBehaviour
{
    Animator manbouanimator;
    GameObject player;
    manbou playerscript;
    void Start()
    {
        player = GameObject.Find("manbou");
        manbouanimator = player.GetComponent<Animator>();
        playerscript = player.GetComponent<manbou>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("manbou"))
        {
            manbouanimator.SetBool("kimoka", true);
            playerscript.muteki = true;
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

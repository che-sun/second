using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainbgm : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource main;
    public AudioSource muki;

    // BGMÉfÅ[É^
    public AudioClip mainclip;
    public AudioClip mukiclip;
    bool flug1=false;
    bool flug2 = false;

    void Start()
    {
        main.clip = mainclip;
        muki.clip = mukiclip;
        

    }
    // Update is called once per frame
    void Update()
    {

        if (bgmflug.mutekibgmflug == false&&flug1==false)
        {
            main.Play();
            flug1 = true;
        }
        if (bgmflug.mutekibgmflug == true && flug2 == false)
        {
            main.Stop();
            muki.Play();
            flug2 = true;
        }
    }
}

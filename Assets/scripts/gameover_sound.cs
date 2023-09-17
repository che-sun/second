using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover_sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource m_audioIntro;
   

    // BGMÉfÅ[É^
    public AudioClip m_intro;
  

    void Start()
    {
        m_audioIntro.clip = m_intro;
        m_audioIntro.time = 2.3f;
        m_audioIntro.Play();
   
    }

    // Update is called once per frame
    void Update()
    {

    }
}

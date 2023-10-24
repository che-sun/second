using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opbgm : MonoBehaviour
{
    public AudioSource m_audioIntro;
    public AudioSource m_audioLoop;
    float volumevalue;
    // BGMÉfÅ[É^
    public AudioClip m_intro;
    public AudioClip m_loop;

    void Start()
    {
        m_audioIntro.clip = m_intro;
        m_audioLoop.clip = m_loop;
        if (bgmflug.loopflug == false)
        {
            m_audioIntro.Play();
            m_audioLoop.PlayDelayed(m_intro.length);
        }
        if (bgmflug.loopflug == true)
        {
            m_audioLoop.Play();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        volumevalue = PlayerPrefs.GetFloat("volume", 0.5f);
        m_audioIntro.volume = volumevalue;
        m_audioLoop.volume = volumevalue;
    }
}

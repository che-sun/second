using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opse1 : MonoBehaviour
{
    public AudioSource se1;
    // BGMÉfÅ[É^
    public AudioClip m_se1;

    void Start()
    {
        se1.clip = m_se1;
    }
    public void onenter()
    {
        se1.Play();
    }
    // Update is called once per frame
    void Update()
    {
    }
}

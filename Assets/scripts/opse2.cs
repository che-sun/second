using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opse2 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource se2;
    // BGMÉfÅ[É^
    public AudioClip m_se2;

    void Start()
    {
        se2.clip = m_se2;
    }
    public void onenter()
    {
        se2.Play();
    }
    // Update is called once per frame
    void Update()
    {
    }
}

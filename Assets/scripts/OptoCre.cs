using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OptoCre : MonoBehaviour
{

    public AudioSource se1;
    // BGMÉfÅ[É^
    public AudioClip m_se1;

    void Start()
    {
        se1.clip = m_se1;
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void OnClick()
    {
        se1.Play();
        StartCoroutine("go");

    }
    IEnumerator go()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Cregit");
    }
}

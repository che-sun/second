using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openoption : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject optionpanel;
    GameObject parent;
    public AudioSource se1;
    // BGMÉfÅ[É^
    public AudioClip m_se1;
    private void Start()
    {
        parent = GameObject.Find("MainPannel");
        optionpanel = (GameObject)Resources.Load("optionPanel");
        se1.clip = m_se1;
    }
    public void OnClick()
    {
        se1.Play();
        StartCoroutine("go");

    }
    IEnumerator go()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(optionpanel, parent.transform);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hardmode : MonoBehaviour
{
    public AudioSource se1;
    // BGMデータ
    public AudioClip m_se1;
    bool flug=false;
    [SerializeField] Text Text;
    void Start()
    {
        se1.clip = m_se1;
    }
    public void onenter()
    {
        se1.Play();
        bgmflug.hardflug = bgmflug.hardflug + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(bgmflug.hardflug >= 10&&flug==false)
        {
            Text.text = "ハードモードに変更されました";
            StartCoroutine("a");
            flug = true;
        }
    }
    IEnumerator a()
    {
        yield return new WaitForSeconds(6);
        Text.text = "";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sitaikanri : MonoBehaviour
{
    GameObject sitai1;
    GameObject asitai1;
    GameObject sitai2;
    GameObject sitai3;
    GameObject asitai3;
    GameObject huryousitai;
    GameObject queensitai;
    GameObject rougaisitai;
    GameObject huryousitai2;
    GameObject gamemaster;
    Transform asitai1trans;
    Transform asitai3trans;
    public AudioSource m_audioIntro;
    public AudioClip m_intro;
    float volumevalue;
    gm gm;
    bool flug1 = false;
    bool flug2 = false;
    float time1;
    Vector2 sibouba;
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    private ParticleSystem particle;
        
    void Start()
    {
        sitai1 = (GameObject)Resources.Load("manbousitai1");
        sitai2 = (GameObject)Resources.Load("manbousitai2");
        sitai3 = (GameObject)Resources.Load("manbousitai3");
        huryousitai = (GameObject)Resources.Load("huryousitai");
        queensitai = (GameObject)Resources.Load("queensitai");
        rougaisitai = (GameObject)Resources.Load("rougaisitai");
        huryousitai2 = (GameObject)Resources.Load("huryousitai2");
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        sibouba = gm.siboubasyo;
        StartCoroutine("sibou");
    }
    IEnumerator sibou()
    {
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            Instantiate(huryousitai, new Vector2(0, sibouba.y), Quaternion.Euler(0, 0, 0));
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            Instantiate(sitai1, new Vector2(0, sibouba.y), Quaternion.Euler(0, 0, 0));
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            Instantiate(rougaisitai, new Vector2(0, sibouba.y), Quaternion.Euler(0, 0, 0));
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            Instantiate(queensitai, new Vector2(0, sibouba.y), Quaternion.Euler(0, 0, 0));
        }
        yield return new WaitForSeconds(1);
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            asitai1 = GameObject.Find("huryousitai(Clone)");
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            asitai1 = GameObject.Find("manbousitai1(Clone)");
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            asitai1 = GameObject.Find("rougaisitai(Clone)");
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            asitai1 = GameObject.Find("queensitai(Clone)");
        }
        asitai1trans = asitai1.GetComponent<Transform>();
        time1 = Time.time;
        flug1 = true;
        yield return new WaitForSeconds(2);
        flug1 = false;
        Destroy(asitai1);
        if (PlayerPrefs.GetInt("huryoupick", 0) != 1)
        {
            Instantiate(sitai2, new Vector2(0, 0), Quaternion.Euler(0, 0, 0));
        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            Instantiate(huryousitai2, new Vector2(0, 0), Quaternion.Euler(0, 0, 0));
        }
        yield return new WaitForSeconds(0.5f);
        m_audioIntro.clip = m_intro;
        m_audioIntro.time = 1.5f;
        m_audioIntro.Play();
        ParticleSystem newParticle = Instantiate(particle);
        newParticle.transform.position = new Vector3(0,20,0);
        newParticle.Play();
        yield return new WaitForSeconds(3);
        Instantiate(sitai3, new Vector2(0, 0), Quaternion.Euler(0, 0, 0));
        asitai3 = GameObject.Find("manbousitai3(Clone)");
        asitai3trans = asitai3.GetComponent<Transform>();
        time1 = Time.time;
        flug2 = true;
        yield return new WaitForSeconds(5);
        flug2 = false;
        SceneManager.LoadScene("gameover");
    }


        // Update is called once per frame
    void Update()
    {
        volumevalue = PlayerPrefs.GetFloat("volume", 0.5f);
        m_audioIntro.volume = volumevalue;
        if ((Time.time - time1) <= 2&&flug1==true)
        {
            float present_Location = Mathf.Clamp01((Time.time - time1) / 2);
            asitai1trans.position = Vector2.Lerp(new Vector2(0, sibouba.y), new Vector2(0, 0), present_Location);
        }
        if ((Time.time - time1) <= 5 && flug2 == true)
        {
            float present_Location = Mathf.Clamp01((Time.time - time1) / 5);
            asitai3trans.position = Vector2.Lerp(new Vector2(0, 0), new Vector2(0, 6), present_Location);
        }
    }
}

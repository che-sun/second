using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manbou : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr=null;
    GameObject player;
    GameObject gamemaster;
    gm gm;
    Animator manbouanimator;
    Transform manboutrans;
    SpriteRenderer sprite;
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    private ParticleSystem particle;
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル1)")]
    private ParticleSystem particle1;
    public bool muteki = false;
    void Start()
    {
        player = GameObject.Find("manbou");
        rb = player.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        gamemaster = GameObject.Find("gamemaster");
        gm = gamemaster.GetComponent<gm>();
        manboutrans = player.GetComponent<Transform>();
        manbouanimator = player.GetComponent<Animator>();
        sprite = this.gameObject.GetComponent<SpriteRenderer>();
        
    }
    void playercontroller()
    {
        if (PlayerPrefs.GetInt("wasd", 0) == 1)
        {
            if (Input.GetKey(KeyCode.W) == true)
            {
                rb.velocity = new Vector2(0, 10);
            }
            if (Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10, 0);
                sr.flipX = false;
            }
            if (Input.GetKey(KeyCode.S) == true)
            {
                rb.velocity = new Vector2(0, -10);
            }
            if (Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10, 0);
                sr.flipX = true;
            }
            if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10, 10);
            }
            if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10, 10);
            }
            if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10, -10);
            }
            if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10, -10);
            }
        }
        if (PlayerPrefs.GetInt("wasd", 0) == 0)
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                rb.velocity = new Vector2(0, 10);
            }
            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10, 0);
                sr.flipX = false;
            }
            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                rb.velocity = new Vector2(0, -10);
            }
            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10, 0);
                sr.flipX = true;
            }
            if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10, 10);
            }
            if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10, 10);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true && Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10, -10);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true && Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10, -10);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("protein"))
        {
            StartCoroutine("bgm");
        }
    }
    IEnumerator bgm()
    {
        yield return new WaitForSeconds(0.5f);
        ParticleSystem newParticle = Instantiate(particle);
        newParticle.Play();
        yield return new WaitForSeconds(1);
        manbouanimator.SetBool("kimoka", true);
        yield return new WaitForSeconds(20);
        sprite.enabled=false;
        ParticleSystem newParticle1 = Instantiate(particle1);
        newParticle1.Play();
    }
    IEnumerator manboujyumyou()
    {
        yield return new WaitForSeconds(23.2f);
        gm.sibouflug = "muteki";
        gm.siboubasyo = manboutrans.position;
        SceneManager.LoadScene("sibougenba");
    }
    void Update()
    {
        playercontroller();
        if (muteki == true)
        {
            this.tag = "muteki";
            StartCoroutine("manboujyumyou");
        }
       
    }
}

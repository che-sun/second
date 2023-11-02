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
    GameObject tan;
    GameObject baria;
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    private ParticleSystem particle;
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル1)")]
    private ParticleSystem particle1;
    public bool muteki = false;
    float speed=1;
    bool bariaflug=true;
    bool tanflug=true;
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
        tan = (GameObject)Resources.Load("痰 (1)");
        baria = (GameObject)Resources.Load("untitled");
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            manbouanimator.SetBool("huryou", true);
            speed = 0.8f;
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            manbouanimator.SetBool("manbou", true);
            speed = 1.2f;
        }
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            manbouanimator.SetBool("rougai", true);
            speed = 0.7f;
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            manbouanimator.SetBool("queen", true);
            speed = 1;
        }
    }
    void playercontroller()
    {
        if (PlayerPrefs.GetInt("wasd", 0) == 1)
        {
            if (Input.GetKey(KeyCode.W) == true)
            {
                rb.velocity = new Vector2(0, 10 * speed);
            }
            if (Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10 * speed, 0);
                sr.flipX = false;
                bgmflug.flip = false;
            }
            if (Input.GetKey(KeyCode.S) == true)
            {
                rb.velocity = new Vector2(0, -10 * speed);
            }
            if (Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10 * speed, 0);
                sr.flipX = true;
                bgmflug.flip = true;
            }
            if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10 * speed, 10 * speed);
            }
            if (Input.GetKey(KeyCode.W) == true && Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10 * speed, 10 * speed);
            }
            if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.A) == true)
            {
                rb.velocity = new Vector2(-10 * speed, -10 * speed);
            }
            if (Input.GetKey(KeyCode.S) == true && Input.GetKey(KeyCode.D) == true)
            {
                rb.velocity = new Vector2(10 * speed, -10 * speed);
            }
            if (Input.GetKeyDown(KeyCode.Space) == true && bariaflug == true && PlayerPrefs.GetInt("queenpick", 0) == 1)
            {
                Instantiate(baria, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.Euler(0, 0, 0));
                bariaflug = false;
                StartCoroutine("bariacd");
            }
            if (Input.GetKeyDown(KeyCode.Space) == true && tanflug == true && PlayerPrefs.GetInt("huryoupick", 0) == 1)
            {
                Instantiate(tan, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.Euler(0, 0, 0));
                tanflug = false;
                StartCoroutine("tancd");
            }
        }
        if (PlayerPrefs.GetInt("wasd", 0) == 0)
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                rb.velocity = new Vector2(0, 10 * speed);
            }
            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10 * speed, 0);
                sr.flipX = false;
                bgmflug.flip = false;
            }
            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                rb.velocity = new Vector2(0, -10 * speed);
            }
            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10 * speed, 0);
                sr.flipX = true;
                bgmflug.flip = true;
            }
            if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10 * speed, 10 * speed);
            }
            if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10 * speed, 10 * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true && Input.GetKey(KeyCode.LeftArrow) == true)
            {
                rb.velocity = new Vector2(-10 * speed, -10 * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true && Input.GetKey(KeyCode.RightArrow) == true)
            {
                rb.velocity = new Vector2(10 * speed, -10 * speed);
            }
            if (Input.GetKeyDown(KeyCode.Space) == true && bariaflug == true && PlayerPrefs.GetInt("queenpick", 0) == 1)
            {
                Instantiate(baria, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.Euler(0, 0, 0));
                bariaflug = false;
                StartCoroutine("bariacd");
            }
            if (Input.GetKeyDown(KeyCode.Space) == true && tanflug == true && PlayerPrefs.GetInt("huryoupick", 0) == 1)
            {
                Instantiate(tan, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.Euler(0, 0, 0));
                tanflug = false;
                StartCoroutine("tancd");
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
    IEnumerator bariacd()
    {
        yield return new WaitForSeconds(60);
        bariaflug = true;
    }
    IEnumerator tancd()
    {
        yield return new WaitForSeconds(30);
        tanflug = true;
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

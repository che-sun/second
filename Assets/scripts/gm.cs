using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gm : MonoBehaviour
{
    public string sibouflug="";
    public float timer=0;
    public string namepack;
    public string commentpack;
    GameObject shark;
    GameObject fish;
    GameObject bubleblock;
    GameObject player;
    GameObject human;
    GameObject kaisou;
    GameObject hitode;
    GameObject ankou;
    GameObject protein;
    GameObject colona;
    GameObject acolona;
    Transform manboutrans;
    GameObject time;
    Text time_text;
    Vector2 manboupos;
    public Vector2 siboubasyo;
    List<int> fishpos = new List<int>();
    int propos;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        shark = (GameObject)Resources.Load("shark");
        fish = (GameObject)Resources.Load("fish");
        bubleblock = (GameObject)Resources.Load("bubleblock");
        human = (GameObject)Resources.Load("human");
        kaisou = (GameObject)Resources.Load("kaisou");
        player = GameObject.Find("manbou");
        hitode = (GameObject)Resources.Load("hitode");
        ankou = (GameObject)Resources.Load("ankou");
        protein = (GameObject)Resources.Load("protein");
        colona = (GameObject)Resources.Load("colona");
        acolona = (GameObject)Resources.Load("acolona");
        manboutrans = player.GetComponent<Transform>();
        time = GameObject.Find("time");
        time_text = time.GetComponent<Text>();
        for (int a = -20; a >= -420; a = a - 20)
        {
            Instantiate(bubleblock, new Vector2(a, -4.2f), Quaternion.Euler(0, 0, 0));
        }
        for (float a = 0; a >= -460; a = a - 17.82f)
        {
            Instantiate(kaisou, new Vector2(a, 0), Quaternion.Euler(0, 0, 0));
        }
        StartCoroutine("sharkgo");
        StartCoroutine("fishgo");
        StartCoroutine("humango");
        StartCoroutine("hitodego");
        StartCoroutine("ankougo");
        StartCoroutine("proteingo");
        StartCoroutine("colonago");
    }
    void decidepos()
    {
        List<int> buffer = new List<int>();

        for (int j = -1; j <= 1; j++)
        {
            buffer.Add(j);
        }
        while (buffer.Count > 0)
        {
            int ran2 = Random.Range(0, buffer.Count);
            fishpos.Add(buffer[ran2]);
            buffer.RemoveAt(ran2);
        }
        buffer.Clear();
    }
    void decidepropos()
    {
       
            propos = Random.Range(-1,1 );
            
    }
    IEnumerator sharkgo()
    {
        yield return new WaitForSeconds(15);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
                Instantiate(shark, new Vector2(manboupos.x + 50, 0), Quaternion.Euler(0, 0, 0));
                yield return new WaitForSeconds(15);
        }
            
    }
    IEnumerator hitodego()
    {
        yield return new WaitForSeconds(10);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
            Instantiate(hitode, new Vector2(manboupos.x - 10, -1), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(30);
        }

    }
    IEnumerator colonago()
    {
        yield return new WaitForSeconds(60);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
            Instantiate(acolona, new Vector2(manboupos.x - 10, -1), Quaternion.Euler(0, 0, 0));
            Instantiate(colona, new Vector2(manboupos.x - 10, -1), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(35);
        }

    }
    IEnumerator ankougo()
    {
        yield return new WaitForSeconds(50);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
            Instantiate(ankou, new Vector2(manboupos.x - 10, 0.7f), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(30);
        }

    }
    IEnumerator proteingo()
    {
        yield return new WaitForSeconds(40);
        while (true)
        {
            manboupos = manboutrans.position;
            decidepropos();
            Instantiate(protein, new Vector2(manboupos.x - 10, propos*2), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(30);
        }

    }
    IEnumerator fishgo()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
            yield return new WaitForSeconds(5);
            if (sibouflug != "")
            {
                yield break;
            }
            decidepos();
            Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[0] * 3), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1);
            if (sibouflug != "")
            {
                yield break;
            }
            Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[1] * 3), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1);
            if (sibouflug != "")
            {
                yield break;
            }
            Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[2] * 3), Quaternion.Euler(0, 0, 0));
            fishpos.Clear();
        }
    }
    IEnumerator humango()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            Instantiate(human, new Vector2(manboupos.x-7, 10), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(20);
        }
        

    }
    void Update()
    {
        if (sibouflug == "")
        {
            timer += Time.deltaTime;
            time_text.text = "É^ÉCÉÄÅF" + timer.ToString("f2");
        }
    }
}

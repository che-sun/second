using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gm : MonoBehaviour
{
    public string sibouflug="";
    float timer=0;
    GameObject shark;
    GameObject fish;
    GameObject bubleblock;
    GameObject player;
    Transform manboutrans;
    GameObject time;
    Text time_text;
    Vector2 manboupos;
    List<int> fishpos = new List<int>();
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        shark = (GameObject)Resources.Load("shark");
        fish = (GameObject)Resources.Load("fish");
        bubleblock = (GameObject)Resources.Load("bubleblock");
        player = GameObject.Find("manbou");
        manboutrans = player.GetComponent<Transform>();
        time = GameObject.Find("time");
        time_text = time.GetComponent<Text>();
        StartCoroutine("sharkgo");
        StartCoroutine("fishgo");
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
    IEnumerator sharkgo()
    {
        yield return new WaitForSeconds(10);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
                Instantiate(shark, new Vector2(manboupos.x + 50, 0), Quaternion.Euler(0, 0, 90));
                yield return new WaitForSeconds(10);
        }
            
    }
    IEnumerator fishgo()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            if (sibouflug != "")
            {
                yield break;
            }
            manboupos = manboutrans.position;
                yield return new WaitForSeconds(5);
                decidepos();
                Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[0] * 3), Quaternion.Euler(0, 0, 90));
                yield return new WaitForSeconds(1);
                Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[1] * 3), Quaternion.Euler(0, 0, 90));
                yield return new WaitForSeconds(1);
                Instantiate(fish, new Vector2(manboupos.x - 50, fishpos[2] * 3), Quaternion.Euler(0, 0, 90));
                fishpos.Clear();
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (sibouflug == "")
        {
            time_text.text = "É^ÉCÉÄÅF" + timer.ToString("f2");
        }
    }
}

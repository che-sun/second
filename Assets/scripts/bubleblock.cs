using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubleblock : MonoBehaviour
{
    List<int> bublepos = new List<int>();
    GameObject abuble;
    GameObject bbuble;
    GameObject cbuble;
    void Start()
    {
        abuble = (GameObject)Resources.Load("bigbuble");
        bbuble = (GameObject)Resources.Load("midbuble");
        cbuble = (GameObject)Resources.Load("smallbuble");
        StartCoroutine("bublegenerator");
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
            bublepos.Add(buffer[ran2]);
            buffer.RemoveAt(ran2);
        }
        buffer.Clear();
    }
    IEnumerator bublegenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            decidepos();
            Instantiate(abuble, new Vector2(this.gameObject.transform.position.x + bublepos[0] * 0.7f, -3.8f), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1);
            Instantiate(bbuble, new Vector2(this.gameObject.transform.position.x + bublepos[1] * 0.7f, -3.8f), Quaternion.Euler(0, 0, 0));
            yield return new WaitForSeconds(1);
            Instantiate(cbuble, new Vector2(this.gameObject.transform.position.x + bublepos[2] * 0.7f, -3.8f), Quaternion.Euler(0, 0, 0));
            bublepos.Clear();
        }


    }
    void Update()
    {
        
    }
}

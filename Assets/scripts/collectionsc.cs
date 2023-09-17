using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectionsc : MonoBehaviour
{
    GameObject sharkdead;
    GameObject fishdead;
    GameObject bubledead;
    GameObject colddead;
    GameObject humandead;
    GameObject jumpdead;
    GameObject hitodedead;
    GameObject proteindead;
    GameObject colonadead;
    GameObject ankoudead;
    GameObject lockpng;
    GameObject parent;

    bool flug1 = true;
    bool flug2 = true;
    bool flug3 = true;
    bool flug4 = true;
    bool flug5 = true;
    bool flug6 = true;
    bool flug7 = true;
    bool flug8 = true;
    bool flug9 = true;
    bool flug10 = true;
    void Start()
    {
        parent = GameObject.Find("Content");
        sharkdead = (GameObject)Resources.Load("sharkpng");
        fishdead = (GameObject)Resources.Load("fishpng");
        bubledead = (GameObject)Resources.Load("bublepng");
        humandead = (GameObject)Resources.Load("humanpng");
        colddead = (GameObject)Resources.Load("coldpng");
        jumpdead = (GameObject)Resources.Load("jumppng");
        hitodedead = (GameObject)Resources.Load("hitodepng");
        proteindead = (GameObject)Resources.Load("proteinpng");
        colonadead = (GameObject)Resources.Load("colonapng");
        ankoudead = (GameObject)Resources.Load("ankoupng");
        lockpng = (GameObject)Resources.Load("lockpng");
    }
    void Update()
    {
        if (flug1 == true)
        {
            int a1 = PlayerPrefs.GetInt("coldpng", 0);
            if (a1==1)
            {
                Instantiate(colddead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug1 = false;
        }
        if (flug2 == true)
        {
            int a1 = PlayerPrefs.GetInt("jumppng", 0);
            if (a1 == 1)
            {
                Instantiate(jumpdead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug2 = false;
        }
        if (flug3 == true)
        {
            int a1 = PlayerPrefs.GetInt("sharkpng", 0);
            if (a1 == 1)
            {
                Instantiate(sharkdead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug3 = false;
        }
        if (flug4 == true)
        {
            int a1 = PlayerPrefs.GetInt("fishpng", 0);
            if (a1 == 1)
            {
                Instantiate(fishdead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug4 = false;
        }
        if (flug5 == true)
        {
            int a1 = PlayerPrefs.GetInt("bublepng", 0);
            if (a1 == 1)
            {
                Instantiate(bubledead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug5 = false;
        }
        if (flug6 == true)
        {
            int a1 = PlayerPrefs.GetInt("humanpng", 0);
            if (a1 == 1)
            {
                Instantiate(humandead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug6 = false;
        }
        if (flug7 == true)
        {
            int a1 = PlayerPrefs.GetInt("hitodepng", 0);
            if (a1 == 1)
            {
                Instantiate(hitodedead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug7 = false;
        }
        if (flug8 == true)
        {
            int a1 = PlayerPrefs.GetInt("ankoupng", 0);
            if (a1 == 1)
            {
                Instantiate(ankoudead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug8 = false;
        }
        if (flug9 == true)
        {
            int a1 = PlayerPrefs.GetInt("proteinpng", 0);
            if (a1 == 1)
            {
                Instantiate(proteindead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug9 = false;
        }
        if (flug10 == true)
        {
            int a1 = PlayerPrefs.GetInt("colonapng", 0);
            if (a1 == 1)
            {
                Instantiate(colonadead, parent.transform);
            }
            if (a1 == 0)
            {
                Instantiate(lockpng, parent.transform);
            }
            flug10 = false;
        }
    }
}

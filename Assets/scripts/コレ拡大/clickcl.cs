using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickcl : MonoBehaviour
{
    public GameObject canvas;
    GameObject colonadead1;
    // Start is called before the first frame update
    void Start()
    {
        colonadead1 = (GameObject)Resources.Load("colonadead1");
        canvas = GameObject.Find("Canvas");


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    {
        if (clickrelation.feel == "0")
        {
            var instance = Instantiate(colonadead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}

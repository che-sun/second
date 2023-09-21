using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clicksk : MonoBehaviour
{
    public GameObject canvas;
    GameObject sharkdead1;
    // Start is called before the first frame update
    void Start()
    {
        sharkdead1 = (GameObject)Resources.Load("sharkdead1");
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
            var instance = Instantiate(sharkdead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}
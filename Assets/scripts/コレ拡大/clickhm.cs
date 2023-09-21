using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickhm : MonoBehaviour
{
    public GameObject canvas;
    GameObject humandead1;
    // Start is called before the first frame update
    void Start()
    {
        humandead1 = (GameObject)Resources.Load("humandead1");
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
            var instance = Instantiate(humandead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}
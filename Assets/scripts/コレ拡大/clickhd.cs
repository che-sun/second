using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickhd : MonoBehaviour
{
    public GameObject canvas;
    GameObject hitodedead1;
    // Start is called before the first frame update
    void Start()
    {
        hitodedead1 = (GameObject)Resources.Load("hitodedead1");
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
            var instance = Instantiate(hitodedead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}
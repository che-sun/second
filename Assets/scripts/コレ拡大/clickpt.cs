using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickpt : MonoBehaviour
{
    public GameObject canvas;
    GameObject proteindead1;
    // Start is called before the first frame update
    void Start()
    {
        proteindead1 = (GameObject)Resources.Load("proteindead1");
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
            var instance = Instantiate(proteindead1);
            instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}

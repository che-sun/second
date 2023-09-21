using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickjp : MonoBehaviour
{
    public GameObject canvas;
    GameObject jumpdead1;
    // Start is called before the first frame update
    void Start()
    {
        jumpdead1 = (GameObject)Resources.Load("jumpdead1");
        canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Onclick()
    { 
     if(clickrelation.feel == "0")
        {
            var instance = Instantiate(jumpdead1);
    instance.transform.SetParent(canvas.transform, false);
            clickrelation.feel = "1";
        }
    }
}

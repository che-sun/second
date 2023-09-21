using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroycl : MonoBehaviour
{
    GameObject clClone;
    GameObject colonadead1;
    void Start()
    {
        colonadead1 = (GameObject)Resources.Load("colonadead1(Clone)");
        clClone = GameObject.Find("colonadead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(clClone);
        clickrelation.feel = "0";
    }
}

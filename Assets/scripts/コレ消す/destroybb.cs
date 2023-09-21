using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroybb : MonoBehaviour
{
    GameObject bbClone;
    GameObject bubledead1;
    void Start()
    {
        bubledead1 = (GameObject)Resources.Load("bubledead1(Clone)");
        bbClone = GameObject.Find("bubledead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(bbClone);
        clickrelation.feel = "0";
    }
}

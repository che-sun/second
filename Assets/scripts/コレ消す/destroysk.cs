using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroysk : MonoBehaviour
{
    GameObject skClone;
    GameObject sharkdead1;
    void Start()
    {
        sharkdead1 = (GameObject)Resources.Load("sharkdead1(Clone)");
        skClone = GameObject.Find("sharkdead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(skClone);
        clickrelation.feel = "0";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyjp : MonoBehaviour
{
    GameObject jpClone;
    GameObject jumpdead1;
    void Start()
    {
        jumpdead1 = (GameObject)Resources.Load("jumpdead1(Clone)");
        jpClone = GameObject.Find("jumpdead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(jpClone);
        clickrelation.feel = "0";
    }
}
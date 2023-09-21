using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyhm : MonoBehaviour
{
    GameObject hmClone;
    GameObject humandead1;
    void Start()
    {
        humandead1 = (GameObject)Resources.Load("humandead1(Clone)");
        hmClone = GameObject.Find("humandead1(Clone)");
    }

    public void OnClick()
    {
        Destroy(hmClone);
        clickrelation.feel = "0";
    }
}

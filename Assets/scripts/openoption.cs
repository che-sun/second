using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openoption : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject optionpanel;
    GameObject parent;
    private void Start()
    {
        parent = GameObject.Find("MainPannel");
        optionpanel = (GameObject)Resources.Load("optionPanel");
    }
    public void OnClick()
    {
        Instantiate(optionpanel, parent.transform);
    }
}

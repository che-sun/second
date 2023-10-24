using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class allow : MonoBehaviour
{
    // Start is called before the first frame update
    Toggle allowbutton;
    [SerializeField]
    GameObject allowob;
    bool onoff;
    int allowflug;
    // Start is called before the first frame update
    void Start()
    {
        allowbutton = allowob.GetComponent<Toggle>();
        if (PlayerPrefs.HasKey("allow") == false)
        {
            PlayerPrefs.SetInt("allow", 0);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("allow", 0) == 1)
        {
            onoff = true;
        }
        if (PlayerPrefs.GetInt("allow", 0) == 0)
        {
            onoff = false;
        }
        allowbutton.isOn = onoff;
    }

    public void OnToggleChanged()
    {
        allowflug = allowbutton.isOn ? 1 : 0;
        PlayerPrefs.SetInt("allow", allowflug);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("allow", 0) == 1)
        {
            onoff = true;
            PlayerPrefs.SetInt("wasd", allowflug - 1);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("allow", 0) == 0)
        {
            onoff = false;
            PlayerPrefs.SetInt("wasd", allowflug + 1);
            PlayerPrefs.Save();
        }
        allowbutton.isOn = onoff;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("allow", 0) == 1)
        {
            onoff = true;
        }
        if (PlayerPrefs.GetInt("allow", 0) == 0)
        {
            onoff = false;
        }
        allowbutton.isOn = onoff;
    }
}

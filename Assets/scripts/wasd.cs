using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wasd : MonoBehaviour
{
    Toggle wasdbutton;
    [SerializeField]
    GameObject wasdob;
    bool onoff;
    int wasdflug;
    // Start is called before the first frame update
    void Start()
    {
        wasdbutton = wasdob.GetComponent<Toggle>();
        if (PlayerPrefs.HasKey("wasd") == false)
        {
            PlayerPrefs.SetInt("wasd", 1);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.GetInt("wasd", 0) == 1)
        {
            onoff = true;
        }
        if (PlayerPrefs.GetInt("wasd", 0) == 0)
        {
            onoff = false;
        }
        wasdbutton.isOn = onoff;
    }
    
    public void OnToggleChanged()
    {
        wasdflug = wasdbutton.isOn ? 1 : 0;
        PlayerPrefs.SetInt("wasd", wasdflug);
        PlayerPrefs.Save();
        if (PlayerPrefs.GetInt("wasd", 0) == 1)
        {
            onoff = true;
            PlayerPrefs.SetInt("allow", wasdflug-1);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("wasd", 0) == 0)
        {
            onoff = false;
            PlayerPrefs.SetInt("allow", wasdflug + 1);
            PlayerPrefs.Save();
        }
        wasdbutton.isOn = onoff;
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("wasd", 0) == 1)
        {
            onoff = true;
            PlayerPrefs.SetInt("allow", wasdflug - 1);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("wasd", 0) == 0)
        {
            onoff = false;
            PlayerPrefs.SetInt("allow", wasdflug + 1);
            PlayerPrefs.Save();
        }
        wasdbutton.isOn = onoff;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volume : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject volumeob;
    Slider volumebar;
    float volumevalue;
    void Start()
    {
        volumeob = GameObject.Find("VolumeSlider");
        volumebar = volumeob.GetComponent<Slider>();
        if (PlayerPrefs.HasKey("volume") == false)
        {
            PlayerPrefs.SetFloat("volume", 0.5f);
            PlayerPrefs.Save();
        }
        volumevalue = PlayerPrefs.GetFloat("volume", 0.5f);
        volumebar.value = volumevalue;
    }
    public void Method()
    {
        PlayerPrefs.SetFloat("volume", volumebar.value);
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class um : MonoBehaviour
{
    GameObject gamemaster;
    GameObject siin;
    Text siin_text;
    gm gm;

    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        siin = GameObject.Find("siin");
        siin_text = siin.GetComponent<Text>();
        gm = gamemaster.GetComponent<gm>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Destroy(gamemaster);
            SceneManager.LoadScene("opening");
        }
        if (gm.sibouflug == "cold")
        {
            siin_text.text = "�������Ď��񂾁B�シ��www";
        }
        if (gm.sibouflug == "jump")
        {
            siin_text.text = "�񐶒��𗎂Ƃ����Ƃ��Đ��ʂ���W�����v���A�����̍ۂ̏Ռ��Ŏ��񂾁B�n�����ˁB";
        }
        if (gm.sibouflug == "shark")
        {
            siin_text.text = "�T���ɐH���Ď��񂾁B���̐��͎�����H������ˁB���傤���Ȃ��ˁB";
        }
        if (gm.sibouflug == "fish")
        {
            siin_text.text = "�����ɏՓ˂��Ċ�ʂ𕡎G���܂��Ď��񂾁B���Ⴀ���O���i�ǂ�����ĔѐH���Ă񂾂�B";
        }
        if (gm.sibouflug == "buble")
        {
            siin_text.text = "�A���ڂɓ������X�g���X�Ŏ��񂾁B���O�܂���Ԉ���Ă����{�ɂ����͗���Ȃ�B";
        }
    }
}

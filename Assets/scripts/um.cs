using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class um : MonoBehaviour
{
    GameObject gamemaster;
    GameObject siin;
    GameObject score;
    Text score_text;
    Text siin_text;
    gm gm;

    void Start()
    {
        gamemaster = GameObject.Find("gamemaster");
        siin = GameObject.Find("siin");
        score = GameObject.Find("time");
        siin_text = siin.GetComponent<Text>();
        score_text = score.GetComponent<Text>();
        gm = gamemaster.GetComponent<gm>();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "�^�C���F" + gm.timer;
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
        if (gm.sibouflug == "human")
        {
            siin_text.text = "�l�Ԃɒނ��Ď��񂾁B�q�g�J�X�Ȃ񂼂ɂ��ꂨ���ď�Ȃ����E�҃}�����{�E�I";
        }

    }
}

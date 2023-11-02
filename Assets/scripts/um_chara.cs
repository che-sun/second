using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class um_chara : MonoBehaviour
{
    GameObject title;
    GameObject explaination;
    Text title_text;
    Text explaination_text;
    // Start is called before the first frame update
    void Start()
    {
        title = GameObject.Find("title");
        title_text = title.GetComponent<Text>();
        explaination = GameObject.Find("explaination");
        explaination_text = explaination.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("rougaipick", 0) == 1)
        {
            title_text.text = "�L�����I��-�V�Q�}���{�E";
            explaination_text.text= "����:�p�`���R�Ƌ����Œ����������Ȃ�؋���肩��ԊC�V�œ����Ă����Ƃ�����s�҂𝛂˂ăT�c�ɕ߂܂����B�G���������ق�������̃}���{�E�̋C�����y�ɂȂ邾�낤�Ƃ����l���̂��Ƃ��̃Q�[���ɋN�p���ꂽ�B�������Ȃ̂ő����x����ኦ���ɂ��ア�B�V�Q�Ȃ̂Ŏ����̕������F�߂�ꂸ�A��Î҂ɘd�G(�N��)�𑗂��Ď����̃^�C����10�b�L�΂��Ă�����Ă���B�l�Ԃł�����60�΁B";
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            title_text.text = "�L�����I��-�}���{�E";
            explaination_text.text = "����:������ւ�ɂ����}���{�E�B���Z���Ɉ�l�ɂȂ����Ƃ�������̃Q�[���̎�Î҂ɝf�v���ꂽ�B�Ȃ����j���[�X�ɂ͂Ȃ��Ă��Ȃ��B���̃Q�[���̃}���{�E�̒��ň�ԎႭ�A�܂����j���Ȃ̂ő��͈�ԑ����B���񂾂Ƃ��ɂ��܂ɔ������ɋ[�l������\�͂������Ă���B�l�Ԃł�����6�΁B";
        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            title_text.text = "�L�����I��-�s�ǃ}���{�E";
            explaination_text.text = "����:���̋������ؖ�����I�Ƃ��ق����Ă��̃Q�[���ɎQ�������B���h������Ȃ̂Ŋ����Ƃ���ɂ��Ă������ɂ͎��ȂȂ��B���[�[���g���ז��őO�������Ȃ����ߊ�ɂԂ���Ȃ��悤�ɂ������j���ł���B�Ȃ������������Ă��Ȃ����߂����̓f���(�X�y�[�X�L�[)�͏L�����ĒN���ߊ��Ȃ��B�����狭�����Ă��}���{�E�Ȃ̂ň��ႂ�f������30�b�x�e���K�v�B�l�Ԃł�����30�΁B"; 
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            title_text.text = "�L�����I��-�����}���{�E";
            explaination_text.text = "����:�T�C=�W���b�N��35�㏗���B�~���̉e���ō����X���n�߂����ߍ�������ÎE���ꂩ���A�����̐Ӗ���S�ĕ���o���ē����o�����Ƃ�������̃Q�[���̎�Î҂��b�l���ꂽ�B�����炿�Ȃ̂Ŋ����Ɏア�B�����̉���ɂ��o���A��5�b(�N�[���^�C����60�b)�\���(�X�y�[�X�L�[)���ŋߊ񐶒��Ɋ񐶂��ꂽ�B�l�Ԃł�����70�΁B";
        }

    }
}

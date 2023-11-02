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
            title_text.text = "キャラ選択-老害マンボウ";
            explaination_text.text= "説明:パチンコと競魚で貯金が無くなり借金取りから車海老で逃げていたところ歩行者を撥ねてサツに捕まった。雑魚がいたほうが周りのマンボウの気分も楽になるだろうという考えのもとこのゲームに起用された。じじいなので足も遅けりゃ寒さにも弱い。老害なので自分の負けが認められず、主催者に賄賂(年金)を送って自分のタイムを10秒伸ばしてもらっている。人間でいうと60歳。";
        }
        if (PlayerPrefs.GetInt("manpick", 0) == 1)
        {
            title_text.text = "キャラ選択-マンボウ";
            explaination_text.text = "説明:そこらへんにいたマンボウ。下校中に一人になったところをこのゲームの主催者に拉致された。なぜかニュースにはなっていない。このゲームのマンボウの中で一番若く、また水泳部なので足は一番速い。死んだときにたまに美少女に擬人化する能力を持っている。人間でいうと6歳。";
        }
        if (PlayerPrefs.GetInt("huryoupick", 0) == 1)
        {
            title_text.text = "キャラ選択-不良マンボウ";
            explaination_text.text = "説明:俺の強さを証明する！とかほざいてこのゲームに参加した。見栄っ張りなので寒いところにいてもすぐには死なない。リーゼントが邪魔で前が見えないため岩にぶつからないようにゆっくり泳いでいる。なお歯磨きをしていないためこいつの吐く痰(スペースキー)は臭すぎて誰も近寄らない。いくら強がってもマンボウなので一回痰を吐いたら30秒休憩が必要。人間でいうと30歳。"; 
        }
        if (PlayerPrefs.GetInt("queenpick", 0) == 1)
        {
            title_text.text = "キャラ選択-女王マンボウ";
            explaination_text.text = "説明:サイ=ジャック国35代女王。円安の影響で国が傾き始めたため国民から暗殺されかけ、女王の責務を全て放り出して逃げ出したところをこのゲームの主催者に鹵獲された。温室育ちなので寒さに弱い。女王の加護によりバリアが5秒(クールタイムは60秒)貼れる(スペースキー)が最近寄生虫に寄生された。人間でいうと70歳。";
        }

    }
}

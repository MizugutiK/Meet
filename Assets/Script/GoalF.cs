using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalF : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject p;
    public GameObject pl;
    void Start()
    {
        p.SetActive(false);                       //Strat時にobjに格納されたものを非表示にします
    }

        void OnTriggerExit2D(Collider2D other)  //　トリガーに当たって、そこを抜けたら（Exit）
        {
            if (other.gameObject.tag == "Player")  //　もし出ていった相手(other)のtagが”Player”ならば
            {
            pl.SetActive(false);            //　objに入れられてるオブジェクトを、表示させます
            p.SetActive(true);            //　objに入れられてるオブジェクトを、表示させます
            }
            return;                                             //　プログラムの先頭へ戻ります
        }
    }


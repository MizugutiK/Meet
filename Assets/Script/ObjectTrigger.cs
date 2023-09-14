using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//　UnityのUIの機能を継承（使用）します
using Cinemachine;				//　Cinemachineを継承します
public class ObjectTrigger : MonoBehaviour
{
    public AudioSource bgm;	//　音を鳴らすシステムAudioSourceを用意します
    public AudioSource se;	//　音を鳴らすシステムAudioSourceを用意します
    public AudioClip sound01;       //　鳴らす音のファイルを格納する変数を用意します
    public AudioClip sound02;       //　鳴らす音のファイルを格納する変数を用意します
    public AudioClip sound03;		//　鳴らす音のファイルを格納する変数を用意します

    public GameObject obj;                      //　出したいObjectを変数objに格納します
    public GameObject player;
    public GameObject p;
    public GameObject gameovera;
   // public GameObject game;

    int count;

    public Text gO;           //　Text型の変数goalTextを用意します
    public Text GO;           //　Text型の変数goalTextを用意します
    public GameObject Re;           //　Text型の変数goalTextを用意します
    public GameObject Ta;           //　Text型の変数goalTextを用意します
    public GameObject h;                      //　出したいObjectを変数objに格納します
    public GameObject h1;                      //　出したいObjectを変数objに格納します

    Animator animator;

    GameObject gameCtrl;		//　GameObject型の変数　gameCtrlを用意します、このオブジェクトにGoalManagerクラスが入れられています
    ObjectMove script;		 //　GoalManagert型の変数　scriptを用意します　各クラス（スクリプト）はその型として変数を作ることができます

    //public CinemachineVirtualCamera vcamera;   //　CinemachineVirtualCamera型の変数を用意します

    GameObject gam;		//　GameObject型の変数　gameCtrlを用意します、このオブジェクトにGoalManagerクラスが入れられています
    GoalManager s;		 //　GoalManagert型の変数　scriptを用意します　各クラス（スクリプト）はその型として変数を作ることができます


    private void Start()
    {
        bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
        se = GameObject.Find("SE").GetComponent<AudioSource>();



        obj.SetActive(false);                       //Strat時にobjに格納されたものを非表示にします
        p.SetActive(false);                       //Strat時にobjに格納されたものを非表示にします
        gameovera.SetActive(false);                       //Strat時にobjに格納されたものを非表示にします
      //  game.SetActive(false);                       //Strat時にobjに格納されたものを非表示にします

        animator = GetComponent<Animator>();

        gO= GameObject.Find("gO").GetComponent<Text>();　//　”Goal”という名のObjectを探して、そのTextコンポネントを入れます
        GO = GameObject.Find("GoaL").GetComponent<Text>();　//　”Goal”という名のObjectを探して、そのTextコンポネントを入れます


        gO.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        GO.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        Re.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        Ta.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        h.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        h1.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます

        gameCtrl = GameObject.Find("Player"); 	//　変数gameCtrlに　GameControllerオブジェクトを見つけてきて入れます
        script = gameCtrl.GetComponent<ObjectMove>();   //　変数scriptに　gameCtrlに入れられたGameControllerにあるGameManagerスクリプトを入れます

        gam = GameObject.Find("Goal"); 	//　変数gameCtrlに　GameControllerオブジェクトを見つけてきて入れます
        s = gam.GetComponent<GoalManager>();	 //　変数scriptに　gameCtrlに入れられたGameControllerにあるGameManagerスクリプトを入れます

    }





    void OnTriggerExit2D(Collider2D other)  //　トリガーに当たって、そこを抜けたら（Exit）
    {
        if (other.gameObject.tag == "Mask")　　//　もし出ていった相手(other)のtagが”Player”ならば
        {
            se.PlayOneShot(sound01);	//　変数「sound01」に入った音を鳴らします
            obj.SetActive(true);   　　       //　objに入れられてるオブジェクトを、表示させます
            count = +1;
            if (count >= 1)
            {
                count = 1;
            }
        }

        if (other.gameObject.tag == "Coivd")　　//　もし出ていった相手(other)のtagが”Player”ならば
        {
            se.PlayOneShot(sound02);	//　変数「sound01」に入った音を鳴らします
            obj.SetActive(false);            //　objに入れられてるオブジェクトを、
            count = -1;
            if (count <= 0)
            {
                count = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (count == 0 && other.gameObject.tag == "Coivd")  //　もし出ていった相手(other)のtagが”Player”ならば
        {

            player.SetActive(false);      //　このオブジェクトをScene から消します（setを「止めます」）　
            GameObject.Find("Player").GetComponent<ObjectMove>().a = 0;
            gameovera.SetActive(true);                       //Strat時にobjに格納されたものを非表示にします
            bgm.Stop();
            se.PlayOneShot(sound03);	//　変数「sound01」に入った音を鳴らします
            script.Stop();		 //　壊される直前に変数scriptに入ったGameManagerスクリプトにあるGoalFlag()メソッドを呼び、実行します


            animator.Play("kuy");
       
            Invoke("text", 5f);
            

        }

        if (other.gameObject.tag == "Goal") 
        {
          //  game.SetActive(true);                       //Strat時にobjに格納されたものを非表示にします

            player.SetActive(false);      //　このオブジェクトをScene から消します（setを「止めます」）　
            p.SetActive(true);      //　このオブジェクトをScene から消します（setを「止めます」）　
          //  vcamera.Priority = 20;  //変数vcameraに入れられたVカメラのプライオリティを20にします

         
            Text();
        }

      
    }
    void text()
    {
        gO.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです	
        Re.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
        Ta.gameObject.SetActive(true);      //　SetActiveをtrueにするだけのメソッドです
        h.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
    }

    void Text()
    {
        GO.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです	
        Re.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
        Ta.gameObject.SetActive(true);      //　SetActiveをtrueにするだけのメソッドです
        h1.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
    }
}
   

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//　UnityのUIの機能を継承（使用）します

public class GoalManager : MonoBehaviour
{
    public Text goalText;           //　Text型の変数goalTextを用意します	
    public GameObject Re;           //　Text型の変数goalTextを用意します
    public GameObject Ta;           //　Text型の変数goalTextを用意します


    void Start()
    {
        goalText = GameObject.Find("Goal").GetComponent<Text>();　//　”Goal”という名のObjectを探して、そのTextコンポネントを入れます
        goalText.gameObject.SetActive(false);        //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        Re.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
        Ta.gameObject.SetActive(false);      //　その入れたTextのgameObjectをfalseにして表示を止めておきます
    }

    public void GoalFlag()			//　他のクラスからアクセス可能なpublicのGaolFlag()というメソッドをつくりました　
    {
        Invoke("Text", 5f);
    }

    void Text() 
    {
        goalText.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです	
        Re.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
        Ta.gameObject.SetActive(true);		//　SetActiveをtrueにするだけのメソッドです
    }
}
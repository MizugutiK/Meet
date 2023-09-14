using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//�@Unity��UI�̋@�\���p���i�g�p�j���܂�

public class GoalManager : MonoBehaviour
{
    public Text goalText;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�	
    public GameObject Re;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�
    public GameObject Ta;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�


    void Start()
    {
        goalText = GameObject.Find("Goal").GetComponent<Text>();�@//�@�hGoal�h�Ƃ�������Object��T���āA����Text�R���|�l���g�����܂�
        goalText.gameObject.SetActive(false);        //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        Re.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        Ta.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
    }

    public void GoalFlag()			//�@���̃N���X����A�N�Z�X�\��public��GaolFlag()�Ƃ������\�b�h������܂����@
    {
        Invoke("Text", 5f);
    }

    void Text() 
    {
        goalText.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�	
        Re.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
        Ta.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
    }
}
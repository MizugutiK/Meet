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
        p.SetActive(false);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�
    }

        void OnTriggerExit2D(Collider2D other)  //�@�g���K�[�ɓ������āA�����𔲂�����iExit�j
        {
            if (other.gameObject.tag == "Player")  //�@�����o�Ă���������(other)��tag���hPlayer�h�Ȃ��
            {
            pl.SetActive(false);            //�@obj�ɓ�����Ă�I�u�W�F�N�g���A�\�������܂�
            p.SetActive(true);            //�@obj�ɓ�����Ă�I�u�W�F�N�g���A�\�������܂�
            }
            return;                                             //�@�v���O�����̐擪�֖߂�܂�
        }
    }


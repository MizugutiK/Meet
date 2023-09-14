using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RePlay : MonoBehaviour
{
    private string sceneName;       //�@�����̕ϐ�sceneName��p�ӂ��܂�

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;  //�@�ϐ�sceneName�Ɂu���݂�scene�v�̃t�@�C����������܂�
    }

    public void ReplayGame()             //�@ReplayGame()���\�b�h�ł�
    {
        SceneManager.LoadScene(sceneName);   //�@�ϐ�sceneName�ɓ����ꂽscene�����[�h���܂�
    }
}
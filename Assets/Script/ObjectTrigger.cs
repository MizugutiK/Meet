using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				//�@Unity��UI�̋@�\���p���i�g�p�j���܂�
using Cinemachine;				//�@Cinemachine���p�����܂�
public class ObjectTrigger : MonoBehaviour
{
    public AudioSource bgm;	//�@����炷�V�X�e��AudioSource��p�ӂ��܂�
    public AudioSource se;	//�@����炷�V�X�e��AudioSource��p�ӂ��܂�
    public AudioClip sound01;       //�@�炷���̃t�@�C�����i�[����ϐ���p�ӂ��܂�
    public AudioClip sound02;       //�@�炷���̃t�@�C�����i�[����ϐ���p�ӂ��܂�
    public AudioClip sound03;		//�@�炷���̃t�@�C�����i�[����ϐ���p�ӂ��܂�

    public GameObject obj;                      //�@�o������Object��ϐ�obj�Ɋi�[���܂�
    public GameObject player;
    public GameObject p;
    public GameObject gameovera;
   // public GameObject game;

    int count;

    public Text gO;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�
    public Text GO;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�
    public GameObject Re;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�
    public GameObject Ta;           //�@Text�^�̕ϐ�goalText��p�ӂ��܂�
    public GameObject h;                      //�@�o������Object��ϐ�obj�Ɋi�[���܂�
    public GameObject h1;                      //�@�o������Object��ϐ�obj�Ɋi�[���܂�

    Animator animator;

    GameObject gameCtrl;		//�@GameObject�^�̕ϐ��@gameCtrl��p�ӂ��܂��A���̃I�u�W�F�N�g��GoalManager�N���X��������Ă��܂�
    ObjectMove script;		 //�@GoalManagert�^�̕ϐ��@script��p�ӂ��܂��@�e�N���X�i�X�N���v�g�j�͂��̌^�Ƃ��ĕϐ�����邱�Ƃ��ł��܂�

    //public CinemachineVirtualCamera vcamera;   //�@CinemachineVirtualCamera�^�̕ϐ���p�ӂ��܂�

    GameObject gam;		//�@GameObject�^�̕ϐ��@gameCtrl��p�ӂ��܂��A���̃I�u�W�F�N�g��GoalManager�N���X��������Ă��܂�
    GoalManager s;		 //�@GoalManagert�^�̕ϐ��@script��p�ӂ��܂��@�e�N���X�i�X�N���v�g�j�͂��̌^�Ƃ��ĕϐ�����邱�Ƃ��ł��܂�


    private void Start()
    {
        bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
        se = GameObject.Find("SE").GetComponent<AudioSource>();



        obj.SetActive(false);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�
        p.SetActive(false);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�
        gameovera.SetActive(false);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�
      //  game.SetActive(false);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�

        animator = GetComponent<Animator>();

        gO= GameObject.Find("gO").GetComponent<Text>();�@//�@�hGoal�h�Ƃ�������Object��T���āA����Text�R���|�l���g�����܂�
        GO = GameObject.Find("GoaL").GetComponent<Text>();�@//�@�hGoal�h�Ƃ�������Object��T���āA����Text�R���|�l���g�����܂�


        gO.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        GO.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        Re.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        Ta.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        h.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�
        h1.gameObject.SetActive(false);      //�@���̓��ꂽText��gameObject��false�ɂ��ĕ\�����~�߂Ă����܂�

        gameCtrl = GameObject.Find("Player"); 	//�@�ϐ�gameCtrl�Ɂ@GameController�I�u�W�F�N�g�������Ă��ē���܂�
        script = gameCtrl.GetComponent<ObjectMove>();   //�@�ϐ�script�Ɂ@gameCtrl�ɓ����ꂽGameController�ɂ���GameManager�X�N���v�g�����܂�

        gam = GameObject.Find("Goal"); 	//�@�ϐ�gameCtrl�Ɂ@GameController�I�u�W�F�N�g�������Ă��ē���܂�
        s = gam.GetComponent<GoalManager>();	 //�@�ϐ�script�Ɂ@gameCtrl�ɓ����ꂽGameController�ɂ���GameManager�X�N���v�g�����܂�

    }





    void OnTriggerExit2D(Collider2D other)  //�@�g���K�[�ɓ������āA�����𔲂�����iExit�j
    {
        if (other.gameObject.tag == "Mask")�@�@//�@�����o�Ă���������(other)��tag���hPlayer�h�Ȃ��
        {
            se.PlayOneShot(sound01);	//�@�ϐ��usound01�v�ɓ���������炵�܂�
            obj.SetActive(true);   �@�@       //�@obj�ɓ�����Ă�I�u�W�F�N�g���A�\�������܂�
            count = +1;
            if (count >= 1)
            {
                count = 1;
            }
        }

        if (other.gameObject.tag == "Coivd")�@�@//�@�����o�Ă���������(other)��tag���hPlayer�h�Ȃ��
        {
            se.PlayOneShot(sound02);	//�@�ϐ��usound01�v�ɓ���������炵�܂�
            obj.SetActive(false);            //�@obj�ɓ�����Ă�I�u�W�F�N�g���A
            count = -1;
            if (count <= 0)
            {
                count = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (count == 0 && other.gameObject.tag == "Coivd")  //�@�����o�Ă���������(other)��tag���hPlayer�h�Ȃ��
        {

            player.SetActive(false);      //�@���̃I�u�W�F�N�g��Scene ��������܂��iset���u�~�߂܂��v�j�@
            GameObject.Find("Player").GetComponent<ObjectMove>().a = 0;
            gameovera.SetActive(true);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�
            bgm.Stop();
            se.PlayOneShot(sound03);	//�@�ϐ��usound01�v�ɓ���������炵�܂�
            script.Stop();		 //�@�󂳂�钼�O�ɕϐ�script�ɓ�����GameManager�X�N���v�g�ɂ���GoalFlag()���\�b�h���ĂсA���s���܂�


            animator.Play("kuy");
       
            Invoke("text", 5f);
            

        }

        if (other.gameObject.tag == "Goal") 
        {
          //  game.SetActive(true);                       //Strat����obj�Ɋi�[���ꂽ���̂��\���ɂ��܂�

            player.SetActive(false);      //�@���̃I�u�W�F�N�g��Scene ��������܂��iset���u�~�߂܂��v�j�@
            p.SetActive(true);      //�@���̃I�u�W�F�N�g��Scene ��������܂��iset���u�~�߂܂��v�j�@
          //  vcamera.Priority = 20;  //�ϐ�vcamera�ɓ����ꂽV�J�����̃v���C�I���e�B��20�ɂ��܂�

         
            Text();
        }

      
    }
    void text()
    {
        gO.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�	
        Re.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
        Ta.gameObject.SetActive(true);      //�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
        h.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
    }

    void Text()
    {
        GO.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�	
        Re.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
        Ta.gameObject.SetActive(true);      //�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
        h1.gameObject.SetActive(true);		//�@SetActive��true�ɂ��邾���̃��\�b�h�ł�
    }
}
   

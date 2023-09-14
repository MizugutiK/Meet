using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
	//�X�N���[���p
	Rigidbody2D rb2d;
	public float a= 5.0f;



	// y���̑��x
	public Vector2 SPEED = new Vector2(0, 0.05f);
	// Use this for initialization

	void Start()
	{
		// Rigidbody2D���L���b�V������
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//�����̑��x
		rb2d.velocity = new Vector2(a, 0);

		// �ړ�����
		Move();
	}

	// �ړ��֐�
	void Move()
	{
		// ���݈ʒu��Position�ɑ��
		Vector2 Position = transform.position;

	

		 if (Input.GetKey("up") )
		{ // ��L�[�����������Ă�����
		  // �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.y += SPEED.y;
		}

		if (Input.GetKey("down"))
		{ // ���L�[�����������Ă�����
		  // �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.y -= SPEED.y;
		}

		if (Position.y >= -1)
		{
			Position.y = -1;
		}
		if (Position.y <= -6)
		{
			Position.y = -6;
		}

		// ���݂̈ʒu�ɉ��Z���Z���s����Position��������
		transform.position = Position;

		if (Position.x >= 360)
		{
			a = 0;

		}
	}


	public void Stop() 
	{
		SPEED = new Vector2(0, 0);
	}

}

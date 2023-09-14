using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
	//スクロール用
	Rigidbody2D rb2d;
	public float a= 5.0f;



	// y軸の速度
	public Vector2 SPEED = new Vector2(0, 0.05f);
	// Use this for initialization

	void Start()
	{
		// Rigidbody2Dをキャッシュする
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//ｘ軸の速度
		rb2d.velocity = new Vector2(a, 0);

		// 移動処理
		Move();
	}

	// 移動関数
	void Move()
	{
		// 現在位置をPositionに代入
		Vector2 Position = transform.position;

	

		 if (Input.GetKey("up") )
		{ // 上キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			Position.y += SPEED.y;
		}

		if (Input.GetKey("down"))
		{ // 下キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
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

		// 現在の位置に加算減算を行ったPositionを代入する
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

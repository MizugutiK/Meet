using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pPozition : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float a = 7.0f;

    float px;

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

    }
}

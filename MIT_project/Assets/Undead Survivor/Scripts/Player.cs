using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        //GetComponent<T>: 오브젝트에서 컴포넌트를 가져오는 함수
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //// 1. 힘을 준다
        //rigid.AddForce(inputVec);

        //// 2. 속도 제어
        //rigid.velocity = inputVec;


        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        //nomalized: 벡터 값의 크기가 1이 되도록 좌표가 수정된 값
        //fixedDeltaTime: 물리 프레임 하나가 소비한 시간

        // 3. 위치 이동
        rigid.MovePosition(rigid.position + nextVec);
    }
}

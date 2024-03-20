using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;                //플레이어를 이동시키기 위한 Rigidbidy
    public int moveSpeed = 50;              //플레이어의 이동속도
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();         //rb 에 오브젝트 안에 있는 Rigidbidy를 넣어줌   
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove01();
    }

    public void PlayerMove01()     //플레이어의 위치를 바꾸어 이동시키게 만드는 함수
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");           //좌우 이동 입력을 받아옴
        moveInput.y = Input.GetAxisRaw("Vertical");              //상하 이동 입력을 받아옴

        moveInput.Normalize();                                      //대각선 가속 방지
        transform.position += moveInput * moveSpeed * Time.deltaTime;        //플레이어의 오브젝트를 이동
    }

    public void PlayerMove02()
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");                        //좌우 이동 입력을 받아옴
        moveInput.y = Input.GetAxisRaw("Vertical");                          //상하 이동 입력을 받아옴

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
      
    }
}






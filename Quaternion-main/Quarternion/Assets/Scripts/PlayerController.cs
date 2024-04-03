using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;            // �÷��̾ �̵���Ű�� ���� RigidBody
    public int moveSpeed = 20;           // �÷��̾��� �̵��ӵ�

    void Start()
    {
        rb = GetComponent<Rigidbody>();         // rb�� ������Ʈ �ȿ� �ִ� rigidBody�� �־���
    }

    void Update()
    {
        //PlayerMove01();
        PlayerMove02();
    }

    public void PlayerMove01()      // �÷��̾��� ��ġ�� �ٲپ� �̵���Ű�� ����� �Լ�
    {
        Vector3 moveInput = new Vector3(0,0,0);

        moveInput.x = Input.GetAxisRaw("Horizontal");           // �¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");             // ���� �̵� �Է��� �޾ƿ�

        moveInput.Normalize();                                  // �밢�� ���� ����
        transform.position += moveInput * moveSpeed * Time.deltaTime;        // �÷��̾��� ������Ʈ�� �̵�
    }

    public void PlayerMove02() 
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");           // �¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");             // ���� �̵� �Է��� �޾ƿ�

        moveInput.Normalize();
        
        rb.velocity = moveInput * moveSpeed;
    }
}

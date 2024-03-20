using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;                //�÷��̾ �̵���Ű�� ���� Rigidbidy
    public int moveSpeed = 50;              //�÷��̾��� �̵��ӵ�
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();         //rb �� ������Ʈ �ȿ� �ִ� Rigidbidy�� �־���   
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove01();
    }

    public void PlayerMove01()     //�÷��̾��� ��ġ�� �ٲپ� �̵���Ű�� ����� �Լ�
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");           //�¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");              //���� �̵� �Է��� �޾ƿ�

        moveInput.Normalize();                                      //�밢�� ���� ����
        transform.position += moveInput * moveSpeed * Time.deltaTime;        //�÷��̾��� ������Ʈ�� �̵�
    }

    public void PlayerMove02()
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");                        //�¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");                          //���� �̵� �Է��� �޾ƿ�

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
      
    }
}






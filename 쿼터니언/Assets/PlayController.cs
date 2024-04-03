using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public Rigidbody rb;        //�÷��̾ �̵���Ű�� ���� Rigidbody
    public int moveSpeed = 20;       //�÷��̾��� �̵��ӵ�

    void Start()
    {
        rb = GetComponent<Rigidbody>();     //rb�� ������Ʈ �ȿ� �ִ� Rigidbody�� �־���
    }

    void Update()
    {
        //PlayerMove01();
        playerMove02();
    }

    public void PlayerMove01()      //�÷��̾��� ��ġ�� �ٲپ� �̵���Ű�� ����� �Լ�
    {
        Vector3 moveInput = new Vector3(0,0,0);

        moveInput.x = Input.GetAxisRaw("Horizontal");       //�¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");         //��ȭ �̵� �Է��� �޾ƿ�

        moveInput.Normalize();                              //�밢�� ���� ����
        transform.position += moveInput * moveSpeed * Time.deltaTime;    //�÷��̾��� ������Ʈ�� �̵�
    }


    public void playerMove02()
    {
        Vector3 moveInput = new Vector3(0, 0, 0);

        moveInput.x = Input.GetAxisRaw("Horizontal");       //�¿� �̵� �Է��� �޾ƿ�
        moveInput.y = Input.GetAxisRaw("Vertical");         //��ȭ �̵� �Է��� �޾ƿ�

        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
    }
}


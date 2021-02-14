using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Privat adattagok
    private Rigidbody player;
    private Vector3 jump;

    //Publikus adattagok
    public float Speed;
    public float RotateSpeed;
    public float JumpForce;

    void Start()
    {
        player = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {
        //Elore
        if (Input.GetKey(KeyCode.W))
        {

            player.transform.position += transform.forward * Time.deltaTime * Speed;
        }

        //Balra
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(Vector3.down * RotateSpeed * Time.deltaTime);
        }

        //Hatra
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= transform.forward * Time.deltaTime * Speed;
        }

        //Jobbra
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }

        //Ugras
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(jump * JumpForce, ForceMode.Impulse);
        }
    }
}

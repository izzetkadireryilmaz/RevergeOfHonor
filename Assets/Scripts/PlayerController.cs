using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    public float walkingSpeed;
    public float runningSpeed;
    public float gravity;
    private Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // �leri ve yatay hareketleri al�yoruz.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * vertical + transform.right * horizontal;

        // Shift tu�u ile hareket h�z�m�z� artt�r�yoruz.
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            controller.Move(move * runningSpeed * Time.deltaTime);
        }
        else
        {
            controller.Move(move * walkingSpeed * Time.deltaTime);
        }

        // Karakterin yere olan temas�n� kontrol ediyoruz.
        if (controller.isGrounded)
        {
            velocity.y = -2f; // Karakter yere temas ediyorsa bile k���k bir kuvvet uygulayarak yere tam oturmay� sa�l�yoruz.
        }
        else
        {
            velocity.y += gravity * Time.deltaTime; // Karakter yere temas etmiyorsa belirledi�imiz yer �ekimi etkisini uyguluyoruz.
        }

        controller.Move(velocity * Time.deltaTime); // Yer �ekimi uygulanmas�n� sa�l�yoruz.
    }

}

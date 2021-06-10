using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 5;
    public float rotationSpeed = 150;
    public Animator animator;
    private float x, y;
    public int Vidas = 10;
    public Text textVidas;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "body1")
        {
            print("Daño");
            Vidas = Vidas - 1;

            if (Vidas < 0)
            {
                SceneManager.LoadScene("Perdio");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        textVidas.text = "VIDAS: " + Vidas;
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }

}
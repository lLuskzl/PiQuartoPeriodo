using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float velocidade;

    void Start()
    {

    }

    void Update()
    {
        Movimentacao();
    }

    void Movimentacao()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public or private
    //Data type ( int, float, bool, string)
    //Espaço para as variáveis

    //SerializeField serve para mesmo a variável estando private
    //podermos acessar no Inspector do Unity para alterar seu valor
    [SerializeField]
    private float speed = 5.0f;
    
    // Start is called before the first frame update
    // O Start será chamado no começo do jogo apenas uma vez
    void Start()
    {
        //Pegando a posição atual
        transform.position = new Vector3(-3, 0, 0);
    }

    // Update is called once per frame
    // É chamado uma vez a cada frame, após o Start
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

        //Se o 'player' no eixo Y for maior que 0
        //Setto a posição do 'player' no eixo Y para 0
        //Restringindo que não saia da tela ao movimentar

        //Posição y = cima e baixo, não passar do limite inferior de -4.2 e superior de 0
        //Limite superior de 0 para ficar no meio da tela.
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        //Posição x = esquerda e direita, não passar do limite da tela de 8.5
        if (transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }
    }

}

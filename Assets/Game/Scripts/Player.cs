using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public or private
    //Data type ( int, float, bool, string)
    //Espaço para as variáveis

    public float speed = 5.0f;
    
    
    
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

        Debug.Log("Horizontal: " + horizontalInput);
        Debug.Log("vertical: " + verticalInput);
    }
}

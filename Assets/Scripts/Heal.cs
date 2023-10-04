using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public Transform jogador;
    private Grade grade = new Grade();
    private int Pos;
     
    private void Awake(){
        Pos = grade.RetornarPos(transform.position);
    }

    private void Update(){
        if(grade.RetornarPos(jogador.position) != Pos){
            Debug.Log("Fora");
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int aumentoDeSaude = 10;

        if(collision.gameObject.CompareTag("Player"))
        {
            Status player = collision.gameObject.GetComponent<Status>();
            player.Healing(aumentoDeSaude);

        }
    }
}

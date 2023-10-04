using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{   
    public Transform jogador;
    private Grade grade = new Grade();
    private bool aumentoDeDano = true;
    private int tempoBonus = 10;
    private int Pos;

    private void Awake(){
        Pos = grade.RetornarPos(transform.position);
    }

    private void Update(){
        if(grade.RetornarPos(jogador.position) != Pos){
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }
    }

    private void  OnCollisionEnter2D(Collision2D collision)
    {
            

        if (collision.gameObject.CompareTag("Player"))
        {
            Status player = collision.gameObject.GetComponent<Status>();
            player.SetPower(this.aumentoDeDano, this.tempoBonus);
        }
    }

}

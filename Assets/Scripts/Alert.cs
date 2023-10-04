using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : BaseState
{
    private Grade grade = new Grade();

    public Alert(){
    
    }

    public override bool UpdateLogic(int hp, int b, Transform jogador, Transform npc){
        if(b == grade.RetornarPos(jogador.position) && hp >= 20) return true;
        return false;
    }

    public override string Action(int hp, int b, Transform jogador, Transform npc){
        float velocidade = 0.2f;
        float alcanceDeFuga = 5.0f;

        float distanciaParaJogador = Vector3.Distance(npc.position, jogador.position);

        if (distanciaParaJogador <= alcanceDeFuga){
            Debug.Log("Achou");
            Vector3 direcaoDeFuga =  jogador.position - npc.position;

            direcaoDeFuga.Normalize();

            

            npc.Translate(direcaoDeFuga * velocidade * Time.deltaTime);
        }
        return "atacar";
    }
}

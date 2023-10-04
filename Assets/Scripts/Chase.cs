using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : BaseState
{
    public Chase(){

    }

    public override bool UpdateLogic(int hp, int b, Transform jogador, Transform npc){
        if(hp < 20) return true;
        return false;
    }

    public override string Action(int hp, int b, Transform jogador, Transform npc){
            float velocidade = 3.0f;
            float alcanceDeFuga = 5.0f;

            float distanciaParaJogador = Vector3.Distance(npc.position, jogador.position);

            if (distanciaParaJogador <= alcanceDeFuga){
            Vector3 direcaoDeFuga = npc.position - jogador.position;

            direcaoDeFuga.Normalize();

            npc.Translate(direcaoDeFuga * velocidade * Time.deltaTime);
            }
        return "fugir";
    }
}

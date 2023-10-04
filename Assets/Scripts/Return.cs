using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : BaseState
{
    private Grade grade = new Grade();
    

    public Return(){}

    public override bool UpdateLogic(int hp, int b, Transform jogador, Transform npc){
        if(b  != grade.RetornarPos(npc.position)) return true;
        return false;
    }

    public override string Action(int hp, int b, Transform jogador, Transform npc){
        
        float velocidade = 2.0f;
        

        

        
       
        Vector3 direcaoDeFuga =  grade.Pontomedio(b) - npc.position;

        direcaoDeFuga.Normalize();

        

        npc.Translate(direcaoDeFuga * velocidade * Time.deltaTime);
        
        
        return "voltar";
    }
    
}

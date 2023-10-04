using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relaxed : BaseState
{
    public Relaxed(){
        
    }

    public override bool UpdateLogic(int hp, int b, Transform jogador, Transform npc){
        if(hp >= 20) return true;
        return false;
    }

    public override string Action(int hp, int b, Transform jogador, Transform npc){
        return "esperar";
    }
}

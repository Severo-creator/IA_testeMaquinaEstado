using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    private BaseState[] states;
    private int atual; 
    private int bloco;

    private int health;

    public Transition(BaseState [] st, int b) {
        this.states = st;
        this.bloco = b;
    }

    public int Upload(int hp, int b, Transform jogador, Transform npc){
        this.health = hp;
        bool aux = false;

        for(int i = 0; i <= 3; i++){
            aux = states[i].UpdateLogic(health, bloco, jogador, npc);
            atual = i;
            if(aux)return i;
        }
        if(aux = false){
            this.Upload(health, bloco, jogador, npc);
        }

        return 3;    
    }
    
    public string Action(int hp){
       return "";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState  {
    private string name;
    

    public BaseState() {
        
        
    }
    public virtual string Action(int hp, int b, Transform jogador, Transform npc){
        return "";
    }

    public virtual bool UpdateLogic(int hp, int b, Transform jogador, Transform npc) {
        return false;
    }

}

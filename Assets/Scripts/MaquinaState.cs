using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaState : MonoBehaviour
{   
    public Transform jogador;
    public int hp;
    public int bloco;
    private int currentState = 0;
    private Relaxed relaxedState = new Relaxed();
    private Chase chaseState = new Chase();
    private Return returnState = new Return();
    private Alert alertState = new Alert();

    
    private Transition trans;
    private BaseState[]  states = new BaseState[4];
    
    void Awake()
    {
        

        states[3] = relaxedState;
        states[0] = chaseState;
        states[1] = returnState;
        states[2] = alertState;

        trans  = new Transition(states, bloco);

        
    }

    void Update()
    {
        currentState = (trans.Upload(hp, bloco, jogador, this.transform));
        this.Action(states[currentState].Action(hp, bloco, jogador, this.transform));
    }
    
    public void Action(string s){
        Debug.Log(s);
    }

    protected virtual BaseState GetInitialState() {
        return null;
    }
}

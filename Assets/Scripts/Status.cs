using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Status : MonoBehaviour
{
    private int health;
    private int MaxHealth;
    private bool poder;

    public void Healing(int cura ){
        this.health = this.health + cura;
        if(this.health > this.MaxHealth)this.health = this.MaxHealth;
    }

    public void SetPower(bool b, int sec){
        this.poder = b;
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Grade : MonoBehaviour
{
    
    private Vector3[,] matriz = new Vector3[9,2];


    public  int JogadorPos(Transform jogador){
        return RetornarPos(jogador.position);
    }

    public int RetornarPos(Vector3 POS){
        
        int aux = 0;
        for(int i = 0; i <= 8; i++){
            
            matriz[i,0] = new Vector3(-6.0f + (4*(i%3))  , 12.0f - (4*(i/3)), 0.0f );
            matriz[i,1] = new Vector3(-6.0f + ((4*((i%3) +1))  ), 12.0f - ((4*((i/3)+1)) ), 0.0f );
            Debug.Log( matriz[i,0] );
             Debug.Log( matriz[i,1] );
        }
        for(int i = 0; i <= 8; i++){
            if (POS.x >= matriz[i,0].x  && POS.x <= matriz[i,1].x && POS.y >= matriz[i,1].y && POS.y <= matriz[i,0].y) {
                // O objeto está dentro da área.
                Debug.Log( i );
                aux = i;
                break;
            } else {
                // O objeto está fora da área.

            }
        }
        return aux;
    }

    public Vector3 Pontomedio(int a){
        for(int i = 0; i <= 8; i++){
            matriz[i,0] = new Vector3(-6.0f + (4*(i%3))  , 12.0f - (4*(i/3)), 0.0f );
            matriz[i,1] = new Vector3(-6.0f + ((4*(i%3)) + 1 ), 12.0f - ((4*(i/3)) + 1), 0.0f );
        }
        Vector3 pontomedio = (matriz[a,0] + matriz[a,1])/ 2.0f;
        
        return pontomedio;
    }


}

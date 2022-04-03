using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //float a=2;
    //float b=0;


    void Start()
    {
       Debug.Log (sum(5,0));
       Debug.Log (prod(3,2));
       Debug.Log(div(1,0));
        
    }
    float sum(float a, float b){
        
        return a+b;
    }
    float prod(float a, float b){
        return a*b;
    }
    string div(float a , float b ){
        
       if(b==0){
             //Debug.Log("Erreur");
             return "Erreur";
                     }
        else 
        {
             float c= a/b ;
            return c.ToString() ;
        }

       /* float div(float a, float b){
            if(b==0){
            Debug.Log("Erreur");}
            else {
            return a/b;}
            return a/b;
        }*/
        
          
    }  
    }
    





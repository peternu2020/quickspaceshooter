using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class ScoreKeeper : MonoBehaviour
{
    private int score;
   

    public float Score
    {
        get
        {
            return score;
        }
    }


    public void ScoreKill()
    {
        score++;
    }
    public void EndGame(){
        score = -2;
    }
    
}
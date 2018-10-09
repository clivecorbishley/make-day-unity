using System.Collections.Generic;
using Application;
using UnityEngine;

public class LessThan : MonoBehaviour
{
    public static LessThan LT;

    public GameObject personalAssistant;
    public List<Cards> stuff = new List<Cards>();
    public int score;

    void Awake()
    {
        if (LT != null)
            GameObject.Destroy(LT);
        else

            LT = this;
            

        DontDestroyOnLoad(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public override void Init() {
        base.Init();
    }


    public void Message() {
        Debug.Log("Hello World");
    }
}

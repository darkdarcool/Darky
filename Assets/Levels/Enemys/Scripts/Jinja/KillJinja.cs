using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillJinja : MonoBehaviour
{
    public Transform killCheck;
    public LayerMask player;
    
    void Update()
    {
        bool didTouchPlayer = Physics2D.OverlapCircle(killCheck.position, 0.5f, player);
        if (didTouchPlayer) Debug.Log("I have touched the player!");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int id;
    void Start()
    {
        GameEvents.current.openDoor += Open;
    }

    private void Open(int id)
    {
        if(id == this.id)
        {
            Debug.Log(this.id);
            Debug.Log(id);
            LeanTween.moveLocalY(gameObject,6f,2).setEaseOutQuad();
        }
    }

}

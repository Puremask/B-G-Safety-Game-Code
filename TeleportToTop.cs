﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToTop : MonoBehaviour
{
    public GameObject player;
    public Transform tpPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportMachine() {
        player.transform.position = tpPoint.position;
    }
}

﻿/*
 * (Christopher Green)
 * (Fir.cs)
 * (Assignment 5)
 * (Holds information of the Fir Tree type)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fir : Tree
{
    // Start is called before the first frame update
    void Start()
    {
        this.treeType = "Fir Tree";
        this.woodCost = 40;
        this.treeHeight = 25;
    }
}

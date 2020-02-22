/*
 * (Christopher Green)
 * (Oak.cs)
 * (Assignment 5)
 * (Holds information of the Oak Tree type)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oak : Tree
{
    // Start is called before the first frame update
    void Start()
    {
        this.treeType = "Oak Tree";
        this.woodCost = 10;
        this.treeHeight = 20;
    }
}

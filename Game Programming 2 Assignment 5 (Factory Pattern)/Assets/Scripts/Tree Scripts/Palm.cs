/*
 * (Christopher Green)
 * (Palm.cs)
 * (Assignment 5)
 * (Holds information of the Palm Tree type)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palm : Tree
{
    // Start is called before the first frame update
    void Start()
    {
        this.treeType = "Palm Tree";
        this.woodCost = 20;
        this.treeHeight = 15;
    }
}

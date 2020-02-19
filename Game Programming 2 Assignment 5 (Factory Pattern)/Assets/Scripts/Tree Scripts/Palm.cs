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

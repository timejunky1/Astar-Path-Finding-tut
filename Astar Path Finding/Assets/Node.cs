using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node: IHeapItem<Node>
{
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;
    public int movementpenalty;

    public int gCost;
    public int hCost;
    public Node parent;
    int heapIndex;

    public Node(bool walkable, Vector3 worldPosition, int gridX, int gridY, int penalty)
    {
        this.walkable = walkable;
        this.worldPosition = worldPosition;
        this.gridX = gridX;
        this.gridY = gridY;
        movementpenalty = penalty;
    }

    public int fCost { get { return gCost + hCost; } }

    public int HeapIndex { get { return heapIndex; } set { heapIndex = value; } }

    public int CompareTo(Node other)
    {
        int compare = fCost.CompareTo(other.fCost);
        if(compare == 0)
        {
            compare = hCost.CompareTo(other.hCost);
        }
        return -compare;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject[,] spaces;
    public GridMaker maker;
    public static GridManager reference;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        spaces = new GameObject[(int)maker.dimensions.x, (int)maker.dimensions.y];
        reference = this;
    }
}

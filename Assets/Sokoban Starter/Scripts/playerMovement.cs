using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GridObject grid;
    public int xPos;
    public int yPos;

    // Start is called before the first frame update
    void Start()
    {
        xPos = grid.gridPosition.x;
        yPos = grid.gridPosition.y;
        GridManager.reference.spaces[xPos-1, yPos-1] = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //GridObject otherScript = grid.GetComponent<GridObject>();

        int xMove = 0;
        int yMove = 0;

        if (Input.GetKeyDown(KeyCode.W))
        {
            yMove -= 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            yMove += 1;
        }

        if (yMove == 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                xMove += 1;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                xMove -= 1;
            }
        }

        /*if correct
        {
            grid.gridPosition.x += xMove;
        }*/

        /*if correct
        {
        grid.gridPosition.y += yMove;
        }*/

        /*
        GridManager.reference.spaces[xPos - 1, yPos - 1] = null;
        grid.gridPosition.x += xMove;

        xPos = grid.gridPosition.x;
        yPos = grid.gridPosition.y;

        GridManager.reference.spaces[xPos - 1, yPos - 1] = this.gameObject;
        */
        xPos = grid.gridPosition.x;
        yPos = grid.gridPosition.y;


        //GridManager.reference.spaces[0, 1] == null;

    }
}

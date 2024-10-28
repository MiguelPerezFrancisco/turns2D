using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGrid : MonoBehaviour
{
    // Start is called before the first frame update
   // TODO: Add properties for grid size, cell size, and prefab for the cell
    [field:SerializeField] public int Width {get; private set;} 
    [field:SerializeField] public int Height {get; private set;} 
    [field:SerializeField] public GameObject CellPrefab {get; private set;}
    [field:SerializeField] public float CellSize {get; private set;}

    //TODO: Create a 2D array of cells
    //TODO: Store the individual tiles in an array
    //TODO: Methods to get, change, add, and remove tiles
    //TODO: Gizmo for drawing the grid in the editor
    private void OnDrawGizmos()
    {
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {                    
                Gizmos.DrawWireCube(new Vector2(x*CellSize, y*CellSize), new Vector2(CellSize, CellSize));
                // Gizmos.DrawLine(new Vector2(x*CellSize, y*CellSize), new Vector2(x*CellSize, (y+1)*CellSize));
            }
        }
    }

}

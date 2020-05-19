using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice3 : MonoBehaviour
{
    private int i, j;
    public GameObject cube;
    // Start is called before the first frame update
    private void CreateFloor(int k,int a)
    {
        for (int i = a; i <= k; i++)
        {
            for (int j = 1 ; j <= i; j++)
            {
                
                Instantiate(cube, new Vector3(i, j, 25), Quaternion.Euler(270, 0, 0));
            }
        }
    }
    private void Awake()
    {
        CreateFloor(10,1);
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    private Vector3 StartPos;
    private Rigidbody rb;
    public int Doors = 0;
    
    public void OpenClosed_doors()
    {
        Doors++;
        print(Doors);
        Storage.Doors++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

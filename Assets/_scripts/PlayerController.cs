using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    private Vector3 worldPotititon;
    void Start()
    {
        Debug.Log(playerData.name);
    }

  
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           Vector3 clickPos = Input.mousePosition; 
            clickPos.z= -Camera.main.transform.position.z;
            worldPotititon= Camera.main.ScreenToWorldPoint(clickPos);
            Debug.Log(worldPotititon);

           transform.position = worldPotititon;
        }

       
    }
}//class 

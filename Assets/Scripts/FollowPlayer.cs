using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
public GameObject LookDirection;
public GameObject Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position;
        transform.rotation = LookDirection.transform.rotation;
        
    }
}
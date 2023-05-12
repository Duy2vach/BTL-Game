using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;//khoi tao doi tuong dat cho player


    // Update is called once per frame
    private void Update()
    {
        //cap nhat lien tuc lai vi tri cua tranform
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}

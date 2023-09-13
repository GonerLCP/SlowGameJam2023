using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform TargetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(TargetToFollow.position.x, -2.0f, 2.0f), Mathf.Clamp(TargetToFollow.position.y, -2f, 2f), transform.position.z);
    }
}

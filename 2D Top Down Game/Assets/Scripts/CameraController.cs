using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ObjectToFollow;
    public float FollowOffset = -6.68f;

    private CarMovement _carMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        _carMovementScript = GameObject.Find("Player").GetComponent<CarMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_carMovementScript.CrossedFinishLine())
        {
            transform.position = new Vector3(0f, ObjectToFollow.transform.position.y - FollowOffset, -20f); 
        }
    }
       
}

using UnityEngine;

public class CamaraFollow : MonoBehaviour {
    public Transform target;
    //this transform target using for our player and when we drop ouer script in maincamara.
    // we also drop player in this script and this target represent player.
    public float SmoothSpeed = 0.125f;
    public Vector3 offset;//for move camara x,y,z position 

    void FixedUpdate(){
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,smoothedPosition);
        //transform.position = target.position;
        //this is use to around player and move camara around player.
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }

}

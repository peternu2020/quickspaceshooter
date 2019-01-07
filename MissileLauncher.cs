using UnityEngine;


public class MissileLauncher : MonoBehaviour
{
    
    public GameObject MissilePrefab;


    public void FireMissile()
    {
        var missile = (GameObject)Object.Instantiate(MissilePrefab,
            transform.TransformPoint(new Vector3(0, 1.20f, 0)),
            transform.rotation);
            var missileRigidBody = missile.GetComponent<Rigidbody2D>();
            missileRigidBody.velocity = new Vector3(0,5,0);
       
    }  
  
}
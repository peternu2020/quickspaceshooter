using UnityEngine;


public class EnemyLauncher : MonoBehaviour
{
    
    public GameObject MissilePrefab;



    public void FireMissile()
    {
        var missile = (GameObject)Object.Instantiate(MissilePrefab,
            transform.TransformPoint(new Vector3(0, -1.2f, 0)),
            transform.rotation);
            var missileRigidBody = missile.GetComponent<Rigidbody2D>();
            missileRigidBody.velocity = new Vector3(0,-5,0);
       
    }

}
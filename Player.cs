using UnityEngine;


[RequireComponent(typeof(MissileLauncher), typeof(Rigidbody2D))]
public class Player : Ship
{
    
    public AudioClip explosion;
    public AudioClip mlaunch;
    public AudioClip killscore;
    
    
	internal void FixedUpdate () {
       
       if (Input.GetKey(KeyCode.LeftArrow))
       rigidBody.velocity = rigidBody.velocity + new Vector2(-0.25f, 0);
       
       else if (Input.GetKey(KeyCode.RightArrow))
       rigidBody.velocity = rigidBody.velocity + new Vector2(0.25f, 0);
       else {return;}
    }


    internal void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<MissileLauncher>().FireMissile();
            GetComponent<AudioSource>().PlayOneShot(mlaunch, 0.7F);
        }
        var mainCamera = Camera.main;
        if (mainCamera)
        {
            var worldPosition = transform.position;
            var screenPosition = mainCamera.WorldToScreenPoint(worldPosition);
            var screenMax = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            var screenMin = mainCamera.ScreenToWorldPoint(new Vector3(0, 0, 0));

            if (screenPosition.x < -5)
            {
                worldPosition.x = screenMax.x;
                rigidBody.MovePosition(worldPosition);
            }

            if (screenPosition.x > Screen.width+5)
            {
                worldPosition.x = screenMin.x;
                rigidBody.MovePosition(worldPosition);
            }

            
        }
    }
}

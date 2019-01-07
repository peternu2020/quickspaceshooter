using UnityEngine;

[RequireComponent(typeof(EnemyLauncher), typeof(Rigidbody2D) ) ]
public class Enemy : Ship
{
   
   
    private float placeholder;



    public AudioClip explosion;
    public AudioClip mlaunch;
    public AudioClip killscore;

    private AudioSource audioSource;


    internal override void Start()
    {
        base.Start();
        
        audioSource = GetComponent<AudioSource>();
    }


    internal void FixedUpdate()
    {
      
  rigidBody.velocity = rigidBody.velocity + new Vector2(-0.005f, 0);

    }


    
    private void PlaySound(AudioClip clip)
    {
        if (clip == null)
        return;
        audioSource.loop = false;
        audioSource.PlayOneShot(clip);
    }

    ///Fire every 2 seconds
    internal void Update()
    {
        if (Time.time - placeholder > 2)
        {
            PlaySound(mlaunch);
            GetComponent<EnemyLauncher>().FireMissile();
            placeholder = Time.time;
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

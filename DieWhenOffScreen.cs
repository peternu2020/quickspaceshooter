using UnityEngine;


public class DieWhenOffScreen : MonoBehaviour {
    
    
	internal void Update ()
	{
        Invoke("DestroyEnemy", 6);
       
	}
    
    void DestroyEnemy2(){
        Destroy(gameObject);
    }
}

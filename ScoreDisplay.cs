using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Display the current score
/// </summary>
// ReSharper disable once UnusedMember.Global
public class ScoreDisplay : MonoBehaviour
{
    public GUIStyle Style;
    public Rect Rect1 = new Rect(100, 100, 300, 100);
    public Rect Rect2 = new Rect(500, 500, 700, 500);

    private ScoreKeeper Player;

    internal void Start()
    {
        Player = GetComponent<ScoreKeeper>();
    }

    /// <summary>
    /// Display the score
    /// Called once each GUI update.
    /// </summary>
    internal void OnGUI()
    {
        GUI.Label(Rect1, $"Score: {Player.Score:F3}", Style);
        if(Player.Score >= 2){
            GUI.Label(Rect2, $"You win", Style);
            Invoke("EndUnity", 3);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            

        }
        if(Player.Score <0){
            GUI.Label(Rect2, $"You Lose", Style);
            Invoke("EndUnity", 3);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void EndUnity(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

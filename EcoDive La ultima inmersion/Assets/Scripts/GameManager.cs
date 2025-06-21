using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int collectedTrash = 0;
    public int trashToWin = 10;
    public float oxygen = 100f;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    void Update()
    {
        oxygen -= Time.deltaTime;
        if (oxygen <= 0) GameOver();
    }

    public void AddTrash()
    {
        collectedTrash++;
        if (collectedTrash >= trashToWin) Victory();
    }

    public void TakeDamage()
    {
        oxygen -= 20f;
        if (oxygen <= 0) GameOver();
    }

    void GameOver()
    {
        Debug.Log("¡Perdiste! El océano sigue contaminado.");
    }

    void Victory()
    {
        Debug.Log("¡Victoria! Salvaste al océano.");
    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager Instance = null;
    private IGameApp gameApp;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            gameApp = new GameApp();
            gameApp.StartApp();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
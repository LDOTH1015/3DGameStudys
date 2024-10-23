using UnityEngine;

public class CharacterManger : MonoBehaviour
{
    private static CharacterManger _instance;
    public static CharacterManger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharacterManger").AddComponent<CharacterManger>();
            }
            return _instance;
        }
    }

    public Player player;
    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance == this)
            {
                Destroy(gameObject);
            }
        }
    }
}

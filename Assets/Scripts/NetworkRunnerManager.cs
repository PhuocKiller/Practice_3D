using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using TMPro;

public class NetworkRunnerManager : MonoBehaviour
{
    NetworkRunner runner;
    TextMeshProUGUI roomName;
    [SerializeField]
    GameObject robo;
    [SerializeField]
    TextMeshProUGUI textRoomName;
    NetworkCallBackManager networkCallBackManager;
    [SerializeField]
    Transform parentRoomItem, roomItem;
    private void Awake()
    {
        runner = GetComponent<NetworkRunner>();
        networkCallBackManager=GetComponent<NetworkCallBackManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnPlayer(NetworkRunner m_runner, PlayerRef player)
    {
        if (m_runner== runner)
        {
            m_runner.Spawn(robo, inputAuthority: player);
        }
       
    }
    public async void StartGame()
    {
        networkCallBackManager.OnPlayerJoinRegister(SpawnPlayer);
        await runner.StartGame(new StartGameArgs
        {
            GameMode = GameMode.Shared,
            SessionName = textRoomName.text,
            CustomLobbyName = "VN",
        });
    }
    public void SessionListChanged(List<SessionInfo> sessionList)
    {
        foreach (Transform child in parentRoomItem)
        {
            Destroy(child.gameObject);
        }
        foreach(var item in sessionList)
        {
            Instantiate(roomItem, parentRoomItem.transform);
        }
    }
}

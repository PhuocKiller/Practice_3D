using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Fusion.Sockets;
using System;
public class NetworkCallBackManager : MonoBehaviour,INetworkRunnerCallbacks
{
    Action<List<SessionInfo>> listSessionChange;
    Action<NetworkRunner, PlayerRef> onPlayerJoin;
    public void OnPlayerJoinRegister(Action<NetworkRunner, PlayerRef> onPlayerJoin)
    {
        this.onPlayerJoin= onPlayerJoin;
    }
    public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
    {
        onPlayerJoin?.Invoke(runner, player);   
    }

    public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
    {

    }
    public void StartGameRegister(Action<List<SessionInfo>> sessionList)
    {
        this.listSessionChange = sessionList;
    }
    public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
    {
        listSessionChange?.Invoke(sessionList);
    }
    #region
    public void OnConnectedToServer(NetworkRunner runner)
    {

    }

    public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
    {

    }

    public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
    {

    }

    public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
    {

    }

    public void OnDisconnectedFromServer(NetworkRunner runner)
    {

    }

    public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
    {

    }

    public void OnInput(NetworkRunner runner, NetworkInput input)
    {

    }

    public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
    {

    }
    public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
    {

    }

    public void OnSceneLoadDone(NetworkRunner runner)
    {

    }

    public void OnSceneLoadStart(NetworkRunner runner)
    {

    }

    

    public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
    {

    }

    public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
    {

    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

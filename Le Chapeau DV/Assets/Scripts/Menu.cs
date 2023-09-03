using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class Menu : MonoBehaviourPunCallbacks
{
    [Header("Main Screen")]
    public Button createRoomButton;
    public Button joinRoomButton;
    
     [Header("Screens")]
     public GameObject mainScreen;
     public GameObject lobbyScreen;

     [Header("Lobby Screen")]
     public TextMeshProUGUI playerListText;
     public Button startGameButton;


    // Start is called before the first frame update
    void Start()
    {
     // disable the buttons at the start as we're not connected to the server yet
     createRoomButton.interactable = false;
     joinRoomButton.interactable = false;
    }

    // called when we connect to the master server
    // enables the "Create Room" and "Join Room" buttons
    public override void OnConnectedToMaster ()
    {
     createRoomButton.interactable = true;
     joinRoomButton.interactable = true;
    }

    void SetScreen (GameObject screen)
    {
     // deactivate all screens
     mainScreen.SetActive(false);
     lobbyScreen.SetActive(false);
     // enable the requested screen
     screen.SetActive(true);
    }

    public void OnCreateRoomButton (TMP_InputField roomNameInput)
    {
     NetworkManager.instance.CreateRoom(roomNameInput.text);
    }

    public void OnJoinRoomButton (TMP_InputField roomNameInput)
    {
     NetworkManager.instance.JoinRoom(roomNameInput.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
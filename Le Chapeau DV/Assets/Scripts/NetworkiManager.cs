/*    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Photon.Pun;

    public class NetworkiManager : MonoBehaviour
    {
    // instance
    public static NetworkManager instance;
    public class NetworkManager : MonoBehaviourPunCallbacks

        void Awake ()
        {
            // if an instance already exists and it's not this one - destroy us
            if(instance != null && instance != this)
            gameObject.SetActive(false);
            else
            {
                // set the instance
                instance = this;
                DontDestroyOnLoad(gameObject);
            }   
        }

        // Start is called before the first frame update
        void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        // attempt to create a new room
        public void CreateRoom (string roomName)
        {
            PhotonNetwork.CreateRoom(roomName);
        }

        // attempt to join an existing room
        public void CreateRoom (string roomName)
        {
            PhotonNetwork.JoinRoom(roomName);
        }

        public void ChangeScene (string sceneName)
        {
            PhotonNetwork.LoadLevel(sceneName);
        }

        public override void OnConnectedToMaster ()
        {
            Debug.Log("Connected to master server");
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
*/
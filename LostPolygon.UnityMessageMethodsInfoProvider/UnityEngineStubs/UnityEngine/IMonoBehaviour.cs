namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEngine.MonoBehaviour")]
    internal interface IMonoBehaviour {
        [Description("Called when the script instance is being loaded.")]
        [DocumentationName("MonoBehaviour.Awake")]
        [MinimalUnityVersion("4.5")]
        void Awake();

        [Description("Called every frame, if the Behaviour is enabled.")]
        [DocumentationName("MonoBehaviour.FixedUpdate")]
        [MinimalUnityVersion("4.5")]
        void FixedUpdate();

        [Description("Called every frame, if the Behaviour is enabled.")]
        [DocumentationName("MonoBehaviour.LateUpdate")]
        [MinimalUnityVersion("4.5")]
        void LateUpdate();

        [Description("Called on the frame when a script is enabled just before any of the Update methods is called the first time.")]
        [DocumentationName("MonoBehaviour.Start")]
        [MinimalUnityVersion("4.5")]
        void Start();

        [Description("Called every frame, if the MonoBehaviour is enabled.")]
        [DocumentationName("MonoBehaviour.Update")]
        [MinimalUnityVersion("4.5")]
        void Update();

        [Description("Called when the MonoBehaviour will be destroyed.")]
        [DocumentationName("MonoBehaviour.OnDestroy")]
        [MinimalUnityVersion("4.5")]
        void OnDestroy();

        [Description("Called when the behaviour becomes disabled or inactive.")]
        [DocumentationName("MonoBehaviour.OnDisable")]
        [MinimalUnityVersion("4.5")]
        void OnDisable();

        [Description("Called when the object becomes enabled and active.")]
        [DocumentationName("MonoBehaviour.OnEnable")]
        [MinimalUnityVersion("4.5")]
        void OnEnable();

        [Description("Callback for setting up animation IK (inverse kinematics).")]
        [DocumentationName("MonoBehaviour.OnAnimatorIK")]
        [MinimalUnityVersion("4.5")]
        void OnAnimatorIK(int layerIndex );

        [Description("Callback for processing animation movements for modifying root motion.")]
        [DocumentationName("MonoBehaviour.OnAnimatorMove")]
        [MinimalUnityVersion("4.5")]
        void OnAnimatorMove();

        [Description("Sent to all game objects when the player gets or loses focus.")]
        [DocumentationName("MonoBehaviour.OnApplicationFocus")]
        [MinimalUnityVersion("4.5")]
        void OnApplicationFocus(bool focusStatus);

        [Description("Sent to all game objects when the player pauses.")]
        [DocumentationName("MonoBehaviour.OnApplicationPause")]
        [MinimalUnityVersion("4.5")]
        void OnApplicationPause(bool pauseState);

        [Description("Sent to all game objects before the application is quit.")]
        [DocumentationName("MonoBehaviour.OnApplicationQuit")]
        [MinimalUnityVersion("4.5")]
        void OnApplicationQuit();

        [Description("If OnAudioFilterRead is implemented, Unity will insert a custom filter into the audio DSP chain.")]
        [DocumentationName("MonoBehaviour.OnAudioFilterRead")]
        [MinimalUnityVersion("4.5")]
        void OnAudioFilterRead(byte[] data, int channels);

        [Description("Called when the renderer is no longer visible by any camera.")]
        [DocumentationName("MonoBehaviour.OnBecameInvisible")]
        [MinimalUnityVersion("4.5")]
        void OnBecameInvisible();

        [Description("Called when the renderer became visible by any camera.")]
        [DocumentationName("MonoBehaviour.OnBecameVisible")]
        [MinimalUnityVersion("4.5")]
        void OnBecameVisible();

        [Description("Called when this collider/rigidbody has begun touching another rigidbody/collider.")]
        [DocumentationName("MonoBehaviour.OnCollisionEnter")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionEnter(Collision collision);

        [Description("Called when an incoming collider makes contact with this object's collider (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnCollisionEnter2D")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionEnter2D(Collision2D collision2D);

        [Description("Called when this collider/rigidbody has stopped touching another rigidbody/collider.")]
        [DocumentationName("MonoBehaviour.OnCollisionExit")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionExit(Collision collision);

        [Description("Called when a collider on another object stops touching this object's collider (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnCollisionExit2D")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionExit2D(Collision2D collision2D);

        [Description("Called once per frame for every collider/rigidbody that is touching rigidbody/collider.")]
        [DocumentationName("MonoBehaviour.OnCollisionStay")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionStay(Collision collision);

        [Description("Called each frame where a collider on another object is touching this object's collider (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnCollisionStay2D")]
        [MinimalUnityVersion("4.5")]
        void OnCollisionStay2D(Collision2D collision2D);

        [Description("Called on the client when you have successfully connected to a server.")]
        [DocumentationName("MonoBehaviour.OnConnectedToServer")]
        [MinimalUnityVersion("4.5")]
        void OnConnectedToServer();

        [Description("Called when the controller hits a collider while performing a Move.")]
        [DocumentationName("MonoBehaviour.OnControllerColliderHit")]
        [MinimalUnityVersion("4.5")]
        void OnControllerColliderHit(ControllerColliderHit hit);

        [Description("Called on the client when the connection was lost or you disconnected from the server.")]
        [DocumentationName("MonoBehaviour.OnDisconnectedFromServer")]
        [MinimalUnityVersion("4.5")]
        void OnDisconnectedFromServer(NetworkDisconnection info);

        [Description("Implement OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn.")]
        [DocumentationName("MonoBehaviour.OnDrawGizmos")]
        [MinimalUnityVersion("4.5")]
        void OnDrawGizmos();

        [Description("Implement this OnDrawGizmosSelected if you want to draw gizmos only if the object is selected.")]
        [DocumentationName("MonoBehaviour.OnDrawGizmosSelected")]
        [MinimalUnityVersion("4.5")]
        void OnDrawGizmosSelected();

        [Description("Called on the client when a connection attempt fails for some reason.")]
        [DocumentationName("MonoBehaviour.OnFailedToConnect")]
        [MinimalUnityVersion("4.5")]
        void OnFailedToConnect(NetworkConnectionError error);

        [Description("Called on clients or servers when there is a problem connecting to the MasterServer.")]
        [DocumentationName("MonoBehaviour.OnFailedToConnectToMasterServer")]
        [MinimalUnityVersion("4.5")]
        void OnFailedToConnectToMasterServer(NetworkConnectionError error);

        [Description("Called for rendering and handling GUI events.")]
        [DocumentationName("MonoBehaviour.OnGUI")]
        [MinimalUnityVersion("4.5")]
        void OnGUI();

        [Description("Called when a joint attached to the same game object broke.")]
        [DocumentationName("MonoBehaviour.OnJointBreak")]
        [MinimalUnityVersion("4.5")]
        void OnJointBreak(float breakForce);

        [Description("Called after a new level was loaded.")]
        [DocumentationName("MonoBehaviour.OnLevelWasLoaded")]
        [MinimalUnityVersion("4.5")]
        void OnLevelWasLoaded(int level);

        [Description("Called on clients or servers when reporting events from the MasterServer.")]
        [DocumentationName("MonoBehaviour.OnMasterServerEvent")]
        [MinimalUnityVersion("4.5")]
        void OnMasterServerEvent(MasterServerEvent masterServerEvent);

        [Description("Called when the user has pressed the mouse button while over the GUIElement or Collider.")]
        [DocumentationName("MonoBehaviour.OnMouseDown")]
        [MinimalUnityVersion("4.5")]
        void OnMouseDown();

        [Description("Called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.")]
        [DocumentationName("MonoBehaviour.OnMouseDrag")]
        [MinimalUnityVersion("4.5")]
        void OnMouseDrag();

        [Description("Called when the mouse entered the GUIElement or Collider.")]
        [DocumentationName("MonoBehaviour.OnMouseEnter")]
        [MinimalUnityVersion("4.5")]
        void OnMouseEnter();

        [Description("Called when the mouse is not any longer over the GUIElement or Collider.")]
        [DocumentationName("MonoBehaviour.OnMouseExit")]
        [MinimalUnityVersion("4.5")]
        void OnMouseExit();

        [Description("Called every frame while the mouse is over the GUIElement or Collider.")]
        [DocumentationName("MonoBehaviour.OnMouseOver")]
        [MinimalUnityVersion("4.5")]
        void OnMouseOver();

        [Description("Called when the user has released the mouse button.")]
        [DocumentationName("MonoBehaviour.OnMouseUp")]
        [MinimalUnityVersion("4.5")]
        void OnMouseUp();

        [Description("Only called when the mouse is released over the same GUIElement or Collider as it was pressed.")]
        [DocumentationName("MonoBehaviour.OnMouseUpAsButton")]
        [MinimalUnityVersion("4.5")]
        void OnMouseUpAsButton();

        [Description("Called on objects which have been network instantiated with Network.Instantiate.")]
        [DocumentationName("MonoBehaviour.OnNetworkInstantiate")]
        [MinimalUnityVersion("4.5")]
        void OnNetworkInstantiate(NetworkMessageInfo info);

        [Description("Called when a particle hits a collider.")]
        [DocumentationName("MonoBehaviour.OnParticleCollision")]
        [MinimalUnityVersion("4.5")]
        void OnParticleCollision(GameObject other);

        [Description("Called on the server whenever a new player has successfully connected.")]
        [DocumentationName("MonoBehaviour.OnPlayerConnected")]
        [MinimalUnityVersion("4.5")]
        void OnPlayerConnected(NetworkPlayer player);

        [Description("Called on the server whenever a player disconnected from the server.")]
        [DocumentationName("MonoBehaviour.OnPlayerDisconnected")]
        [MinimalUnityVersion("4.5")]
        void OnPlayerDisconnected(NetworkPlayer player);

        [Description("Called after a camera finished rendering the scene.")]
        [DocumentationName("MonoBehaviour.OnPostRender")]
        [MinimalUnityVersion("4.5")]
        void OnPostRender();

        [Description("Called before a camera culls the scene.")]
        [DocumentationName("MonoBehaviour.OnPreCull")]
        [MinimalUnityVersion("4.5")]
        void OnPreCull();

        [Description("Called before a camera starts rendering the scene.")]
        [DocumentationName("MonoBehaviour.OnPreRender")]
        [MinimalUnityVersion("4.5")]
        void OnPreRender();

        [Description("Called after all rendering is complete to render image.")]
        [DocumentationName("MonoBehaviour.OnRenderImage")]
        [MinimalUnityVersion("4.5")]
        void OnRenderImage(RenderTexture source, RenderTexture destination);

        [Description("Called after camera has rendered the scene.")]
        [DocumentationName("MonoBehaviour.OnRenderObject")]
        [MinimalUnityVersion("4.5")]
        void OnRenderObject();

        [Description("Used to customize synchronization of variables in a script watched by a network view.")]
        [DocumentationName("MonoBehaviour.OnSerializeNetworkView")]
        [MinimalUnityVersion("4.5")]
        void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info);

        [Description("Called on the server whenever a Network.InitializeServer was invoked and has completed.")]
        [DocumentationName("MonoBehaviour.OnServerInitialized")]
        [MinimalUnityVersion("4.5")]
        void OnServerInitialized();

        [Description("Called when the Collider other enters the trigger.")]
        [DocumentationName("MonoBehaviour.OnTriggerEnter")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerEnter(Collider other);

        [Description("V when another object enters a trigger collider attached to this object (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnTriggerEnter2D")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerEnter2D(Collider2D other);

        [Description("Called when the Collider other has stopped touching the trigger.")]
        [DocumentationName("MonoBehaviour.OnTriggerExit")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerExit(Collider other);

        [Description("Called when another object leaves a trigger collider attached to this object (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnTriggerExit2D")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerExit2D(Collider2D other);

        [Description("Called once per frame for every Collider other that is touching the trigger.")]
        [DocumentationName("MonoBehaviour.OnTriggerStay")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerStay(Collider other);

        [Description("Called each frame where another object is within a trigger collider attached to this object (2D physics only).")]
        [DocumentationName("MonoBehaviour.OnTriggerStay2D")]
        [MinimalUnityVersion("4.5")]
        void OnTriggerStay2D(Collider2D other);

        [Description("Called when the script is loaded or a value is changed in the inspector (Called in the editor only).")]
        [DocumentationName("MonoBehaviour.OnValidate")]
        [MinimalUnityVersion("4.5")]
        void OnValidate();

        [Description("Called once for each camera if the object is visible.")]
        [DocumentationName("MonoBehaviour.OnWillRenderObject")]
        [MinimalUnityVersion("4.5")]
        void OnWillRenderObject();

        [Description("Reset to default values.")]
        [DocumentationName("MonoBehaviour.Reset")]
        [MinimalUnityVersion("4.5")]
        void Reset();

        [Description("Called when the parent property of the transform of the GameObject has changed.")]
        [DocumentationName("MonoBehaviour.OnTransformParentChanged")]
        [MinimalUnityVersion("4.6")]
        void OnTransformParentChanged();

        [Description("Called when the list of children of the transform of the GameObject has changed.")]
        [DocumentationName("MonoBehaviour.OnTransformChildrenChanged")]
        [MinimalUnityVersion("4.6")]
        void OnTransformChildrenChanged();
    }
}
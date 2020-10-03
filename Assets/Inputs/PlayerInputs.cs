// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""ClassicPlayer"",
            ""id"": ""1d15a932-e607-457f-be9f-6db80b22d7d5"",
            ""actions"": [
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""1610c805-198f-4c40-828a-73469cd25c0c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e5aa9817-3708-4801-be4f-705ec28028f4"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""df747bd2-2bee-4b46-a76a-bc6797fcd0b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""aa5412da-ec12-40ba-9e9f-e89105a4e64b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartLevel"",
                    ""type"": ""Button"",
                    ""id"": ""92651cd8-fb54-4d3a-bf9b-b8e1eb5195ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shot"",
                    ""type"": ""Button"",
                    ""id"": ""4bd04950-d029-4afa-8399-eeaf3f7341c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95545cff-2ca8-4ca3-b762-e4733505ed06"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5461dde9-c5ac-4b00-b286-16015a8bf1f9"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""45a2b176-cce3-4280-af28-8074ce4afecd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6f6de87-1e65-43d4-867e-fec149d95d49"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e6a78fa0-3c81-4f62-bcfd-15abe44659b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5dd0da35-4c8d-4d21-909e-8c633e633415"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ea0f8465-86fe-4161-9b9e-19773c7d5db8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS4"",
                    ""id"": ""b2cd717d-5fa1-4663-b2be-29e32c4ba921"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e5be2a2b-3b0f-4d4a-aa48-5e8974750674"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7d7a2386-07ab-4a77-bde1-56160b111e9b"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7d2d3448-48f2-40f2-b843-7415d8393ddb"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1bbb5cc6-c102-4eae-b49f-7c816d870348"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1a4596a3-7419-4356-89d8-6597047fcfd3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99383696-0223-49a6-a333-f21d29124f24"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""678e57d4-340b-46c0-be93-7d8d478df432"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf97740b-0c97-4d4e-bd20-cde24f76f91f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ClassicPlayer
        m_ClassicPlayer = asset.FindActionMap("ClassicPlayer", throwIfNotFound: true);
        m_ClassicPlayer_MouseDelta = m_ClassicPlayer.FindAction("MouseDelta", throwIfNotFound: true);
        m_ClassicPlayer_Movement = m_ClassicPlayer.FindAction("Movement", throwIfNotFound: true);
        m_ClassicPlayer_Interaction = m_ClassicPlayer.FindAction("Interaction", throwIfNotFound: true);
        m_ClassicPlayer_Pause = m_ClassicPlayer.FindAction("Pause", throwIfNotFound: true);
        m_ClassicPlayer_RestartLevel = m_ClassicPlayer.FindAction("RestartLevel", throwIfNotFound: true);
        m_ClassicPlayer_Shot = m_ClassicPlayer.FindAction("Shot", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ClassicPlayer
    private readonly InputActionMap m_ClassicPlayer;
    private IClassicPlayerActions m_ClassicPlayerActionsCallbackInterface;
    private readonly InputAction m_ClassicPlayer_MouseDelta;
    private readonly InputAction m_ClassicPlayer_Movement;
    private readonly InputAction m_ClassicPlayer_Interaction;
    private readonly InputAction m_ClassicPlayer_Pause;
    private readonly InputAction m_ClassicPlayer_RestartLevel;
    private readonly InputAction m_ClassicPlayer_Shot;
    public struct ClassicPlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public ClassicPlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseDelta => m_Wrapper.m_ClassicPlayer_MouseDelta;
        public InputAction @Movement => m_Wrapper.m_ClassicPlayer_Movement;
        public InputAction @Interaction => m_Wrapper.m_ClassicPlayer_Interaction;
        public InputAction @Pause => m_Wrapper.m_ClassicPlayer_Pause;
        public InputAction @RestartLevel => m_Wrapper.m_ClassicPlayer_RestartLevel;
        public InputAction @Shot => m_Wrapper.m_ClassicPlayer_Shot;
        public InputActionMap Get() { return m_Wrapper.m_ClassicPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClassicPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IClassicPlayerActions instance)
        {
            if (m_Wrapper.m_ClassicPlayerActionsCallbackInterface != null)
            {
                @MouseDelta.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMouseDelta;
                @Movement.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnMovement;
                @Interaction.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnInteraction;
                @Pause.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnPause;
                @RestartLevel.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnRestartLevel;
                @RestartLevel.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnRestartLevel;
                @RestartLevel.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnRestartLevel;
                @Shot.started -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnShot;
                @Shot.performed -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnShot;
                @Shot.canceled -= m_Wrapper.m_ClassicPlayerActionsCallbackInterface.OnShot;
            }
            m_Wrapper.m_ClassicPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @RestartLevel.started += instance.OnRestartLevel;
                @RestartLevel.performed += instance.OnRestartLevel;
                @RestartLevel.canceled += instance.OnRestartLevel;
                @Shot.started += instance.OnShot;
                @Shot.performed += instance.OnShot;
                @Shot.canceled += instance.OnShot;
            }
        }
    }
    public ClassicPlayerActions @ClassicPlayer => new ClassicPlayerActions(this);
    public interface IClassicPlayerActions
    {
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRestartLevel(InputAction.CallbackContext context);
        void OnShot(InputAction.CallbackContext context);
    }
}

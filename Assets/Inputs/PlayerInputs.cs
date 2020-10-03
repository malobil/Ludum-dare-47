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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ClassicPlayer
        m_ClassicPlayer = asset.FindActionMap("ClassicPlayer", throwIfNotFound: true);
        m_ClassicPlayer_MouseDelta = m_ClassicPlayer.FindAction("MouseDelta", throwIfNotFound: true);
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
    public struct ClassicPlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public ClassicPlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseDelta => m_Wrapper.m_ClassicPlayer_MouseDelta;
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
            }
            m_Wrapper.m_ClassicPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
            }
        }
    }
    public ClassicPlayerActions @ClassicPlayer => new ClassicPlayerActions(this);
    public interface IClassicPlayerActions
    {
        void OnMouseDelta(InputAction.CallbackContext context);
    }
}

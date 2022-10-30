//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Code/UIButtonTriggers.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UIButtonTriggers : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIButtonTriggers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIButtonTriggers"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""8f5d19d0-42cb-4e34-981b-fb6794467be1"",
            ""actions"": [
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""50849a41-8f30-43bb-8020-bf11bf11cbcd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""f416f765-5838-47b2-ae3b-ce96b1e07d5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Options"",
                    ""type"": ""Button"",
                    ""id"": ""bccae15e-d539-4b87-812d-8882a8a8125d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""731793d8-d6de-49df-b35e-89c6238722ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Volume"",
                    ""type"": ""Value"",
                    ""id"": ""2f4b105d-2f71-48fe-b08b-031f3fa2e0b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sfx"",
                    ""type"": ""Value"",
                    ""id"": ""2714e477-650e-4239-a92c-77128b6236ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""39fe80f1-61ad-495b-a085-666bfb8bb6ce"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8e063b5-e542-41fd-be64-2a0e46ef1a7c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7df00dc0-a617-4aa5-8aec-19d281e35aaa"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Options"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ec0ad97-ebcd-4102-be7e-0c6448062784"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6807a8e2-303c-41a0-83f4-eef0d27b0b1b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Volume"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5653af09-1ac3-4a8b-8797-abc0476245ee"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Volume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c622c968-dc37-425e-8a5a-e05ca2100a14"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Volume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b92c8c32-a0a4-40ef-b6e5-67e03dac52c3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sfx"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f674140-3d45-466a-8cf0-e80cacc3ebc5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sfx"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5330867e-f947-413f-ac63-3daa7b013be2"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sfx"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Play = m_UI.FindAction("Play", throwIfNotFound: true);
        m_UI_Quit = m_UI.FindAction("Quit", throwIfNotFound: true);
        m_UI_Options = m_UI.FindAction("Options", throwIfNotFound: true);
        m_UI_Restart = m_UI.FindAction("Restart", throwIfNotFound: true);
        m_UI_Volume = m_UI.FindAction("Volume", throwIfNotFound: true);
        m_UI_Sfx = m_UI.FindAction("Sfx", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Play;
    private readonly InputAction m_UI_Quit;
    private readonly InputAction m_UI_Options;
    private readonly InputAction m_UI_Restart;
    private readonly InputAction m_UI_Volume;
    private readonly InputAction m_UI_Sfx;
    public struct UIActions
    {
        private @UIButtonTriggers m_Wrapper;
        public UIActions(@UIButtonTriggers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play => m_Wrapper.m_UI_Play;
        public InputAction @Quit => m_Wrapper.m_UI_Quit;
        public InputAction @Options => m_Wrapper.m_UI_Options;
        public InputAction @Restart => m_Wrapper.m_UI_Restart;
        public InputAction @Volume => m_Wrapper.m_UI_Volume;
        public InputAction @Sfx => m_Wrapper.m_UI_Sfx;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Play.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPlay;
                @Play.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPlay;
                @Play.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPlay;
                @Quit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Options.started -= m_Wrapper.m_UIActionsCallbackInterface.OnOptions;
                @Options.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnOptions;
                @Options.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnOptions;
                @Restart.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRestart;
                @Volume.started -= m_Wrapper.m_UIActionsCallbackInterface.OnVolume;
                @Volume.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnVolume;
                @Volume.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnVolume;
                @Sfx.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSfx;
                @Sfx.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSfx;
                @Sfx.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSfx;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Play.started += instance.OnPlay;
                @Play.performed += instance.OnPlay;
                @Play.canceled += instance.OnPlay;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
                @Options.started += instance.OnOptions;
                @Options.performed += instance.OnOptions;
                @Options.canceled += instance.OnOptions;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Volume.started += instance.OnVolume;
                @Volume.performed += instance.OnVolume;
                @Volume.canceled += instance.OnVolume;
                @Sfx.started += instance.OnSfx;
                @Sfx.performed += instance.OnSfx;
                @Sfx.canceled += instance.OnSfx;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnPlay(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnOptions(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnVolume(InputAction.CallbackContext context);
        void OnSfx(InputAction.CallbackContext context);
    }
}

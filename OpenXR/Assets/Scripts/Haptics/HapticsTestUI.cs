using System.Threading;
using Cysharp.Threading.Tasks;
using Sonosthesia.Haptic;
using UnityEngine;
using UnityEngine.UI;

namespace Sonosthesia
{
    public class HapticsTestUI : MonoBehaviour
    {
        [SerializeField] private HapticController _controller;
        
        [SerializeField] private Button _impulseButton;

        [SerializeField] private Toggle _rumbleToggle;
        
        [SerializeField] private Slider _amplitudeSlider;
        
        [SerializeField] private Slider _durationSlider;
        
        [SerializeField] private Slider _periodSlider;

        private CancellationTokenSource _rumbleCancellationTokenSource;

        protected virtual void Awake()
        {
            _amplitudeSlider.minValue = 0f;
            _amplitudeSlider.maxValue = 1f;
            _amplitudeSlider.value = 0.5f;
            
            _durationSlider.minValue = 0f;
            _durationSlider.maxValue = 1f;
            _durationSlider.value = 0.3f;
            
            _periodSlider.minValue = 0f;
            _periodSlider.maxValue = 1f;
            _periodSlider.value = 1f;
        }

        protected virtual void OnEnable()
        {
            _impulseButton.onClick.AddListener(Impulse);
            _rumbleToggle.onValueChanged.AddListener(Rumble);
        }
        
        protected virtual void OnDisable()
        {
            _impulseButton.onClick.RemoveListener(Impulse);
            _rumbleToggle.onValueChanged.RemoveListener(Rumble);
        }

        protected virtual void Impulse()
        {
            _controller.SendHapticImpulse(_amplitudeSlider.value, _durationSlider.value);
        }

        protected virtual void Rumble(bool on)
        {
            _rumbleCancellationTokenSource?.Cancel();
            if (on)
            {
                _rumbleCancellationTokenSource = new CancellationTokenSource();
                _controller.Rumble(() => _amplitudeSlider.value, 
                    () => _durationSlider.value, 
                    () => _periodSlider.value, 
                    _rumbleCancellationTokenSource.Token).Forget();
            }
            else
            {
                _rumbleCancellationTokenSource = null;
            }
        }
        
    }
}
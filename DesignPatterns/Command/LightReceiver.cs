using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightReceiver
    {
        bool _state;
        string _color;

        public void ToggleSwitch() {
            _state = !_state;
            DisplayLight();
        }

        public void SetColor(string color) {
            _color = color;
            DisplayLight();
        }

        private void DisplayLight() {
            Console.WriteLine("{0} light is swithched {1}", _color, _state ? "on" : "off");
        }

    }
}

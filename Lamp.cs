using System;

namespace T3Activitats
{
    public class Lamp
    {
        private bool IsOn;
        private string Color;

        // Getters
        public bool GetIsOn() { return IsOn; }
        public string GetColor() { return Color; }
        //Setters
        public void SetIsOn(bool isOn) { IsOn = isOn; }
        public void SetColor(string color)
        
        { if (string.IsNullOrEmpty(color))
            {
                throw new ArgumentException("Color cannot be null or empty");
            }

            Color = color; }
        // Constructor
        public Lamp (bool isOn, string color)
        {
            SetIsOn(isOn);
            SetColor(color);
        }
    }
}

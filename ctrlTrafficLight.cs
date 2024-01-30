using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Project.Properties;

namespace Traffic_Light_Project
{
    public partial class ctrlTrafficLight : UserControl
    {
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public enum LightEnum { Red = 0, Orange = 1, Green = 2}

        private LightEnum _CurrentLight = LightEnum.Red;
        public LightEnum CurrentLight
        {
              get { return _CurrentLight; }

            set {
                
                _CurrentLight = value; 

                switch(_CurrentLight)
                {
                    case LightEnum.Red:
                        pbLight.Image = Resources.Red;
                        //lblCountDown.ForeColor = Color.Red;
                        break;
                    case LightEnum.Orange:
                        pbLight.Image = Resources.Orange;
                        //lblCountDown.ForeColor = Color.Orange;
                        break;
                        case LightEnum.Green:
                        pbLight.Image = Resources.Green;
                        //lblCountDown.ForeColor = Color.Green;
                        break;
                }
            
            }
        }

        private int _RedTime = 10;

        private int _OrangeTime = 6;

        private int _GreenTime = 5;

        public int RedTime
        {
            get { return _RedTime; }

            set
            {
                _RedTime = value;
            }
        }

        public int OrangeTime
        {
            get { return _OrangeTime; }

            set
            {
                _OrangeTime = value;
            }
        }

        public int GreenTime
        {
            get { return _GreenTime; }

            set
            {
                _GreenTime = value;
            }
        }

        public int _CurrentCountDownValue;

        public class TrafficLightEventArgs : EventArgs
        {

            public LightEnum CurrentLight;

            public int LightDuration;

            public TrafficLightEventArgs(LightEnum CurrentLight, int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration;
            }
        }

        public event EventHandler <TrafficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TrafficLightEventArgs(LightEnum.Red,_RedTime));
        }
        protected virtual void RaiseRedLightOn(TrafficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }


        public event EventHandler<TrafficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TrafficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TrafficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }


        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TrafficLightEventArgs(LightEnum.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> FirstTrafficLightOn;
        public void RaiseFirstTrafficLightOn()
        {
            RaiseFirstTrafficLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseFirstTrafficLightOn(TrafficLightEventArgs e)
        {
            FirstTrafficLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> SecondTrafficLightOn;
        public void RaiseSecondTrafficLightOn()
        {
            RaiseSecondTrafficLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseSecondTrafficLightOn(TrafficLightEventArgs e)
        {
            SecondTrafficLightOn?.Invoke(this, e);
        }

        public event EventHandler<TrafficLightEventArgs> ThirdTrafficLightOn;
        public void RaiseThirdTrafficLightOn()
        {
            RaiseThirdTrafficLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseThirdTrafficLightOn(TrafficLightEventArgs e)
        {
            ThirdTrafficLightOn?.Invoke(this, e);
        }


        public event EventHandler<TrafficLightEventArgs> FourthTrafficLightOn;
        public void RaiseFourthTrafficLightOn()
        {
            RaiseFourthTrafficLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseFourthTrafficLightOn(TrafficLightEventArgs e)
        {
            FourthTrafficLightOn?.Invoke(this, e);
        }

        public int GetCurrentTime()
        {
            switch(_CurrentLight)
            {
                case LightEnum.Red:
                    return _RedTime;
                case LightEnum.Orange:
                    return _OrangeTime;
              case LightEnum.Green:
                    return _GreenTime;
                default:
                    return _RedTime;
            }
        }
        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            //lblCountDown.Text = _CurrentCountDownValue.ToString();

            LightTimer.Start();
        }
        private void LightTimer_Tick(object sender, EventArgs e)
        {
            //lblCountDown.Text = _CurrentCountDownValue.ToString();

            if (_CurrentCountDownValue == 0)
            {
                _ChangeLight();
            } else
            {
                --_CurrentCountDownValue;
            }
        }

        private LightEnum _LightAfterOrangeGreenOrRed;
        private void _ChangeLight()
        {
            switch (_CurrentLight)
            {
                case LightEnum.Red:
                    _LightAfterOrangeGreenOrRed = LightEnum.Green;
                    _CurrentCountDownValue = _OrangeTime;
                    CurrentLight = LightEnum.Orange;
                    //lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                case LightEnum.Orange:
                    if (_LightAfterOrangeGreenOrRed == LightEnum.Green)
                    {
                        _CurrentCountDownValue = _GreenTime;
                        CurrentLight = LightEnum.Green;
                        //lblCountDown.Text = _CurrentCountDownValue.ToString();

                        RaiseGreenLightOn();
                    }
                    else
                    {
                        _CurrentCountDownValue = _RedTime;
                        CurrentLight = LightEnum.Red;
                        //lblCountDown.Text = _CurrentCountDownValue.ToString();
                      //  RaiseRedLightOn();
                        LightTimer.Stop();


                        RaiseSecondTrafficLightOn();

                        RaiseThirdTrafficLightOn();

                        RaiseFourthTrafficLightOn();

                        RaiseFirstTrafficLightOn();

                    }

                    break;
                case LightEnum.Green:
                    _LightAfterOrangeGreenOrRed = LightEnum.Red;
                    _CurrentCountDownValue = _OrangeTime;
                    CurrentLight = LightEnum.Orange;
                    //lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                default:
                    pbLight.Image = Resources.Red;
                    break;
            }
        }
    }
}

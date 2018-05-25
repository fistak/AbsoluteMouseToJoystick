﻿using AbsoluteMouseToJoystick.Logging;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteMouseToJoystick.Data
{
    public class Settings : ObservableObject, ISettingsManager
    {
        public Settings(ISimpleLogger logger)
        {
            _logger = logger;
        }

        public void Load(ISettings settings)
        {
            this.ResolutionX = settings.ResolutionX;
            this.ResolutionY = settings.ResolutionY;
            this.TimerInterval = settings.TimerInterval;
            this.DeviceID = settings.DeviceID;
            this.AxisX = settings.AxisX;
            this.AxisY = settings.AxisY;
            this.AxisZ = settings.AxisZ;
        }

        public int ResolutionX
        {
            get => _resolutionX;
            set
            {
                Set(ref _resolutionX, value);
                _logger?.Log("Resolution X changed");
            }
        }
        public int ResolutionY
        {
            get => _resolutionY;
            set
            {
                Set(ref _resolutionY, value);
                _logger?.Log("Resolution Y changed");
            }
        }

        public double TimerInterval
        {
            get => _timerInterval;
            set
            {
                Set(ref _timerInterval, value);
                _logger?.Log("Timer interval changed");
            }
        }

        public uint DeviceID
        {
            get => _deviceID;
            set
            {
                Set(ref _deviceID, value);
                _logger?.Log("Device ID changed");
            }
        }

        public AxisSettings AxisX
        {
            get => _axisX;
            set => Set(ref _axisX, value);
        }

        public AxisSettings AxisY
        {
            get => _axisY;
            set => Set(ref _axisY, value);
        }

        public AxisSettings AxisZ
        {
            get => _axisZ;
            set => Set(ref _axisZ, value);
        }

        private readonly ISimpleLogger _logger;

        private int _resolutionX = 1920;
        private int _resolutionY = 1080;
        private double _timerInterval = 5;
        private uint _deviceID = 1;

        private AxisSettings _axisX = new AxisSettings { MouseAxis = MouseAxis.X };
        private AxisSettings _axisY = new AxisSettings { MouseAxis = MouseAxis.Y };
        private AxisSettings _axisZ = new AxisSettings();
    }
}
